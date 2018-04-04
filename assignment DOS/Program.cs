using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace dosattake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			for (; ; )
			{
				 
				Console.Write("Write url : ");
				string x = Console.ReadLine();
				while (true)
				{
					
						HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(x);

						Console.WriteLine(x);
				
				}
				
			}
			}
	}
}
