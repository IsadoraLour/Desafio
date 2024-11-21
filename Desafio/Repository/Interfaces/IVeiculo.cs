﻿using Desafio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Repository.Interfaces
{
    public interface IVeiculo
    {
        string Modelo { get; set; }
        double ConsumoPorKm { get; set; }
        void ExibirDetalhes();
        double CalcularConsumo(double distancia);
    }
}
