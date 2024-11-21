using Desafio.Entidades;
using Desafio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository
{
    public class CaminhaoRepository
    {
        
        private List<Caminhao> _caminhoes;

        public CaminhaoRepository()
        {
            _caminhoes = new List<Caminhao>();
        }
        public void Adicionar(Caminhao caminhao)
        {
            _caminhoes.Add(caminhao);
        }
        public IEnumerable<Caminhao> Listar()
        {
            return _caminhoes;
        }
        public Caminhao BuscarPorModelo(string modelo)
        {
            return _caminhoes.FirstOrDefault(c => c.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
        }

        public bool Atualizar(string modelo, Caminhao caminhaoAtualizado)
        {
            var caminhao = BuscarPorModelo(modelo);
            if (caminhao != null)
            {
                caminhao.Modelo = caminhaoAtualizado.Modelo;
                caminhao.ConsumoPorKm = caminhaoAtualizado.ConsumoPorKm;
                caminhao.CapacidadeCarga = caminhaoAtualizado.CapacidadeCarga;
                caminhao.EixoDuplo = caminhaoAtualizado.EixoDuplo;
                return true;
            }
            return false;
        }

        public bool Remover(string modelo)
        {
            var caminhao = BuscarPorModelo(modelo);
            if (caminhao != null)
            {
                _caminhoes.Remove(caminhao);
                return true;
            }
            return false;
        }
    }
}