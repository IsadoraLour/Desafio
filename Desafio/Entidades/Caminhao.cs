using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entidades
{
    public class Caminhao : Veiculo

    {
        public double CapacidadeCarga { get; set; }
        public double PesoCarga { get; set; }

        public override void ExibirDetalhes()

        {
            base.ExibirDetalhes();

            Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} Toneladas, Peso da Carga: {PesoCarga} Toneladas");
        }
        public override double CalcularConsumo(double distancia)

        {
            double fatorCarga = 1 + (PesoCarga / CapacidadeCarga) * 0.2; 
            return distancia / (ConsumoPorKm * fatorCarga);
        }

    }
}