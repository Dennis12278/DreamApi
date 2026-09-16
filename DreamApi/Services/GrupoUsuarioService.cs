using DreamApi.Models;

namespace DreamApi.Services
{
    public class GrupoUsuarioService
    {
        private List<GrupoUsuario> gruposUsuarios = new List<GrupoUsuario>();

        public List<GrupoUsuario> Listar()
        {
            return gruposUsuarios;
        }

        public void Adicionar(GrupoUsuario grupoUsuario)
        {
            gruposUsuarios.Add(grupoUsuario);
        }

        public void Editar(GrupoUsuario grupoUsuario)
        {
            GrupoUsuario grupoUsuarioExistente = gruposUsuarios.Find(g => g.Id == grupoUsuario.Id);

            if (grupoUsuarioExistente != null)
            {
                grupoUsuarioExistente.IdGrupo = grupoUsuario.IdGrupo;
                grupoUsuarioExistente.IdUsuario = grupoUsuario.IdUsuario;
            }
        }

        public void Excluir(int id)
        {
            GrupoUsuario grupoUsuario = gruposUsuarios.Find(g => g.Id == id);

            if (grupoUsuario != null)
            {
                gruposUsuarios.Remove(grupoUsuario);
            }
        }
    }
}