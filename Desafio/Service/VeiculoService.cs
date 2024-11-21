using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Service
{
    public class VeiculoService
    {
        private List<Veiculo> _veiculos;

        public VeiculoService()
        {
            _veiculos = new List<Veiculo>();
        }
        public void AdicionarVeiculo(Veiculo veiculo)
        {
            _veiculos.Add(veiculo);
            Console.WriteLine($"{veiculo.GetType().Name} adicionado com sucesso!");
        }
        void Adicionarveiculo(Veiculo veiculo)
        {
            if (_veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos registrados.");
                return;
            }

            foreach (var Veiculo in _veiculos)
            {
                veiculo.ExibirDetalhes();
            }
        }
        public void CalcularConsumoVeiculos(double distancia)
        {
            foreach (var veiculo in _veiculos)
            {
                double consumo = veiculo.CalcularConsumo(distancia);
                Console.WriteLine($"{veiculo.GetType().Name} vai consumir {consumo:F2} litros para {distancia} km.");
            }
        }
    }
}

