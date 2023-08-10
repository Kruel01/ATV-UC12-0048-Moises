using ATV_UC12_0048_Moises.Classes;
using System.Reflection.Metadata.Ecma335;


namespace ATV_UC12_0048_Moises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            if(int.TryParse(TxtCPF.Text, out int n) == false)
            {
                TxtCPF.Clear();

            }
        }

        private void DTNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtSalario.Text, out double n) == false)
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
                                  
                    if(TxtCPF.Text == "") 
                    {
                        MessageBox.Show("Insira um CPF");
                    }
                    else 
                    {
                    if(TxtSalario.Text == "") 
                        {
                            MessageBox.Show("Insira um Salario");


                        }
                        else 
                        {
                            Cliente Clientes = new Cliente(Convert.ToInt32(TxtID.Text), TxtNome.Text, Convert.ToInt32(TxtCPF.Text), Convert.ToDateTime(DTNascimento.Text), Convert.ToDouble(TxtSalario.Text));
                            
                        }
                    
                    }
                }
           
            }

        }
    }
}