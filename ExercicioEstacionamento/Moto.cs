using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public class Moto : Veiculo
    {
        private int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }


        public int GetCilindradas()
        {
            return Cilindradas;
        }

        public void SetCilindradas(int cilindradas)
        {
            this.Cilindradas = cilindradas;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCilindradas: {GetCilindradas()}";
        }
    }
}

