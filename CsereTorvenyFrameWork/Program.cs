using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsereTorvenyFrameWork
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "itv.txt";
			string inputCopy = "itvCopy.txt";
			//FileStream openFile = new FileStream(input, FileMode.Open, FileAccess.ReadWrite);
			Encoding e = Encoding.GetEncoding(1250);
			string beolvasottSor;
			string ujsor;
			string rendelet;
			using (StreamReader fileToRead = new StreamReader(input, e))
			{
				StreamWriter fileToWrite = new StreamWriter(inputCopy, true, e);

				while ((beolvasottSor = fileToRead.ReadLine()) != null)
				{
					rendelet = beolvasottSor.Replace("törvény", "rendelet");
					ujsor = rendelet;					
					fileToWrite.WriteLine(ujsor);
				}
				fileToWrite.Close();
			}
		}
	}
}
