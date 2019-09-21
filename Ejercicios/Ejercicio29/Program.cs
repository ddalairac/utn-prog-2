using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiccHelper dh = new DiccHelper();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string text = "aca van varias palabras, porque aca sarasa, y que va sarasa sarasa";
            dic = DiccHelper.TextToDic(text);

            DiccHelper.PrintDic(dic);
            dic = DiccHelper.SortByKey(dic);
            DiccHelper.PrintDic(dic);
            dic = DiccHelper.SortByValueDes(dic);
            DiccHelper.PrintDic(dic);



            Console.ReadKey();
        }
    }
    public class DiccHelper
    {
        public static void PrintDic(Dictionary<string, int> dic)
        {
            foreach (var item in dic)
            {
                Console.Write("key {0}", item.Key);
                Console.WriteLine("\tvalue {0}", item.Value);
            }
            Console.WriteLine("\n");
        }
        public static Dictionary<string, int> TextToDic(string text)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            text = text.Replace(",", "");
            text = text.Replace(".", "");
            string[] arr = text.Split(' ');
            foreach (string word in arr)
            {
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 1);
                }
                else
                {
                    dic[word]++;
                }
            }
            return dic.ToDictionary(d=> d.Key, d => d.Value);
        }

        public static Dictionary<string, int> SortByKey(Dictionary<string, int> unsortDic)
        {
            SortedDictionary<string, int> sortDic = new SortedDictionary<string, int>();

            foreach (KeyValuePair<string, int> pair in unsortDic)
            {
                sortDic.Add(pair.Key, pair.Value);
            }
            return sortDic.ToDictionary(d => d.Key, d => d.Value);
        }
        public static Dictionary<string, int> SortByValueDes(Dictionary<string, int> unsortDic)
        {
            Dictionary<string, int> sortDic = new Dictionary<string, int>();
            sortDic = unsortDic.OrderBy(word => word.Value).ToDictionary(d => d.Key, d => d.Value);
            sortDic = sortDic.Reverse().ToDictionary(d => d.Key, d => d.Value);
            return sortDic;
        }
        public static Dictionary<string, int> SortByValueAsc(Dictionary<string, int> unsortDic)
        {
            Dictionary<string, int> sortDic = new Dictionary<string, int>();
            sortDic = SortByValueAsc(unsortDic);
            sortDic = sortDic.Reverse().ToDictionary(d => d.Key, d => d.Value);
            return sortDic;
        }
    }
}
