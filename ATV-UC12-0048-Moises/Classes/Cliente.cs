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
        public int VerificarSeCorrentistaMaior(DateTime Nascimento) 
        {
            var today = DateTime.Today;
            var age = Nascimento.Year - today.Year;


            return  age;
        }
        public static int GenerateId()
        {

            return IdClientes;


        }
    }   

}
