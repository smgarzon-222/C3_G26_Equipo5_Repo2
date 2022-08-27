namespace Torneo.App.Dominio
{
    public class Equipo
    {
        
         int Id { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
        public DirectorTecnico DirectorTecnico { get; set; }
    }
}