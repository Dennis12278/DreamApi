using DreamApi.Models;

namespace DreamApi.Services
{
    public class AnotacaoService
    {
        private List<Anotacao> anotacoes = new List<Anotacao>();

        public List<Anotacao> Listar()
        {
            return anotacoes;
        }

        public void Adicionar(Anotacao anotacao)
        {
            anotacoes.Add(anotacao);
        }

        public void Editar(Anotacao anotacao)
        {
            Anotacao anotacaoExistente = anotacoes.Find(a => a.Id == anotacao.Id);

            if (anotacaoExistente != null)
            {
                anotacaoExistente.Titulo = anotacao.Titulo;
                anotacaoExistente.Texto = anotacao.Texto;
            }
        }

        public void Excluir(int id)
        {
            Anotacao anotacao = anotacoes.Find(a => a.Id == id);

            if (anotacao != null)
            {
                anotacoes.Remove(anotacao);
            }
        }
    }

}