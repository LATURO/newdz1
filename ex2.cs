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
			string al="1234567890";
			Console.Write("Массив до замены: ");
			char[] check=al.ToCharArray();
			for (int i = 0; i < b.Length;i++) {
				for(int j=0;j<al.Length();j++){
				if(b[i]==check[j]){
				b[i]='$';
				}
				}
			}
			Console.Write("\r\nМассив после замены: ");
			for (char i in b) {
				Console.Write(i);
			}
		}
	}
}
