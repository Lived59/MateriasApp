using Domain.Entities;

namespace Repository;

public class ProfesorRepository
{
    private List<Profesor> profesores = new();

    public void AgregarProfesor(Profesor profesor)
    {
        profesores.Add(profesor);
    }

    public List<Profesor> ObtenerPorMateria(string nombreMateria)
    {
        return profesores
            .Where(p => p.Materia.Nombre == nombreMateria)
            .ToList();
    }
}