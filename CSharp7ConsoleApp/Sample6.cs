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
	/// https://ufcpp.net/study/csharp/ap_ver6.html
	/// </summary>
	//#pragma warning disable 169
	class Sample6
	{
		string className = nameof(Sample6);

		internal void Run()
		{
			var methodName = nameof(Run);
			Log(className, methodName, "start");
			nameof演算子();
			インデックス初期化子();
			Log(className, methodName, "end");
		}

		public int MyProperty => myField;
		private int myField = 10;

		void nameof演算子()
		{
			var methodName = nameof(nameof演算子);
			Log(className, methodName, "start");

			var myLocal = 10;
			WriteLine(nameof(Sample6));
			WriteLine(nameof(MyProperty) + " = " + MyProperty);
			WriteLine(nameof(myField) + " = " + myField);
			WriteLine(nameof(nameof演算子));
			WriteLine(nameof(myLocal) + " = " + myLocal);

			Log(className, methodName, "end");
		}

		void インデックス初期化子()
		{
			var methodName = nameof(インデックス初期化子);
			Log(className, methodName, "start");

			var dic = new Dictionary<string, int> { ["a"] = 1, ["b"] = 2 };
			dic.All(c => {
				WriteLine($"key={c.Key}, value={c.Value}");
				return true;
			});

			var list = new List<int> { 1, 2, 4 };
			list.All(c => {
				WriteLine($"value={c}");
				return true;
			});

			Log(className, methodName, "end");
		}



	}
}
