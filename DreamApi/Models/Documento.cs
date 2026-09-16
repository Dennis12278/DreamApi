namespace DreamApi.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
    }
}