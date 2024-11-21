using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository.Interfaces
{
    public interface ICarro : IVeiculo
    {
        string Tipo { get; set; }
        bool Hibrido { get; set; }
        new double CalcularConsumo(double distancia);
    }
}
