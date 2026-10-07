
using DreamApi.Models;
using DreamApi.Data;

namespace DreamApi.Services
{
    public class UsuarioService
    {
        private readonly DreamDbContext _context;

        public UsuarioService(DreamDbContext context)
        {
            _context = context;
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Editar(Usuario usuario)
        {
            Usuario usuarioExistente = _context.Usuarios
                .Find(usuario.Id);

            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.Senha = usuario.Senha;

                _context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}