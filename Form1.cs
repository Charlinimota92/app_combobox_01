using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_combobox_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbo_Asignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Asignatura.Text = cbo_Asignatura.Text;
            lbl_Indice.Text = cbo_Asignatura.SelectedIndex.ToString();
            lbl_Asignatura.ForeColor = Color.Blue;
            lbl_Indice.ForeColor = Color.Red; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Asignatura_Click(object sender, EventArgs e)
        {

        }
    }
}
