using Desafio.Entidades;
using Desafio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository
{
    public class CarroRepository
    {
        private List<Carro> _carros;

        public CarroRepository()
        {
            _carros = new List<Carro>();
        }

        public void Adicionar(Carro carro)
        {
            _carros.Add(carro);
        }

        public IEnumerable<Carro> Listar()
        {
            return _carros;
        }

        public Carro BuscarPorModelo(string modelo)
        {
            return _carros.FirstOrDefault(c => c.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
        }

        public bool Atualizar(string modelo, Carro carroAtualizado)
        {
            var carro = BuscarPorModelo(modelo);
            if (carro != null)
            {
                carro.Modelo = carroAtualizado.Modelo;
                carro.ConsumoPorKm = carroAtualizado.ConsumoPorKm;
                carro.Tipo = carroAtualizado.Tipo;
                carro.Hibrido = carroAtualizado.Hibrido;
                return true;
            }
            return false;
        }

        public bool Remover(string modelo)
        {
            var carro = BuscarPorModelo(modelo);
            if (carro != null)
            {
                _carros.Remove(carro);
                return true;
            }
            return false;
        }
    }
}
