using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CSharp7ConsoleApp.Program;

namespace CSharp7ConsoleApp
{
	/// <summary>
	/// C# 7.0
	/// https://ufcpp.net/study/csharp/cheatsheet/ap_ver7/
	/// </summary>
	class Sample70
	{

		internal void Run()
		{
			Log("start");
			タプル();
			型のスイッチ();
			Log("end");
		}

		void タプル()
		{
			Log("start");
			var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			var t = Tally(data);
			WriteLine($"sum={t.sum}, count={t.count}");
			Log("end");
		}

		(int count, int sum) Tally(IEnumerable<int> items)
		{
			var count = 0;
			var sum = 0;
			items.All(c =>
		   {
			   sum += c;
			   count++;
			   return true;
		   });
			return (count, sum);
		}

		enum ResultEnum
		{
			正常 = 3,
			業務エラー = 500,
			警告エラー = 700,
			システムエラー = 900
		}

		void 型のスイッチ()
		{
			Log("start");

			var result = (int)ResultEnum.警告エラー;
			switch (result)
			{
				case int n when n == 3:
					WriteLine("正常");
					break;
				case int n when n >= 500:
					WriteLine("業務エラー");
					break;
				case int n when n >= 800:
					WriteLine("警告エラー");
					break;
				case int n when n >= 900:
					WriteLine("システムエラー");
					break;
			}

			Log("end");
		}
	}
}
