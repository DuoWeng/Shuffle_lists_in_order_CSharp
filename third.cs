using System;
using System.Text;//if you choose to use StringBuilder
class Program{
	static void Main (string[] args)
	{
	
		Console.WriteLine("Please input the first list:");
		string str1 = Console.ReadLine();
		Console.WriteLine("Please input the second list:");
		string str2 = Console.ReadLine();
		string output = new string(' ',str1.Length+str2.Length);
		shuffle(str1,str2,output,0);
	}
	private static void shuffle (string str1, string str2, string output,int i)
	{
		if (str1.Length == 0 && str2.Length == 0) {
			Console.WriteLine (output);
		}
		if (str1.Length > 0) {
			char[] tempt = output.ToCharArray();
			tempt[i] = str1[0]; 
			string newOutput = new string(tempt);
			string newString = str1.Substring(1);
			shuffle (newString,str2,newOutput,i+1);
		}
		if (str2.Length > 0) {
			StringBuilder sb = new StringBuilder(output);
			sb[i] = str2[0];
			string newString = str2.Substring(1);
			shuffle (str1,newString,sb.ToString(),i+1);
		}
	}
}