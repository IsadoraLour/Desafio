using Desafio.Entidades;

namespace Dominio._01_Core.Interfaces.Service
{
    public interface ICarroService
    {
        void Adicionar(Carro carro);
        Carro BuscarPorId(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        void Remover(int id);
    }
}