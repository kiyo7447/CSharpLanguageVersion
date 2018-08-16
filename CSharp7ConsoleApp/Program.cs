using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace CSharp7ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //タプル
            //http://www.atmarkit.co.jp/ait/articles/1702/22/news019.html
            IEnumerable<string> collection = new List<string> { "あ", "い", "う" };
            foreach (var item in collection.Select((Value, Index) => new { Value, Index }))
            {
                string value = item.Value; // コレクションの要素
                int index1 = item.Index; // ループのインデックス
                Debug.WriteLine($"value={item.Value}, index={item.Index}");
                /*
value=あ, index=0
value=い, index=1
value=う, index=2
                 */
            }


            //http://www.atmarkit.co.jp/ait/articles/1703/24/news021_2.html
            // 値タプルを受け取ると同時に、ローカル変数indexとnameへ分解
            var(index, name) = LocalFunc1();
            WriteLine($"{index}, {name}");
            // 出力：123, aaa

            // ローカル関数（呼び出しているところより後に書いても構わない）
            // この返値は値タプル（indexとnameをいっぺんに返す）
            (int index, string name) LocalFunc1()
  {
                // 数値リテラルの2進数表記と、桁区切り
                return (0b0111_1011, "aaa");
            }

#if DEBUG
            //            Console.In.ReadLine();
#endif


        }
        void Run()
        {

        }


    }
}
