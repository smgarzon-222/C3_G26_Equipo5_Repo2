namespace Torneo.App.Dominio
{
    public class Equipo
    {
        //Esto es un comentario del reto
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
        public DirectorTecnico DirectorTecnico { get; set; }
    }
}