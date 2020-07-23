namespace PdfManager
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using FPdf form = new FPdf();
            Application.Run(form);
        }
    }
}
// TODO: traduzir para portugues
// TODO: alterar nome e icone para IFSC
// TODO: alterar copyright para contribuição para IFSC