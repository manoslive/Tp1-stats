using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace tp1_echantillonnage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_ChoisirFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChoixFichier = new OpenFileDialog();
            if(ChoixFichier.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Open(ChoixFichier.FileName);

            }
        }
    }
}
