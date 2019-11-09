using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio63
{
    public delegate void TempDelegado();
    public class SetIntervalo
    {
        private int intervalo;
        private bool activo;
        public event TempDelegado evento;

        public SetIntervalo(int intervalo)
        {
            this.activo = false;
            this.intervalo = intervalo;
        }

        public void Run()
        {
            this.activo = true;
            do
            {
                System.Threading.Thread.Sleep(this.intervalo);
                this.evento();
            } while (this.activo);
        }
    }
}
