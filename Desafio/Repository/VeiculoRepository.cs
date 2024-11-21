using Desafio.Entidades;
using Desafio.Repository.Interfaces;
using Desafio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository
{
    public class VeiculoRepository
    {
        private List<IVeiculo> _veiculos;

        public VeiculoRepository()
        {
            _veiculos = new List<IVeiculo>();
        }

        public void Adicionar(IVeiculo veiculo)
        {
            _veiculos.Add(veiculo);
        }

        public IEnumerable<IVeiculo> Listar()
        {
            return _veiculos;
        }

        public IVeiculo BuscarPorModelo(string modelo)
        {
            return _veiculos.FirstOrDefault(v => v.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
        }

        public bool Atualizar(string modelo, IVeiculo veiculoAtualizado)
        {
            var veiculo = BuscarPorModelo(modelo);
            if (veiculo != null)
            {
                veiculo.Modelo = veiculoAtualizado.Modelo;
                veiculo.ConsumoPorKm = veiculoAtualizado.ConsumoPorKm;
                return true;
            }
            return false;
        }
        public bool Remover(string modelo)
        {
            var veiculo = BuscarPorModelo(modelo);
            if (veiculo != null)
            {
                _veiculos.Remove(veiculo);
                return true;
            }
            return false;
        }
    }
}