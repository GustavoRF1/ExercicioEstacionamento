using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public class Caminhao : Veiculo
    {
        private double CapacidadeCarga {  get; set; }

        private int NumeroEixos { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }

        public double GetCapacidadeCarga()
        {
            return CapacidadeCarga;
        }

        public void SetCapacidadeCarga(double capacidadeCarga)
        {
            this.CapacidadeCarga = capacidadeCarga;
        }

        public int GetNumeroEixos()
        {
            return NumeroEixos;
        }

        public void SetNumeroEixos(int numeroEixos)
        {
            this.NumeroEixos = numeroEixos;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCapacidade de Carga: {GetCapacidadeCarga()}\nNúmero de Eixos: {GetNumeroEixos()}";
        }
    }
}
