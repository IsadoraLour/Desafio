using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository.Interfaces
{
    public interface ICaminhao
    {
        void AdicionarCaminhao(Caminhao caminhao);
        void ListarCaminhoes();
        void CalcularConsumoCaminhoes(double distancia);
    }
}

