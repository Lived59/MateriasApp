namespace Domain.Entities
{
    public class Usuario
    {
        public string Nombre { get; }

        public List<Materia> Materias { get; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
            Materias = new List<Materia>();
        }

        public int ObtenerCreditosTotales()
        {
            return Materias
                .Where(m => m.Estado == Enums.EstadoMateria.AprobadaTotal)
                .Sum(m => m.Creditos);
        }
    }
}