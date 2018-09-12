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
	/// C# 5.0
	/// https://ufcpp.net/study/csharp/ap_ver5.html
	/// </summary>
	class Sample5
	{
		internal void Run()
		{
			Log("start");
			CallerInfo属性();
			Log("end");
		}

		void CallerInfo属性()
		{
			Log("start");

			//LogメソッドがCallerInfo属性のサンプルとなります。

			Log("end");
		}

	}
}
