using ATV_UC12_0048_Moises.Classes;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text.RegularExpressions;

namespace ATV_UC12_0048_Moises
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        Cliente cliente2;
        private string previousText = null;

        public Form1()
        {
            InitializeComponent();
            TxtCPF.TextChanged += new EventHandler(TxtCPF_TextChanged);
            

            if (BtnCadastrar.TabIndex == 5)
            {

                TxtNome.Focus();

            }
            TxtID.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(TxtID.Text, out int n) == false)
            {

                TxtID.Clear();


            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(TxtCPF.Text, out int n) == false)
            {
                TxtCPF.Text = previousText;
                TxtCPF.SelectionStart = TxtCPF.Text.Length;


            }
            else
            {

                previousText = TxtCPF.Text;
            }

        }

        private void DTNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(TxtSalario.Text, out decimal n) == false)
            {
                TxtSalario.Clear();



            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {


            if (TxtNome.Text == "" && TxtCPF.Text == "" && TxtSalario.Text == "")

            {
                MessageBox.Show("Insira Valor no nome, CPF e Salario");

            }
            else
            {
                if (TxtNome.Text == "")
                {
                    MessageBox.Show("Insira um Nome");

                }
                else
                {

                    if (TxtCPF.Text == "")
                    {
                        MessageBox.Show("Insira um CPF");
                    }
                    else
                    {
                        if (TxtSalario.Text == "")
                        {
                            MessageBox.Show("Insira um Salario");


                        }
                        else
                        {


                            if (Cliente.Equals(cliente, null))
                            {
                                cliente = new Cliente(TxtNome.Text, TxtCPF.Text, Convert.ToDateTime(DTNascimento.Text), Convert.ToDecimal(TxtSalario.Text.ToString()));
                                Cliente.GenerateId();
                                TxtID.Text = cliente.ClientId.ToString();
                                MessageBox.Show(cliente.MostrarCliente().ToString() + Cliente.GenerateId());


                            }
                            else
                            {
                                cliente2 = new Cliente(TxtNome.Text, TxtCPF.Text, Convert.ToDateTime(DTNascimento.Text), Convert.ToDecimal(TxtSalario.Text.ToString()));
                                Cliente.GenerateId();
                                TxtID.Text = cliente2.ClientId.ToString();
                                MessageBox.Show(cliente2.MostrarCliente().ToString() + Cliente.GenerateId());
                            }











                        }

                    }
                }

            }

        }

        private void BTNCorrentista2_Click(object sender, EventArgs e)
        {

            if (Cliente.Equals(cliente, null))
            {
                MessageBox.Show("arruma");

            }
            else
            {
                MessageBox.Show(cliente.MostrarCliente() + Cliente.GenerateId());

            }







        }

        private void BTNCorrentista1_Click(object sender, EventArgs e)
        {

            if (cliente2 == null)

            {
                MessageBox.Show("Arruma ae!");


            }
            else
            {
                MessageBox.Show(cliente2.MostrarCliente() + Cliente.GenerateId());
            }


        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if(TxtCPF.Text.Length == 1 && e.KeyChar == 8) 
            {

                previousText = "";


            }
            else if ((TxtCPF.Text.Length == 1 && e.KeyChar == 127))
            {
                TxtCPF.Clear();
            }
            
            
        }
    }
}