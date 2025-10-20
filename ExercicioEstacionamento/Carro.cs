using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public class Carro : Veiculo
    {
        private int QuantidadePortas {  get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }

        public int GetQuantidadePortas()
        {
            return QuantidadePortas;
        }
        public void SetQuantidadePortas(int quantidadePortas)
        {
            this.QuantidadePortas = quantidadePortas;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nQuantidade de Portas: {GetQuantidadePortas()}";
        }
    }
}
