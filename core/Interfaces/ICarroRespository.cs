using Desafio.Entidades;

namespace Dominio._01_Core.Interfaces.Repository
{
    public interface ICarroRespository
    {
        void Adicionar(Carro carro);
        void Remover(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        Carro BuscarPorId(int id);
    }
}
