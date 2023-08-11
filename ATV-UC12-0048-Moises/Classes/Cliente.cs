using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ATV_UC12_0048_Moises.Classes
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string? ClienteNome { get; set; }
        public int CPF { get; set; }
        public DateTime ClienteDataNascimento { get; set; }
        public decimal ClienteSalario { get; set; }
        private static int IdClientes;

        public Cliente() 
        {
            
        }

        public Cliente(int CPF)
        {
            this.CPF = CPF;
            this.ClientId = ClientId;
            this.ClienteSalario = ClienteSalario;
            this.ClienteDataNascimento = ClienteDataNascimento;
            this.ClienteNome = ClienteNome;
            IdClientes++;



        }
        public Cliente(int Clienteid, string Clientenome, int ClienteCPF, DateTime Nascimento, decimal Clientesalario)
                  
        {
            this.ClienteNome = Clientenome;
            this.ClientId += Clienteid;
            this.CPF = ClienteCPF;
            this.ClienteDataNascimento = Nascimento;
            this.ClienteSalario = Clientesalario;
            

        }    
        public bool VerificarSeCorrentistaMaior() 
        {
            var today = DateTime.Today;
            var age = this.ClienteDataNascimento.Year - today.Year;


            if (today.Month < this.ClienteDataNascimento.Month || (today.Month == this.ClienteDataNascimento.Month && today.Day < this.ClienteDataNascimento.Day))
            {
                age = age - 1;            
            }
            {


                if(age >= 18) 
                {
                    return true;
                
                }
                else 
                {
                return false;
                
                }
            }
        }
        public static int GenerateId()
        {

            return IdClientes;


        }
       public string TipoCliente() 
        {
            if(this.ClienteSalario <= 2999) 
            {
                return "Silver";
            }

            
        }




        
    }   

}
