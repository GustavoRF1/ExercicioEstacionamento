using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public class PessoaJuridica : Pessoa
    {
        private string Cnpj {  get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }

        public string GetCnpj()
        {
            return Cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCNPJ: {GetCnpj()}";
        }
    }
}
