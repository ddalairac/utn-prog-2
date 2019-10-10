using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planetas
        {
            get { return this.planetas; }
            set
            {
                //if (value is List<Astro>)
                //{
                Console.WriteLine(value.GetType());
                this.planetas = value;
                //} else
                //{
                //    Console.WriteLine("NOOOO Agrega");
                //}
            }
        }

        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
            this.planetas.Add(new Planeta(365, 24, "Tierra", 1, Tipo.Rocoso));
            this.planetas.Add(new Planeta(234, 24, "Marte", 1, Tipo.Rocoso));
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder("PLANETAS\n");
            foreach (Astro a in this.planetas)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
        public Dictionary<int, string> ListarPlsnetas()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            int index = 0;
            foreach (Planeta p in this.planetas)
            {
                index = dic.Count;
                if (!(p is null))
                {
                    //Console.WriteLine("No es null");
                    if (!(dic.ContainsKey(index)))
                    {
                        //Console.WriteLine("No existe el indice");
                        dic.Add(index, (string)p);
                    }
                }
            }
            return dic;
        }

    }
}
