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
			const char[] check={'1','2','3','4','5','6','7','8','9','0'};
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
