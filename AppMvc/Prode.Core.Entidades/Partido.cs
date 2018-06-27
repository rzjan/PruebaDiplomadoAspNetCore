using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Partido
    {
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }

        public int CantGolesLocal { get; set; }

        public int CantGolesVisitante { get; set; }

        public DateTime Fecha { get; set; }


        public string InformarResultado
        {
            get{
                var resultado = "";
                if (CantGolesLocal > CantGolesVisitante)
                {
                    return resultado = $"Gano { EquipoLocal.Nombre}";

                }else if (CantGolesLocal < CantGolesVisitante)
                    {
                    return resultado = $"Gano { EquipoVisitante.Nombre}";
                }
                    else
                    {
                    return resultado = "Empate";

                }
            }
            set
            {

            }
        }
            
            
        



    }
}
