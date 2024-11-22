using Desafio.Entidades;

namespace Dominio._01_Core.Interfaces.Service
{
    public interface ICaminhaoService
    {
        void Adicionar(Caminhao caminhao);
        Caminhao BuscarPorId(int id);
        void Editar(Caminhao caminhao);
        List<Caminhao> Listar();
        void Remover(int id);
    }
}

