using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{

    public class DiccHelper
    {
        public static string PrintDic(Dictionary<string, int> dic)
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in dic)
            {
                str.AppendFormat("key {0}", item.Key);
                str.AppendFormat("\tvalue {0}\n", item.Value);
            }
            str.AppendLine("\n");

            return str.ToString();
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
            return dic.ToDictionary(d => d.Key, d => d.Value);
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
