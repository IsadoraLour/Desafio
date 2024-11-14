using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entidades
{
    public class Carro : Veiculo

    {
        public string Tipo { get; set; }
        public bool Hibrido { get; set; }
        public override void ExibirDetalhes()

        {
            base.ExibirDetalhes();

            Console.WriteLine($"Tipo: {Tipo}, Híbrido: {(Hibrido ? "Sim" : "Não")}");
        }
        public override double CalcularConsumo(double distancia)

        {

            if (Hibrido)
            {
                return (distancia / (ConsumoPorKm * 1.2));
            }
            return base.CalcularConsumo(distancia);
        }

    }
}