using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environtment
{
    public partial class FormHalamanUtama : Form
    {
        public FormHalamanUtama()
        {
            InitializeComponent();
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMahasiswa fm = new FormDataMahasiswa();
            fm.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fm = new FormDataStatusMahasiswa();
            fm.Show();  
            this.Hide();
        }
    }
}
