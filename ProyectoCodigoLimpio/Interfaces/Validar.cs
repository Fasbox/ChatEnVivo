using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Interfaces
{
    public class Validar
    {
        // Esta clase cumple con el primer principio de SOLID
        // Esta clase cumple con el segundo principio de SOLID

        public static void SoloNumeros(KeyPressEventArgs pE) 
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
