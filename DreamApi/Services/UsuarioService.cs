using DreamApi.Models;

namespace DreamApi.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> Listar()
        {
            return usuarios;
        }

        public void Adicionar(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void Editar(Usuario usuario)
        {
            Usuario usuarioExistente = usuarios.Find(u => u.Id == usuario.Id);

            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.Senha = usuario.Senha;
            }
        }

        public void Excluir(int id)
        {
            Usuario usuario = usuarios.Find(u => u.Id == id);

            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
        }
    }
}