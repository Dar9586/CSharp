using System;
using System.Collections.Generic;
namespace ita
{
	public class Anagram
	{

		private static List<string> final2=new List<string>();
		private static void comb(Tuple<List<char>, string> z) {
			List<char> x=z.Item1;
			string y=z.Item2;
			if (x.Count!=0){ 
				for(int a=0;a<x.Count;a++) {
					List<char>cac=new List<char>(x);
					string o=y+cac[a].ToString();
					cac.RemoveAt(a);
					Tuple<List<char>, string> tuple =new Tuple<List<char>, string>(cac,o);
					comb(tuple);
				}
			}
			else {if(!final2.Contains(y)){ final2.Add(y);Console.WriteLine(y);} }
		}

		private static void met(string s){
			Console.Clear();
			List<char>start2=new List<char>(s.ToCharArray());
			List<char>start=new List<char>();
			for(int a=0;a<start2.Count;a++) {if(!start.Contains(start2[a])) {start.Add(start2[a]);} }
			for(int a=0;a<start.Count;a++) {
				List<char>cac=new List<char>(start2);
				string o=cac[a].ToString();
				cac.RemoveAt(start2.IndexOf(start[a]));
				Tuple<List<char>, string> tuple =new Tuple<List<char>, string>(cac,o);
				comb(tuple);
			}
			Console.ReadLine();
		}


		public static void anagram ()
		{
			Console.Write("Insert word: ");
			string s=Console.ReadLine();
			if(s.Length>0){
				met(s);
			}
		}
	}
}

