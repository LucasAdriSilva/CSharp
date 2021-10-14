using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }
        private void Inicializar()
        {
            dt = Livro.GetLivros(true);
            dgvLivros.DataSource = dt;
            ConfigurarGradeLivros();
        }

        private void ConfigurarGradeLivros()
        {
            dgvLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvLivros.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvLivros.RowHeadersWidth = 25;

            dgvLivros.Columns["id"].HeaderText = "ID";
            dgvLivros.Columns["id"].Visible = false;

            dgvLivros.Columns["Isbn"].HeaderText = "ISBN";
            dgvLivros.Columns["Isbn"].Width = 130;
            dgvLivros.Columns["Isbn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["Isbn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLivros.Columns["titulo"].HeaderText = "Titulo Livro";
            dgvLivros.Columns["titulo"].Width = 450;
            dgvLivros.Columns["titulo"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvLivros.Columns["autores"].HeaderText = "Autores Livros";
            dgvLivros.Columns["autores"].Width = 500;
            dgvLivros.Columns["autores"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);


            dgvLivros.Columns["unitario"].HeaderText = "Unitario";            
            dgvLivros.Columns["unitario"].Width = 90;
            dgvLivros.Columns["unitario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLivros.Columns["unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLivros.Columns["unitario"].DefaultCellStyle.Padding = new Padding(0, 0, 12, 0);
            dgvLivros.Columns["unitario"].DefaultCellStyle.Format = "N2";

            dgvLivros.Columns["saldo_atual"].HeaderText = "Saldo";
            dgvLivros.Columns["saldo_atual"].Width = 70;
            dgvLivros.Columns["saldo_atual"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["saldo_atual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["saldo_atual"].DefaultCellStyle.Format = "N0";

            dgvLivros.Sort(dgvLivros.Columns["titulo"], ListSortDirection.Ascending);


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
