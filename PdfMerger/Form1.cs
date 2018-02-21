using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfMerger
{
    public partial class Form1 : Form
    {
        private List<string> pdfFilePaths;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMergeAndSave.Enabled = false;

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF files(*.pdf)| *.pdf";
            openFileDialog.Title = "Choose pdf files";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfFilePaths = new List<string>();
                pdfFilePaths.AddRange(openFileDialog.FileNames);
                btnMergeAndSave.Enabled = pdfFilePaths.Count > 1;
            }
        }

        private void btnMergeAndSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files(*.pdf)| *.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MergeFilesInPathListThenSave(saveFileDialog.FileName);
                MessageBox.Show("Merging files process has been completed.");
                pdfFilePaths.Clear();
                btnMergeAndSave.Enabled = pdfFilePaths.Count > 1;
            }

        }

        private void MergeFilesInPathListThenSave(string path)
        {
            using (PdfDocument mergedPdf = new PdfDocument())
            {
                foreach (var filename in pdfFilePaths)
                {
                    using (PdfDocument pdf = PdfReader.Open(filename, PdfDocumentOpenMode.Import))
                    {
                        CopyPages(pdf, mergedPdf);
                    }
                }
                mergedPdf.Save(path);
            }
        }

        private void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }
    }
}
