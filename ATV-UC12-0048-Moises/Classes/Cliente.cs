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
        public string CPF { get; set; }
        public DateTime ClienteDataNascimento { get; set; }
        public decimal ClienteSalario { get; set; }
        private static int IdClientes;
        private static DateTime Data_Nascimento_Static;

        public Cliente() 
        {
            
        }

        public Cliente(string CPF)
        {
            this.CPF = CPF;
            this.ClientId = ClientId;
            this.ClienteSalario = ClienteSalario;
            this.ClienteDataNascimento = ClienteDataNascimento;
            this.ClienteNome = ClienteNome;
            IdClientes++;



        }
        public Cliente(string Clientenome, string ClienteCPF, DateTime Nascimento, decimal Clientesalario)
                  
        {
            this.ClienteNome = Clientenome;
            this.ClientId = IdClientes+1;
            this.CPF = ClienteCPF;
            this.ClienteDataNascimento = Nascimento;
            this.ClienteSalario = Clientesalario;
            IdClientes++;

        }    
       
        public static int GenerateId()
        {

            return IdClientes;


        }
       public string TipoCliente() 
        {
           
            
            if(this.ClienteSalario <= 3000m) 
            {
                return "Silver";
            }
            else if (this.ClienteSalario >= 3001m && this.ClienteSalario <= 5000m )
            {
                return "gold";
            }
            else if (this.ClienteSalario > 5001m && this.ClienteSalario <=10000m)
            {
                return "Diamond";
            }
            else if (this.ClienteSalario >= 10001m )
            {
                return "Black";
            }
            else 
            {
                return "Sem planos";
            }
            
            
        }
        public string MostrarMensagemBoasVindas() 
        {   
            return "Olá Cliente" + this.ClienteNome + this.TipoCliente();
            return this.ClienteNome;
            return this.TipoCliente();
        
        }

        public string MostrarCliente() 
        {



            return this.ClienteNome + this.TipoCliente() + this.ClienteDataNascimento + this.ClienteSalario + this.CPF + this.ClientId;
        
        }
        public static bool verificarNascimento(DateTime Nascimento) 
        {

            int idade = DateTime.Today.Year - Nascimento.Year;
            if (DateTime.Today < Nascimento.AddYears(idade))
            {
                idade--;

            }
            if (idade < 18)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        
    }   

}
