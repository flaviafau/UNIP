using GerenciadorTarefas.Models;
using System.Collections.Generic;

namespace GerenciadorTarefas.DAO {
    public interface IDiarioDeNotaDAO {
        
        IEnumerable<Tarefa> BuscarTarefasNaoEntreguesDoAlunoComId(int id);

        IEnumerable<DiarioDeNota> BuscarDiariosDeTarefasEntregueDoAlunoComId(int id);

        void Cadastrar(DiarioDeNota diario);

        void Atualizar(DiarioDeNota diario);

        void Remover(DiarioDeNota diario);

        DiarioDeNota BuscarPorId(int id);
    }
}
