namespace Domain.Entities;

public class Profesor
{
    private string Nombre { get; set;}
    private Materia Materia { get; set;}
    private string Opinion { get; set; }
    private int Puntaje { get; set; }

    public Profesor(string nom, Materia mat, string op, int puntaje)
    {
        Nombre = nom;
        Materia = mat;
        Opinion = op;
        Puntaje = puntaje;
    }
    
    
}