using System;

namespace ееее
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			

			int buf;
			string s=Console.ReadLine();
			char[] b = s.ToCharArray();
			Console.Write("Массив до замены: ");
			
			for (int i = 0; i < b.Length;i++) {
				if (int.TryParse(Convert.ToString(b[i]),out buf)==true) {
					b[i] = "$";
				}
			}
			Console.Write("\r\nМассив после замены: ");
			for (char i in b) {
				Console.Write(i);
			}
		}
	}
}
