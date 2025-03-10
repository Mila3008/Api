namespace ApiSegundoDS.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Escola Escola { get; set; }
        public Aluno Aluno { get; set; }
    }
}