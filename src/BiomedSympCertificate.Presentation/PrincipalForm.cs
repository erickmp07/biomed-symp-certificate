using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BiomedSympCertificate.Application.ViewModels;

namespace BiomedSympCertificate.Presentation
{
    public partial class PrincipalForm : Form, IPrincipalForm
    {
        public event EventHandler OnCreateReportClick;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        public void Handles()
        {
            btnCadeLista.Click += OnCreateReportClick;
        }

        public void SetCursorToWait()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        public void SetCursorToDefault()
        {
            Cursor.Current = Cursors.Default;
        }

        public void ShowSuccessMessage(
            string text)
        {
            MessageBox.Show(
                this,
                text,
                @"Simpósio Biomed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowWarningMessage(
            string text)
        {
            MessageBox.Show(
                this,
                text,
                @"Simpósio Biomed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        

        public BiomedViewModel SelectSpreadsheetsFiles()
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = @"Spreadsheet Import",
                Filter = @"Spreadsheets files (*.xlsx; *.xls)|*.xlsx; *.xls",
                Multiselect = true
            };

            var dialogResult = openFileDialog.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return null;
            }

            var filesPaths = openFileDialog.FileNames.ToList();

            var resultPath = Path.GetDirectoryName(openFileDialog.FileName);

            return new BiomedViewModel(
                filesPaths,
                resultPath,
                Convert.ToInt32(nudQuantidadeMinimaPalestras.Value));
        }
    }
}
