using System;
using System.Windows.Forms;
using CEPFinder.CorreioService;
using CEPFinder.Entities;
using System.ServiceModel;

namespace CEPFinder
{
    public partial class ConsultaCEP : Form
    {
        Endereco resultado;
        AtendeClienteClient correios = new AtendeClienteClient();

        public ConsultaCEP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void consultaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var consulta = correios.consultaCEP(txtCep1.Text.Replace("-", ""));
                resultado = new Endereco { Rua = consulta.end, Bairro = consulta.bairro, Cidade = consulta.cidade, Complemento = consulta.complemento2, EstadoUF = consulta.uf };



                txtEnd.Text = resultado.Rua;
                txtComp.Text = resultado.Complemento;
                txtCidade.Text = resultado.Cidade;
                txtBairro.Text = resultado.Bairro;
                txtUF.Text = resultado.EstadoUF;

            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

