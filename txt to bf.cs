using System;
namespace TXT2BF
{
	class Program
	{
		public static void Main(string[] args)
		{
			string str = Console.ReadLine();
			byte[] unibyte = System.Text.Encoding.Unicode.GetBytes(str);
			string uniString = string.Empty;
			foreach(byte b in unibyte)
			{
				uniString += string.Format("{0} ",b.ToString());
			}
			Console.Write(">>");
			int x = 0;
			foreach (string i in uniString.Split(' '))
			{
				if (i == "0" || i == uniString.Split(' ')[uniString.Split(' ').Length - 1]) continue;
				if (x == 1)
				{
					Console.Write(">");
					for (int z = 0; z != Convert.ToInt32(i); z++)
					{
						Console.Write("+");
					}
					Console.WriteLine(".");
				}
				else
				{
					for (int z = 0; z != Convert.ToInt32(i); z++)
					{
						Console.Write("+");
					}
					Console.WriteLine(".");
					x = 1;
				}
			}
			Console.ReadLine();
		}
	}
}