using System;

namespace ееее
{
	class MainClass
	{
		public static void Main(string[] args)
		{


		
			string s = Console.ReadLine();
			char[] b = s.ToCharArray();
			int element;
			Console.Write("Массив до замены: ");
			for (int i = 0; i < b.Length; i++)
			{
				element = b[i] - '0';
				if (element >= 0 && element <= 9)
					b[i] = '$';
			}
			Console.Write("\r\nМассив после замены: ");
			foreach (char i in b)
			{
				Console.Write(i);

			}
		}
	}
}
