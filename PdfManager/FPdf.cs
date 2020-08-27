using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Drawing;

namespace PdfManager
{
    public partial class FPdf : Form
    {
        private Dictionary<string, PdfDocument> PdfDocuments { get; set; }
        public FPdf()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FolderSelect_Enter(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (sender is TextBox sourceTextBox)
                {
                    sourceTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void FileSelect_Enter(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (sender is TextBox sourceTextBox)
                {
                    sourceTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox sourceControl)
            {
                switch (sourceControl.Name)
                {
                    case nameof(cbMergeFiles):
                        {
                            pnMergeFiles.Enabled = sourceControl.Checked;
                            break;
                        }
                    case nameof(cbApplyAdditionalInfo):
                        {
                            pnAdditionalInfo.Enabled = sourceControl.Checked;
                            break;
                        }
                    case nameof(cbApplyBgImage):
                        {
                            pnApplyBgImage.Enabled = sourceControl.Checked;
                            break;
                        }
                    case nameof(cbProtectFile):
                        {
                            pnProtectFile.Enabled = sourceControl.Checked;
                            break;
                        }
                    case nameof(cbRenameFile):
                        {
                            pnRenameFiles.Enabled = sourceControl.Checked;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            PdfDocuments = new Dictionary<string, PdfDocument>();

            if (VerifyRequiredFields())
            {
                ExecuteMerge();
                ExecuteApplyImage();
                ExecuteApplyAdditionalInfo();
                ExecuteProtecteFile();
                ExecuteRenameFiles();
                ExecuteSaveFiles();
            }
        }

        private bool VerifyRequiredFields()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(txtSourceFolder.Text))
                errors.AppendLine("O campo 'Pasta de origem' é obrigatório");
            if (string.IsNullOrEmpty(txtTargetFolder.Text))
                errors.AppendLine("O campo 'Pasta de destino' é obrigatório");
            if (cbApplyBgImage.Checked)
                if (string.IsNullOrEmpty(txtBgImage.Text))
                    errors.AppendLine("O campo 'Imagem de fundo' é obrigatório");
            if (cbMergeFiles.Checked)
            {
                if (string.IsNullOrEmpty(txtMergeFirstFile.Text))
                    errors.AppendLine("O campo 'Nome final do arquivo de frente' é obrigatório");
                if (string.IsNullOrEmpty(txtMergeSecondFile.Text))
                    errors.AppendLine("O campo 'Nome final do arquivo de verso' é obrigatório");
            }
            if (cbProtectFile.Checked)
                if (string.IsNullOrEmpty(txtProtectFileCSVFile.Text))
                    errors.AppendLine("O campo 'Arquivo CSV' para proteger arquivos é obrigatório");
            if (cbRenameFile.Checked)
                if (string.IsNullOrEmpty(txtRenameFileCSVFile.Text))
                    errors.AppendLine("O campo 'Arquivo CSV' para renomear arquivos é obrigatório");
            if (cbApplyAdditionalInfo.Checked)
                if (string.IsNullOrEmpty(txtAdditionalInfoCSVFile.Text))
                    errors.AppendLine("O campo 'Arquivo CSV' para adicionar informações é obrigatório");

            if (errors.Length > 0)
            {
                if (MessageBox.Show(errors.ToString(), "Preencha os campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return false;
                }
            }

            return true;
        }

        private void ExecuteMerge()
        {
            if (cbMergeFiles.Checked)
            {
                string[] sourceFiles = System.IO.Directory.GetFiles(txtSourceFolder.Text, "*.pdf");

                if (sourceFiles != null && sourceFiles.Any())
                {
                    sourceFiles = sourceFiles.OrderBy(w => w).ToArray();

                    string firstFile = txtMergeFirstFile.Text;
                    string secondFile = txtMergeSecondFile.Text;

                    List<string> filesToMerge = new List<string>();

                    string currentFile = string.Empty;

                    foreach (string item in sourceFiles)
                    {
                        if (string.IsNullOrEmpty(currentFile))
                        {
                            // TODO: método para nome do arquivo
                            currentFile = item
                                .Replace(firstFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace(secondFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace($"{txtSourceFolder.Text}", "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace("\\", "", StringComparison.InvariantCultureIgnoreCase);
                        }

                        if (item.Replace(firstFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace(secondFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace($"{txtSourceFolder.Text}", "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace("\\", "", StringComparison.InvariantCultureIgnoreCase) == currentFile)
                        {
                            filesToMerge.Add(item);
                        }
                        else
                        {
                            MergeFiles(filesToMerge, currentFile);

                            filesToMerge = new List<string>
                            {
                                item
                            };
                        }

                        currentFile = item
                                .Replace(firstFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace(secondFile, "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace($"{txtSourceFolder.Text}", "", StringComparison.InvariantCultureIgnoreCase)
                                .Replace("\\", "", StringComparison.InvariantCultureIgnoreCase);
                    }

                    if (!string.IsNullOrEmpty(currentFile))
                    {
                        MergeFiles(filesToMerge, currentFile);
                    }
                }
            }
        }
        private void MergeFiles(List<string> files, string fileName)
        {
            PdfDocument outputDocument = new PdfDocument();

            foreach (string file in files)
            {
                using PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                for (int i = 0; i < inputDocument.PageCount; i++)
                {
                    PdfPage page = inputDocument.Pages[i];
                    outputDocument.AddPage(page);
                }
            }

            fileName = fileName.Trim();

            PdfDocuments.Add(fileName, outputDocument);
        }

        private void ExecuteApplyImage()
        {
            if (cbApplyBgImage.Checked)
            {
                LoadDocuments();

                if (PdfDocuments != null && PdfDocuments.Any())
                {
                    foreach (KeyValuePair<string, PdfDocument> item in PdfDocuments)
                    {
                        if (item.Value.PageCount > 0)
                        {
                            XGraphicsPdfPageOptions position = cbApplyFrontImage.Checked ? XGraphicsPdfPageOptions.Append : XGraphicsPdfPageOptions.Prepend;
                            PdfPage page = item.Value.Pages[0];
                            XGraphics gfx = XGraphics.FromPdfPage(page, position);
                            XImage image = XImage.FromFile(txtBgImage.Text);
                            gfx.DrawImage(image, 0, 0, page.Width.Point, page.Height.Point);
                        }
                    }
                }
            }
        }

        private void ExecuteApplyAdditionalInfo()
        {
            if (cbApplyAdditionalInfo.Checked)
            {
                LoadDocuments();

                if (PdfDocuments != null && PdfDocuments.Any())
                {
                    string[] registros = System.IO.File.ReadAllLines(txtAdditionalInfoCSVFile.Text);

                    string csvSeparator = CheckCSVSeparator(registros);

                    if (registros != null && registros.Any())
                    {
                        foreach (KeyValuePair<string, PdfDocument> item in PdfDocuments)
                        {
                            string[] tmp = item.Key.Split("\\", StringSplitOptions.RemoveEmptyEntries);

                            if (tmp != null && tmp.Any())
                            {
                                string arquivo = tmp.Last();
                                arquivo = arquivo.Replace(".pdf", "", StringComparison.InvariantCultureIgnoreCase);

                                if (registros.Any(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1))
                                {
                                    string[] linha = registros.First(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1).Split(csvSeparator, StringSplitOptions.RemoveEmptyEntries);
                                    if (linha != null && linha.Any())
                                    {
                                        string registro = linha[3];
                                        string nome = linha[1];
                                        string data = linha[4];
                                        string livro = linha[5];
                                        string folha = linha[6];
                                        string[] dataFinal = data.Split("/", StringSplitOptions.RemoveEmptyEntries);

                                        // adicionar texto
                                        if (item.Value.PageCount > 0)
                                        {
                                            PdfPage page = item.Value.Pages[1];
                                            XGraphics gfx = XGraphics.FromPdfPage(page);
                                            XFont font = new XFont("Courier", 12.0);
                                            XFont font2 = new XFont("Courier", 8.0);
                                            gfx.DrawString(registro, font, XBrushes.Black, 540, 410);

                                            gfx.DrawString(livro, font2, XBrushes.Black, 455, 430);
                                            gfx.DrawString(folha, font, XBrushes.Black, 545, 430);

                                            gfx.DrawString(dataFinal[0], font, XBrushes.Black, 450, 455);
                                            gfx.DrawString(dataFinal[1], font, XBrushes.Black, 500, 455);
                                            gfx.DrawString(dataFinal[2], font, XBrushes.Black, 550, 455);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ExecuteProtecteFile()
        {
            if (cbProtectFile.Checked)
            {
                LoadDocuments();

                if (PdfDocuments != null && PdfDocuments.Any())
                {
                    string[] registros = System.IO.File.ReadAllLines(txtAdditionalInfoCSVFile.Text);

                    string csvSeparator = CheckCSVSeparator(registros);

                    if (registros != null && registros.Any())
                    {
                        foreach (KeyValuePair<string, PdfDocument> item in PdfDocuments)
                        {
                            string[] tmp = item.Key.Split("\\", StringSplitOptions.RemoveEmptyEntries);

                            if (tmp != null && tmp.Any())
                            {
                                string arquivo = tmp.Last();
                                arquivo = arquivo.Replace(".pdf", "", StringComparison.InvariantCultureIgnoreCase);

                                if (registros.Any(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1))
                                {
                                    string[] linha = registros.First(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1).Split(csvSeparator, StringSplitOptions.RemoveEmptyEntries);
                                    if (linha != null && linha.Any())
                                    {
                                        PdfSharpCore.Pdf.Security.PdfSecuritySettings securitySettings = item.Value.SecuritySettings;
                                        securitySettings.UserPassword = arquivo.Replace(".", "", StringComparison.InvariantCultureIgnoreCase).Replace("-", "", StringComparison.InvariantCultureIgnoreCase);
                                        securitySettings.OwnerPassword = arquivo;

                                        securitySettings.PermitAccessibilityExtractContent = false;
                                        securitySettings.PermitAnnotations = false;
                                        securitySettings.PermitAssembleDocument = false;
                                        securitySettings.PermitExtractContent = false;
                                        securitySettings.PermitFormsFill = true;
                                        securitySettings.PermitFullQualityPrint = true;
                                        securitySettings.PermitModifyDocument = false;
                                        securitySettings.PermitPrint = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ExecuteRenameFiles()
        {
            if (cbRenameFile.Checked)
            {
                LoadDocuments();

                if (PdfDocuments != null && PdfDocuments.Any())
                {
                    string[] registros = System.IO.File.ReadAllLines(txtAdditionalInfoCSVFile.Text);

                    string csvSeparator = CheckCSVSeparator(registros);

                    if (registros != null && registros.Any())
                    {
                        Dictionary<string, PdfDocument> newList = new Dictionary<string, PdfDocument>();

                        foreach (KeyValuePair<string, PdfDocument> item in PdfDocuments)
                        {
                            string[] tmp = item.Key.Split("\\", StringSplitOptions.RemoveEmptyEntries);

                            if (tmp != null && tmp.Any())
                            {
                                string arquivo = tmp.Last();
                                arquivo = arquivo.Replace(".pdf", "", StringComparison.InvariantCultureIgnoreCase);

                                if (registros.Any(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1))
                                {
                                    string[] linha = registros.First(w => w.IndexOf(arquivo, StringComparison.InvariantCultureIgnoreCase) > -1).Split(csvSeparator, StringSplitOptions.RemoveEmptyEntries);
                                    if (linha != null && linha.Any())
                                    {
                                        string registro = linha[3];
                                        string nome = linha[1];

                                        newList.Add($"{registro} - {nome}", item.Value);
                                    }
                                }
                            }
                        }

                        PdfDocuments = newList;
                    }
                }
            }
        }

        private void ExecuteSaveFiles()
        {
            if (PdfDocuments == null || !PdfDocuments.Any())
            {
                if (MessageBox.Show("Nenhum documento localizado na pasta de origem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    PdfDocuments = null;
                }
            }
            else
            {
                foreach (KeyValuePair<string, PdfDocument> item in PdfDocuments)
                {
                    item.Value.Save($"{txtTargetFolder.Text}\\{item.Key}");
                }

                if (MessageBox.Show("Processamento finalizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PdfDocuments = null;
                }
            }
        }

        private void LoadDocuments()
        {
            if (PdfDocuments == null || !PdfDocuments.Any())
            {
                string[] sourceFiles = System.IO.Directory.GetFiles(txtSourceFolder.Text, "*.pdf");

                if (sourceFiles != null && sourceFiles.Any())
                {
                    foreach (string item in sourceFiles)
                    {
                        string fileName = item.Replace($"{txtSourceFolder.Text}\\", "", StringComparison.InvariantCultureIgnoreCase).Trim();
                        PdfDocuments.Add(fileName, PdfReader.Open(item, PdfDocumentOpenMode.Modify));
                    }
                }
            }
        }

        private static string CheckCSVSeparator(string[] lines)
        {
            if (lines != null)
            {
                int first = 0;
                int second = 0;

                foreach (string item in lines)
                {
                    first += item.Count(w => w == ';');
                    second += item.Count(w => w == ',');
                }

                if (second > first)
                {
                    return ",";
                }
            }

            return ";";
        }
    }
}
