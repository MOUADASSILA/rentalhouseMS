using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wach nta zamal?",//Mesaj içerigi
            "taakid ",
            //Mesaj Baslig1
            MessageBoxButtons.YesNoCancel,
            //Mesaj Butonlari
            MessageBoxIcon.Question,
            //Mesaj Iconu
            MessageBoxDefaultButton.Button3,
            //Default Secili Buton
            MessageBoxOptions.DefaultDesktopOnly
            //PencereYerlesimSeçenegi
            );
        }
    }
}
