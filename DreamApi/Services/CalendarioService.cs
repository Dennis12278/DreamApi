using DreamApi.Models;

namespace DreamApi.Services
{
    public class CalendarioService
    {
        private List<Calendario> calendarios = new List<Calendario>();

        public List<Calendario> Listar()
        {
            return calendarios;
        }

        public void Adicionar(Calendario calendario)
        {
            calendarios.Add(calendario);
        }

        public void Editar(Calendario calendario)
        {
            Calendario calendarioExistente = calendarios.Find(c => c.Id == calendario.Id);

            if (calendarioExistente != null)
            {
                calendarioExistente.IdUsuario = calendario.IdUsuario;
                calendarioExistente.Data = calendario.Data;
                calendarioExistente.Descricao = calendario.Descricao;
            }
        }

        public void Excluir(int id)
        {
            Calendario calendario = calendarios.Find(c => c.Id == id);

            if (calendario != null)
            {
                calendarios.Remove(calendario);
            }
        }
    }
}