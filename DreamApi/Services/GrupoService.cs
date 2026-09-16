using DreamApi.Models;

namespace DreamApi.Services
{
    public class GrupoService
    {
        private List<Grupo> grupos = new List<Grupo>();

        public List<Grupo> Listar()
        {
            return grupos;
        }

        public void Adicionar(Grupo grupo)
        {
            grupos.Add(grupo);
        }

        public void Editar(Grupo grupo)
        {
            Grupo grupoExistente = grupos.Find(g => g.Id == grupo.Id);

            if (grupoExistente != null)
            {
                grupoExistente.Nome = grupo.Nome;
                grupoExistente.Descricao = grupo.Descricao;
            }
        }

        public void Excluir(int id)
        {
            Grupo grupo = grupos.Find(g => g.Id == id);

            if (grupo != null)
            {
                grupos.Remove(grupo);
            }
        }
    }
}