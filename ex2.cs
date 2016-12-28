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
				if (int.TryParse(b[i],out buf)==true) {
					array[i] = "$";
				}
			}
			Console.Write("\r\nМассив после замены: ");
			for (int i = 0; i < s;i++) {
				Console.Write("{0}", array[i]);
			}
		}
	}
}
