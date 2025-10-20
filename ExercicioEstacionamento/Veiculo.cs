using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstacionamento
{
    public abstract class Veiculo
    {
        private string Modelo { get; set; }

        private string Marca { get; set; }

        private string Placa { get; set; }  

        private double ValorDiaria { get; set; }

        private bool Alugado { get; set; }

        private string Locador { get; set; }

        private DateTime DataAluguel { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine(GetModelo());
            Console.WriteLine(GetMarca());
            Console.WriteLine(GetPlaca());
            Console.WriteLine(GetValorDiaria());
            if (GetAlugado())
            {
                Console.WriteLine("Status Locação: Alugado");

            }
            else
            {
                Console.WriteLine("Status Locação: Disponível");
            }
            Console.WriteLine($"{GetDataAluguel()}");            
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public string GetPlaca()
        {
            return Placa;
        }

        public void SetPlaca(string placa)
        {
            this.Placa = placa;
        }

        public double GetValorDiaria()
        {
            return ValorDiaria;
        }

        public void SetValorDiaria(double valorDiaria)
        {
            this.ValorDiaria = valorDiaria;
        }

        public bool GetAlugado()
        {
            return Alugado;
        }

        public void SetAlugado(bool alugado)
        {
            this.Alugado = alugado;
        }

        public DateTime GetDataAluguel()
        {
            return DataAluguel;
        }

        public void SetDataAluguel(DateTime dataAluguel)
        {
            this.DataAluguel = dataAluguel;
        }

        public string GetLocador()
        {
            return Locador;
        }   

        public void SetLocador(string locador)
        {
            this.Locador = locador;
        }

        public override string ToString()
        {
            return $"Modelo: {GetModelo()}\nMarca: {GetMarca()}\nPlaca: {GetPlaca()}\nValor da Diária: {GetValorDiaria()}\nData Locação: {GetDataAluguel()}";
        }
    }
}
