using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Clase Cantina:
a. El único constructor será privado y se encargará tanto de inicializar la lista como de asignar la
   cantidad de espacios disponibles para guardar botellas.
b. GetCantina implementará un patrón Singleton, para lo cual deberá:
    i. Si la variable singleton es null, instanciará el objeto.
    ii. Si no es null, modificará la cantidad de espacios en la cantina.
    iii. En ambos casos, su última acción será retornar el objeto singleton .
c. El operador + agregará, siempre y cuando aún no se hayan ocupado todos los espacios
   disponibles, retornando true si agregó y false en caso contrario.
*/
namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;

        public List<Botella> Botellas
        {
            get { return this.botellas; }
        }

        private Cantina(int espacios) {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        #region Singleton
        private static Cantina instance;
        public static Cantina GetCantina(int espacios) {
            if (instance == null)
            {
                instance = new Cantina(espacios);
            } else
            {
                instance.espaciosTotales = espacios;
            }
            return instance;
        }

        #endregion

        public static bool operator +(Cantina c, Botella b)
        {
            bool aux = false;
            if(!(c is null) && !(b is null) && c.espaciosTotales > 0)
            {
                c.botellas.Add(b);
                c.espaciosTotales--;
            }
            return aux;
        }

    }
}
