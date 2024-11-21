using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Service
{
    public class CarroService
    {
        private List<Carro> _carros;

        public CarroService()
        {
            _carros = new List<Carro>();
        }
        public void AdicionarCarro(Carro carro)
        {
            _carros.Add(carro);
            Console.WriteLine($"Carro {carro.Modelo} adicionado com sucesso!");
        }

        public void ListarCarros()
        {
            if (_carros.Count == 0)
            {
                Console.WriteLine("Não há carros registrados.");
                return;
            }

            foreach (var carro in _carros)
            {
                carro.ExibirDetalhes();
            }
        }

        public void CalcularConsumoCarros(double distancia)
        {
            foreach (var carro in _carros)
            {
                double consumo = carro.CalcularConsumo(distancia);
                Console.WriteLine($"{carro.Modelo} vai consumir {consumo:F2} litros para {distancia} km.");
            }
        }
    }
}

