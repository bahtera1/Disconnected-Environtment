using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environtment
{
    public partial class FormDataProdi : Form
    {
        private string stringconnection = "data source=LAPTOP-NAUFALAS\\NAUFALAS;" + "database=ProdiTI1;user ID=sa;password=123";
        private SqlConnection koneksi;

        public FormDataProdi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringconnection);
            refreshform();
        }

        private void FormDataProdi_Load(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            nn.Text = "";
            nn.Enabled = true;
            nmp.Text = "";
            nmp.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idProdi = nn.Text;
            string namaProdi = nmp.Text;

            if (idProdi == "" || namaProdi == "")
            {
                MessageBox.Show("Masukkan Keduanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (id_prodi, nama_prodi) VALUES (@id_prodi, @nama_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_prodi", idProdi));
                cmd.Parameters.Add(new SqlParameter("@nama_prodi", namaProdi));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void FormDataProdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHalamanUtama hu = new FormHalamanUtama();
            hu.Show();
            this.Hide();
        }


        private void nmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_prodi, nama_prodi From dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
