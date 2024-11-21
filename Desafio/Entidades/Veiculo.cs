using Desafio.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entidades
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public double ConsumoPorKm { get; set; }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Consumo por Km: {ConsumoPorKm}");
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }
}