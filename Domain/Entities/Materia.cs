using Domain.Enums;

namespace Domain.Entities
{
    public class Materia
    {
        public string Nombre { get; }
        public string Descripcion { get; }
        public int Creditos { get; }
        public int CreditosNecesarios { get; }
        public int Dificultad { get; }

        public List<Previa> Previas { get; }

        public EstadoMateria Estado { get; private set; }

        public Materia(string nombre, string descripcion,
            int creditosNecesarios, int dificultad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Creditos = 1;
            CreditosNecesarios = creditosNecesarios;
            Dificultad = dificultad;

            Previas = new List<Previa>();
            Estado = EstadoMateria.NoCursada;
        }

        public void CambiarEstado(EstadoMateria nuevoEstado)
        {
            Estado = nuevoEstado;
        }
    }
}