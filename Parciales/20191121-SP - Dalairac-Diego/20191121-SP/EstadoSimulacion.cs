using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
    public static class FrmSistemaSolarExtendido
    {
        public static bool EstadoSimulacion(this FrmSistemaSolar f,string btn)
        {
            if (btn == "Detener")
            {
                //f.Text = "Detenido :: Diego Dalairac";
                return false;
            }
            else
            {
                //f.Text = "Orbitando :: Diego Dalairac";
                return true;
            }
        }
    }

}
