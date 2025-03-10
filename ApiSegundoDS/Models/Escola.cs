namespace ApiSegundoDS.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Professor Professor { get; set; }
    }
}