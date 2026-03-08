namespace Domain.Entities;

public class Profesor
{
    public string Nombre { get; }
    public Materia Materia { get; }
    public string Opinion { get; }
    public int Puntaje { get; }

    public Profesor(string nom, Materia mat, string op, int puntaje)
    {
        Nombre = nom;
        Materia = mat;
        Opinion = op;
        Puntaje = puntaje;
    }
}