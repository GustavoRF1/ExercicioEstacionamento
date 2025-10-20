using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public abstract class Pessoa
    {
        private string Nome {  get; set; }
        private string Telefone { get; set; }

        private string VeiculosAlugados { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine(GetNome());
            Console.WriteLine(GetTelefone());
            Console.WriteLine(GetVeiculosAlugados());
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string GetVeiculosAlugados()
        {
            return VeiculosAlugados;
        }

        public void SetVeiculosAlugados(string veiculosAlugados)
        {
            this.VeiculosAlugados = veiculosAlugados;
        }

        public override string ToString()
        {
            return $"Nome: {GetNome()}\nTelefone: {GetTelefone()}\nVeiculos Alugados: {GetVeiculosAlugados()}";
        }
    }
}
