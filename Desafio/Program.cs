using Desafio.Entidades;
using Desafio.Repository.Interfaces;

class Program

{
    static void Main()

    {
        List<IVeiculo> veiculos = new List<IVeiculo>

        {
            new Carro { Modelo = "Fiat", Ano = 2015, CapacidadeTanque = 25, ConsumoPorKm = 15, Tipo = "Prata", Hibrido = false },

            new Caminhao { Modelo = "Ford", Ano = 2012, CapacidadeTanque = 100, ConsumoPorKm = 2, CapacidadeCarga = 10, PesoCarga = 20 }
        };

        foreach (IVeiculo veiculo in veiculos)

        {
            veiculo.ExibirDetalhes();

            Console.WriteLine($"Consumo para 150 km: {veiculo.CalcularConsumo(100)} litros\n");
        }

    }

}