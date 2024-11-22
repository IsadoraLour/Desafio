using Desafio.Entidades;

namespace Dominio._01_Core.Interfaces.Repository
{
    public interface ICaminhaoRepository
    {
        void Adicionar(Caminhao carro);
        void Remover(int id);
        void Editar(Caminhao carro);
        List<Caminhao> Listar();
        Caminhao BuscarPorId(int id);
    }
}
