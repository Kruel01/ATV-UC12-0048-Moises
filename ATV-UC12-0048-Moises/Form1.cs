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
                           Cliente cliente = new Cliente(Convert.ToInt32(TxtCPF.Text));
                            cliente.ClienteNome = TxtNome.Text;
                           
                            
                            cliente.ClienteSalario = Convert.ToDecimal(TxtSalario.Text);

                           
                            MessageBox.Show(cliente.VerificarSeCorrentistaMaior(Convert.ToDateTime(DTNascimento.Text)).ToString());


                        }
                    
                    }
                }
           
            }

        }
    }
}