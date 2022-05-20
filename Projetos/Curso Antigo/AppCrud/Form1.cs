using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Marca_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFabricacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textId_Leave(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            BuscarVeiculoId(id);
        }

        private void BuscarVeiculoId(int id)
        {
            try
            {
                var veiculo = new Veiculo();
                veiculo.GetVeiculo(id);

                if (veiculo != null)
                {
                    txtId.Text = veiculo.Id.ToString();
                    txtMarca.Text = veiculo.Nome;
                    txtModelo.Text = veiculo.Modelo;
                    txtAno.Text = veiculo.Ano.ToString();
                    txtFabrica.Text = veiculo.Fabricacao.ToString();
                    txtCor.Text = veiculo.Cor;
                    txtValor.Text = veiculo.Valor.ToString();
                }
                else {
                    MessageBox.Show("Veiculo não encontrado");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
