using Domain.Entities;
using Domain.Enums;

namespace Services
{
    public class MateriaService
    {
        public bool PuedeCursar(Materia materia, Usuario usuario)
        {
            if (usuario.ObtenerCreditosTotales() < materia.CreditosNecesarios)
                return false;

            foreach (var previa in materia.Previas)
            {
                var estado = previa.MateriaPrevia.Estado;

                if (previa.TipoCredito == TipoCreditoPrevia.Total &&
                    estado != EstadoMateria.AprobadaTotal)
                    return false;

                if (previa.TipoCredito == TipoCreditoPrevia.Parcial &&
                    estado == EstadoMateria.NoCursada)
                    return false;
            }

            return true;
        }
    }
}