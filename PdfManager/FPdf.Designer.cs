namespace PdfManager
{
    partial class FPdf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbProtectFile = new System.Windows.Forms.GroupBox();
            this.pnRenameFiles = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtRenameFileCSVFile = new System.Windows.Forms.TextBox();
            this.lblRenameFile = new System.Windows.Forms.Label();
            this.cbRenameFile = new System.Windows.Forms.CheckBox();
            this.gbProtectedFile = new System.Windows.Forms.GroupBox();
            this.pnProtectFile = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtProtectFileCSVFile = new System.Windows.Forms.TextBox();
            this.lblProtectFile = new System.Windows.Forms.Label();
            this.cbProtectFile = new System.Windows.Forms.CheckBox();
            this.gbApplyAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.pnAdditionalInfo = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAdditionalInfoCSVFile = new System.Windows.Forms.TextBox();
            this.lbCSVFile = new System.Windows.Forms.Label();
            this.cbApplyAdditionalInfo = new System.Windows.Forms.CheckBox();
            this.gbApplyBgImage = new System.Windows.Forms.GroupBox();
            this.pnApplyBgImage = new System.Windows.Forms.Panel();
            this.panel01 = new System.Windows.Forms.Panel();
            this.txtBgImage = new System.Windows.Forms.TextBox();
            this.lbImageFile = new System.Windows.Forms.Label();
            this.cbApplyBgImage = new System.Windows.Forms.CheckBox();
            this.gbMergeFiles = new System.Windows.Forms.GroupBox();
            this.pnMergeFiles = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMergeSecondFile = new System.Windows.Forms.TextBox();
            this.lbSecondFileName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMergeFirstFile = new System.Windows.Forms.TextBox();
            this.lbFirstFileName = new System.Windows.Forms.Label();
            this.cbMergeFiles = new System.Windows.Forms.CheckBox();
            this.gbMergeFile = new System.Windows.Forms.GroupBox();
            this.pnFolderSelect = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.lbTargetFolder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.lbSourceFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbProtectFile.SuspendLayout();
            this.pnRenameFiles.SuspendLayout();
            this.panel9.SuspendLayout();
            this.gbProtectedFile.SuspendLayout();
            this.pnProtectFile.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbApplyAdditionalInfo.SuspendLayout();
            this.pnAdditionalInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gbApplyBgImage.SuspendLayout();
            this.pnApplyBgImage.SuspendLayout();
            this.panel01.SuspendLayout();
            this.gbMergeFiles.SuspendLayout();
            this.pnMergeFiles.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbMergeFile.SuspendLayout();
            this.pnFolderSelect.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(641, 50);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(8, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(483, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Execute_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbProtectFile);
            this.panel2.Controls.Add(this.gbProtectedFile);
            this.panel2.Controls.Add(this.gbApplyAdditionalInfo);
            this.panel2.Controls.Add(this.gbApplyBgImage);
            this.panel2.Controls.Add(this.gbMergeFiles);
            this.panel2.Controls.Add(this.gbMergeFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(641, 517);
            this.panel2.TabIndex = 0;
            // 
            // gbProtectFile
            // 
            this.gbProtectFile.Controls.Add(this.pnRenameFiles);
            this.gbProtectFile.Controls.Add(this.cbRenameFile);
            this.gbProtectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProtectFile.Location = new System.Drawing.Point(8, 424);
            this.gbProtectFile.Name = "gbProtectFile";
            this.gbProtectFile.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbProtectFile.Size = new System.Drawing.Size(625, 88);
            this.gbProtectFile.TabIndex = 0;
            this.gbProtectFile.TabStop = false;
            this.gbProtectFile.Text = "06) Renomear arquivos";
            // 
            // pnRenameFiles
            // 
            this.pnRenameFiles.Controls.Add(this.panel9);
            this.pnRenameFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRenameFiles.Enabled = false;
            this.pnRenameFiles.Location = new System.Drawing.Point(8, 42);
            this.pnRenameFiles.Name = "pnRenameFiles";
            this.pnRenameFiles.Size = new System.Drawing.Size(609, 38);
            this.pnRenameFiles.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtRenameFileCSVFile);
            this.panel9.Controls.Add(this.lblRenameFile);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(609, 38);
            this.panel9.TabIndex = 0;
            // 
            // txtRenameFileCSVFile
            // 
            this.txtRenameFileCSVFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRenameFileCSVFile.Location = new System.Drawing.Point(0, 15);
            this.txtRenameFileCSVFile.Name = "txtRenameFileCSVFile";
            this.txtRenameFileCSVFile.PlaceholderText = "<clique para escolher um csv>";
            this.txtRenameFileCSVFile.ReadOnly = true;
            this.txtRenameFileCSVFile.Size = new System.Drawing.Size(609, 23);
            this.txtRenameFileCSVFile.TabIndex = 1;
            this.txtRenameFileCSVFile.TabStop = false;
            this.txtRenameFileCSVFile.Enter += new System.EventHandler(this.FileSelect_Enter);
            // 
            // lblRenameFile
            // 
            this.lblRenameFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRenameFile.Location = new System.Drawing.Point(0, 0);
            this.lblRenameFile.Name = "lblRenameFile";
            this.lblRenameFile.Size = new System.Drawing.Size(609, 15);
            this.lblRenameFile.TabIndex = 0;
            this.lblRenameFile.Text = "Arquivo CSV";
            // 
            // cbRenameFile
            // 
            this.cbRenameFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRenameFile.Location = new System.Drawing.Point(8, 18);
            this.cbRenameFile.Name = "cbRenameFile";
            this.cbRenameFile.Size = new System.Drawing.Size(609, 24);
            this.cbRenameFile.TabIndex = 0;
            this.cbRenameFile.Text = "Executar?";
            this.cbRenameFile.UseVisualStyleBackColor = true;
            this.cbRenameFile.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gbProtectedFile
            // 
            this.gbProtectedFile.Controls.Add(this.pnProtectFile);
            this.gbProtectedFile.Controls.Add(this.cbProtectFile);
            this.gbProtectedFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProtectedFile.Location = new System.Drawing.Point(8, 336);
            this.gbProtectedFile.Name = "gbProtectedFile";
            this.gbProtectedFile.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbProtectedFile.Size = new System.Drawing.Size(625, 88);
            this.gbProtectedFile.TabIndex = 0;
            this.gbProtectedFile.TabStop = false;
            this.gbProtectedFile.Text = "05) Proteger documento com senha";
            // 
            // pnProtectFile
            // 
            this.pnProtectFile.Controls.Add(this.panel8);
            this.pnProtectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProtectFile.Enabled = false;
            this.pnProtectFile.Location = new System.Drawing.Point(8, 42);
            this.pnProtectFile.Name = "pnProtectFile";
            this.pnProtectFile.Size = new System.Drawing.Size(609, 38);
            this.pnProtectFile.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtProtectFileCSVFile);
            this.panel8.Controls.Add(this.lblProtectFile);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(609, 38);
            this.panel8.TabIndex = 0;
            // 
            // txtProtectFileCSVFile
            // 
            this.txtProtectFileCSVFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProtectFileCSVFile.Location = new System.Drawing.Point(0, 15);
            this.txtProtectFileCSVFile.Name = "txtProtectFileCSVFile";
            this.txtProtectFileCSVFile.PlaceholderText = "<clique para escolher um csv>";
            this.txtProtectFileCSVFile.ReadOnly = true;
            this.txtProtectFileCSVFile.Size = new System.Drawing.Size(609, 23);
            this.txtProtectFileCSVFile.TabIndex = 1;
            this.txtProtectFileCSVFile.TabStop = false;
            this.txtProtectFileCSVFile.Enter += new System.EventHandler(this.FileSelect_Enter);
            // 
            // lblProtectFile
            // 
            this.lblProtectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProtectFile.Location = new System.Drawing.Point(0, 0);
            this.lblProtectFile.Name = "lblProtectFile";
            this.lblProtectFile.Size = new System.Drawing.Size(609, 15);
            this.lblProtectFile.TabIndex = 0;
            this.lblProtectFile.Text = "Arquivo CSV";
            // 
            // cbProtectFile
            // 
            this.cbProtectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbProtectFile.Location = new System.Drawing.Point(8, 18);
            this.cbProtectFile.Name = "cbProtectFile";
            this.cbProtectFile.Size = new System.Drawing.Size(609, 24);
            this.cbProtectFile.TabIndex = 0;
            this.cbProtectFile.Text = "Executar?";
            this.cbProtectFile.UseVisualStyleBackColor = true;
            this.cbProtectFile.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gbApplyAdditionalInfo
            // 
            this.gbApplyAdditionalInfo.Controls.Add(this.pnAdditionalInfo);
            this.gbApplyAdditionalInfo.Controls.Add(this.cbApplyAdditionalInfo);
            this.gbApplyAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbApplyAdditionalInfo.Location = new System.Drawing.Point(8, 248);
            this.gbApplyAdditionalInfo.Name = "gbApplyAdditionalInfo";
            this.gbApplyAdditionalInfo.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbApplyAdditionalInfo.Size = new System.Drawing.Size(625, 88);
            this.gbApplyAdditionalInfo.TabIndex = 0;
            this.gbApplyAdditionalInfo.TabStop = false;
            this.gbApplyAdditionalInfo.Text = "04) Aplicar informações adicionais";
            // 
            // pnAdditionalInfo
            // 
            this.pnAdditionalInfo.Controls.Add(this.panel7);
            this.pnAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdditionalInfo.Enabled = false;
            this.pnAdditionalInfo.Location = new System.Drawing.Point(8, 42);
            this.pnAdditionalInfo.Name = "pnAdditionalInfo";
            this.pnAdditionalInfo.Size = new System.Drawing.Size(609, 38);
            this.pnAdditionalInfo.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtAdditionalInfoCSVFile);
            this.panel7.Controls.Add(this.lbCSVFile);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(609, 38);
            this.panel7.TabIndex = 0;
            // 
            // txtAdditionalInfoCSVFile
            // 
            this.txtAdditionalInfoCSVFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAdditionalInfoCSVFile.Location = new System.Drawing.Point(0, 15);
            this.txtAdditionalInfoCSVFile.Name = "txtAdditionalInfoCSVFile";
            this.txtAdditionalInfoCSVFile.PlaceholderText = "<clique para escolher um csv>";
            this.txtAdditionalInfoCSVFile.ReadOnly = true;
            this.txtAdditionalInfoCSVFile.Size = new System.Drawing.Size(609, 23);
            this.txtAdditionalInfoCSVFile.TabIndex = 1;
            this.txtAdditionalInfoCSVFile.TabStop = false;
            this.txtAdditionalInfoCSVFile.Enter += new System.EventHandler(this.FileSelect_Enter);
            // 
            // lbCSVFile
            // 
            this.lbCSVFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCSVFile.Location = new System.Drawing.Point(0, 0);
            this.lbCSVFile.Name = "lbCSVFile";
            this.lbCSVFile.Size = new System.Drawing.Size(609, 15);
            this.lbCSVFile.TabIndex = 0;
            this.lbCSVFile.Text = "Arquivo CSV";
            // 
            // cbApplyAdditionalInfo
            // 
            this.cbApplyAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbApplyAdditionalInfo.Location = new System.Drawing.Point(8, 18);
            this.cbApplyAdditionalInfo.Name = "cbApplyAdditionalInfo";
            this.cbApplyAdditionalInfo.Size = new System.Drawing.Size(609, 24);
            this.cbApplyAdditionalInfo.TabIndex = 0;
            this.cbApplyAdditionalInfo.Text = "Executar?";
            this.cbApplyAdditionalInfo.UseVisualStyleBackColor = true;
            this.cbApplyAdditionalInfo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gbApplyBgImage
            // 
            this.gbApplyBgImage.Controls.Add(this.pnApplyBgImage);
            this.gbApplyBgImage.Controls.Add(this.cbApplyBgImage);
            this.gbApplyBgImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbApplyBgImage.Location = new System.Drawing.Point(8, 160);
            this.gbApplyBgImage.Name = "gbApplyBgImage";
            this.gbApplyBgImage.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbApplyBgImage.Size = new System.Drawing.Size(625, 88);
            this.gbApplyBgImage.TabIndex = 0;
            this.gbApplyBgImage.TabStop = false;
            this.gbApplyBgImage.Text = "03) Aplicar imagem de fundo na primeira página";
            // 
            // pnApplyBgImage
            // 
            this.pnApplyBgImage.Controls.Add(this.panel01);
            this.pnApplyBgImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnApplyBgImage.Enabled = false;
            this.pnApplyBgImage.Location = new System.Drawing.Point(8, 42);
            this.pnApplyBgImage.Name = "pnApplyBgImage";
            this.pnApplyBgImage.Size = new System.Drawing.Size(609, 38);
            this.pnApplyBgImage.TabIndex = 1;
            // 
            // panel01
            // 
            this.panel01.Controls.Add(this.txtBgImage);
            this.panel01.Controls.Add(this.lbImageFile);
            this.panel01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel01.Location = new System.Drawing.Point(0, 0);
            this.panel01.Name = "panel01";
            this.panel01.Size = new System.Drawing.Size(609, 38);
            this.panel01.TabIndex = 0;
            // 
            // txtBgImage
            // 
            this.txtBgImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBgImage.Location = new System.Drawing.Point(0, 15);
            this.txtBgImage.Name = "txtBgImage";
            this.txtBgImage.PlaceholderText = "<clique para escolher uma imagem>";
            this.txtBgImage.ReadOnly = true;
            this.txtBgImage.Size = new System.Drawing.Size(609, 23);
            this.txtBgImage.TabIndex = 1;
            this.txtBgImage.TabStop = false;
            this.txtBgImage.Enter += new System.EventHandler(this.FileSelect_Enter);
            // 
            // lbImageFile
            // 
            this.lbImageFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbImageFile.Location = new System.Drawing.Point(0, 0);
            this.lbImageFile.Name = "lbImageFile";
            this.lbImageFile.Size = new System.Drawing.Size(609, 15);
            this.lbImageFile.TabIndex = 0;
            this.lbImageFile.Text = "Imagem de fundo";
            // 
            // cbApplyBgImage
            // 
            this.cbApplyBgImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbApplyBgImage.Location = new System.Drawing.Point(8, 18);
            this.cbApplyBgImage.Name = "cbApplyBgImage";
            this.cbApplyBgImage.Size = new System.Drawing.Size(609, 24);
            this.cbApplyBgImage.TabIndex = 0;
            this.cbApplyBgImage.Text = "Executar?";
            this.cbApplyBgImage.UseVisualStyleBackColor = true;
            this.cbApplyBgImage.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gbMergeFiles
            // 
            this.gbMergeFiles.Controls.Add(this.pnMergeFiles);
            this.gbMergeFiles.Controls.Add(this.cbMergeFiles);
            this.gbMergeFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMergeFiles.Location = new System.Drawing.Point(8, 72);
            this.gbMergeFiles.Name = "gbMergeFiles";
            this.gbMergeFiles.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbMergeFiles.Size = new System.Drawing.Size(625, 88);
            this.gbMergeFiles.TabIndex = 0;
            this.gbMergeFiles.TabStop = false;
            this.gbMergeFiles.Text = "02) Mesclar frente e verso";
            // 
            // pnMergeFiles
            // 
            this.pnMergeFiles.Controls.Add(this.panel5);
            this.pnMergeFiles.Controls.Add(this.panel6);
            this.pnMergeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMergeFiles.Enabled = false;
            this.pnMergeFiles.Location = new System.Drawing.Point(8, 42);
            this.pnMergeFiles.Name = "pnMergeFiles";
            this.pnMergeFiles.Size = new System.Drawing.Size(609, 38);
            this.pnMergeFiles.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMergeSecondFile);
            this.panel5.Controls.Add(this.lbSecondFileName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(309, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 38);
            this.panel5.TabIndex = 1;
            // 
            // txtMergeSecondFile
            // 
            this.txtMergeSecondFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMergeSecondFile.Location = new System.Drawing.Point(0, 15);
            this.txtMergeSecondFile.Name = "txtMergeSecondFile";
            this.txtMergeSecondFile.Size = new System.Drawing.Size(300, 23);
            this.txtMergeSecondFile.TabIndex = 2;
            this.txtMergeSecondFile.Text = "V.pdf";
            // 
            // lbSecondFileName
            // 
            this.lbSecondFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSecondFileName.Location = new System.Drawing.Point(0, 0);
            this.lbSecondFileName.Name = "lbSecondFileName";
            this.lbSecondFileName.Size = new System.Drawing.Size(300, 15);
            this.lbSecondFileName.TabIndex = 0;
            this.lbSecondFileName.Text = "Nome final do arquivo de verso";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMergeFirstFile);
            this.panel6.Controls.Add(this.lbFirstFileName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 38);
            this.panel6.TabIndex = 0;
            // 
            // txtMergeFirstFile
            // 
            this.txtMergeFirstFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMergeFirstFile.Location = new System.Drawing.Point(0, 15);
            this.txtMergeFirstFile.Name = "txtMergeFirstFile";
            this.txtMergeFirstFile.Size = new System.Drawing.Size(300, 23);
            this.txtMergeFirstFile.TabIndex = 2;
            this.txtMergeFirstFile.Text = "F.pdf";
            // 
            // lbFirstFileName
            // 
            this.lbFirstFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFirstFileName.Location = new System.Drawing.Point(0, 0);
            this.lbFirstFileName.Name = "lbFirstFileName";
            this.lbFirstFileName.Size = new System.Drawing.Size(300, 15);
            this.lbFirstFileName.TabIndex = 0;
            this.lbFirstFileName.Text = "Nome final do arquivo de frente";
            // 
            // cbMergeFiles
            // 
            this.cbMergeFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMergeFiles.Location = new System.Drawing.Point(8, 18);
            this.cbMergeFiles.Name = "cbMergeFiles";
            this.cbMergeFiles.Size = new System.Drawing.Size(609, 24);
            this.cbMergeFiles.TabIndex = 0;
            this.cbMergeFiles.Text = "Executar?";
            this.cbMergeFiles.UseVisualStyleBackColor = true;
            this.cbMergeFiles.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gbMergeFile
            // 
            this.gbMergeFile.Controls.Add(this.pnFolderSelect);
            this.gbMergeFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMergeFile.Location = new System.Drawing.Point(8, 8);
            this.gbMergeFile.Name = "gbMergeFile";
            this.gbMergeFile.Padding = new System.Windows.Forms.Padding(8, 2, 8, 8);
            this.gbMergeFile.Size = new System.Drawing.Size(625, 64);
            this.gbMergeFile.TabIndex = 0;
            this.gbMergeFile.TabStop = false;
            this.gbMergeFile.Text = "01) Selecionar pastas";
            // 
            // pnFolderSelect
            // 
            this.pnFolderSelect.Controls.Add(this.panel4);
            this.pnFolderSelect.Controls.Add(this.panel3);
            this.pnFolderSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFolderSelect.Location = new System.Drawing.Point(8, 18);
            this.pnFolderSelect.Name = "pnFolderSelect";
            this.pnFolderSelect.Size = new System.Drawing.Size(609, 38);
            this.pnFolderSelect.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTargetFolder);
            this.panel4.Controls.Add(this.lbTargetFolder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(309, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 38);
            this.panel4.TabIndex = 1;
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTargetFolder.Location = new System.Drawing.Point(0, 15);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.PlaceholderText = "<clique para escolher uma pasta>";
            this.txtTargetFolder.ReadOnly = true;
            this.txtTargetFolder.Size = new System.Drawing.Size(300, 23);
            this.txtTargetFolder.TabIndex = 1;
            this.txtTargetFolder.TabStop = false;
            this.txtTargetFolder.Enter += new System.EventHandler(this.FolderSelect_Enter);
            // 
            // lbTargetFolder
            // 
            this.lbTargetFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTargetFolder.Location = new System.Drawing.Point(0, 0);
            this.lbTargetFolder.Name = "lbTargetFolder";
            this.lbTargetFolder.Size = new System.Drawing.Size(300, 15);
            this.lbTargetFolder.TabIndex = 0;
            this.lbTargetFolder.Text = "Pasta de destino";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSourceFolder);
            this.panel3.Controls.Add(this.lbSourceFolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 38);
            this.panel3.TabIndex = 0;
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSourceFolder.Location = new System.Drawing.Point(0, 15);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.PlaceholderText = "<clique para escolher uma pasta>";
            this.txtSourceFolder.ReadOnly = true;
            this.txtSourceFolder.Size = new System.Drawing.Size(300, 23);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.TabStop = false;
            this.txtSourceFolder.Enter += new System.EventHandler(this.FolderSelect_Enter);
            // 
            // lbSourceFolder
            // 
            this.lbSourceFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSourceFolder.Location = new System.Drawing.Point(0, 0);
            this.lbSourceFolder.Name = "lbSourceFolder";
            this.lbSourceFolder.Size = new System.Drawing.Size(300, 15);
            this.lbSourceFolder.TabIndex = 0;
            this.lbSourceFolder.Text = "Pasta de origem";
            // 
            // FPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FPdf";
            this.Text = "Pdf";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbProtectFile.ResumeLayout(false);
            this.pnRenameFiles.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.gbProtectedFile.ResumeLayout(false);
            this.pnProtectFile.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.gbApplyAdditionalInfo.ResumeLayout(false);
            this.pnAdditionalInfo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.gbApplyBgImage.ResumeLayout(false);
            this.pnApplyBgImage.ResumeLayout(false);
            this.panel01.ResumeLayout(false);
            this.panel01.PerformLayout();
            this.gbMergeFiles.ResumeLayout(false);
            this.pnMergeFiles.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gbMergeFile.ResumeLayout(false);
            this.pnFolderSelect.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbMerge;
        private System.Windows.Forms.GroupBox gbMergeFiles;
        private System.Windows.Forms.GroupBox gbApplyBgImage;
        private System.Windows.Forms.GroupBox gbProtectedFile;
        private System.Windows.Forms.GroupBox gbApplyAdditionalInfo;
        private System.Windows.Forms.GroupBox gbProtectFile;
        private System.Windows.Forms.Panel pnFolderSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnRenameFiles;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox cbRenameFile;
        private System.Windows.Forms.Panel pnProtectFile;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox cbProtectFile;
        private System.Windows.Forms.Panel pnAdditionalInfo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbApplyAdditionalInfo;
        private System.Windows.Forms.Panel pnApplyBgImage;
        private System.Windows.Forms.Panel panel01;
        private System.Windows.Forms.CheckBox cbApplyBgImage;
        private System.Windows.Forms.Panel pnMergeFiles;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbMergeFiles;
        private System.Windows.Forms.CheckBox s;
        private System.Windows.Forms.GroupBox gbMergeFile;
        private System.Windows.Forms.Label lbTargetFolder;
        private System.Windows.Forms.Label lbSourceFolder;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label lbSecondFileName;
        private System.Windows.Forms.Label lbFirstFileName;
        private System.Windows.Forms.TextBox txtMergeFirstFile;
        private System.Windows.Forms.TextBox txtMergeSecondFile;
        private System.Windows.Forms.Label lbImageFile;
        private System.Windows.Forms.TextBox txtBgImage;
        private System.Windows.Forms.Label lbCSVFile;
        private System.Windows.Forms.TextBox txtAdditionalInfoCSVFile;
        private System.Windows.Forms.TextBox txtRenameFileCSVFile;
        private System.Windows.Forms.Label lblRenameFile;
        private System.Windows.Forms.TextBox txtProtectFileCSVFile;
        private System.Windows.Forms.Label lblProtectFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}