using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public class PessoaFisica : Pessoa
    {
        private string Cpf { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCPF: {GetCpf()}";
        }   
    }
}
