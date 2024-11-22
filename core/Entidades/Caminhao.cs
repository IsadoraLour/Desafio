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
        public bool Baú { get; set; }
        public object EixoDuplo { get; internal set; }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} toneladas");
            Console.WriteLine($"Tipo Baú: {(Baú ? "Sim" : "Não")}");
        }

        public override double CalcularConsumo(double distancia)
        {
            double fatorConsumo = Baú ? 1.5 : 1; 
            return (distancia / (ConsumoPorKm * fatorConsumo));
        }
    }
}