namespace Domain.Entities
{
    public class Semestre
    {
        public int Numero { get; }
        public List<Materia> Materias { get; }

        public Semestre(int numero)
        {
            Numero = numero;
            Materias = new List<Materia>();
        }

        public void AgregarMateria(Materia materia)
        {
            Materias.Add(materia);
        }
    }
}