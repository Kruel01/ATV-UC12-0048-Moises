using System;
using System.Collections.Generic;
using System.Linq;
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
        public double ClienteSalario { get; set; }

        public Cliente(int Clienteid, string Clientenome, int ClienteCPF, DateTime Nascimento, double Clientesalario)
                  
        {
            this.ClienteNome = Clientenome;
            this.ClientId = Clienteid;
            this.CPF = ClienteCPF;
            this.ClienteDataNascimento = Nascimento;
            this.ClienteSalario = Clientesalario;
        }    
    }
}
