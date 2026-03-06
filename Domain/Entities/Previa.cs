using Domain.Enums;

namespace Domain.Entities
{
    public class Previa
    {
        public Materia MateriaPrevia { get; }
        public TipoCreditoPrevia TipoCredito { get; }

        public Previa(Materia materiaPrevia, TipoCreditoPrevia tipoCredito)
        {
            MateriaPrevia = materiaPrevia;
            TipoCredito = tipoCredito;
        }
    }
}