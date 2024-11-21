using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Service
{
    public class CaminhaoService
    {
        private List<Caminhao> _caminhoes;

        public CaminhaoService()
        {
            _caminhoes = new List<Caminhao>();
        }
        public void AdicionarCaminhao(Caminhao caminhao)
        {
            _caminhoes.Add(caminhao);
            Console.WriteLine($"Caminhão {caminhao.Modelo} adicionado com sucesso!");
        }

        public void ListarCaminhoes()
        {
            if (_caminhoes.Count == 0)
            {
                Console.WriteLine("Não há caminhões registrados.");
                return;
            }

            foreach (var caminhao in _caminhoes)
            {
                caminhao.ExibirDetalhes();
            }
        }

        public void CalcularConsumoCaminhoes(double distancia)
        {
            foreach (var caminhao in _caminhoes)
            {
                double consumo = caminhao.CalcularConsumo(distancia);
                Console.WriteLine($"{caminhao.Modelo} vai consumir {consumo:F2} litros para {distancia} km.");
            }
        }
    }
}

