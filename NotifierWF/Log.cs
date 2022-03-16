using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifierWF
{
	public static class Log
	{
		readonly static string LogFileName = "logerrors.txt";		


		public static void HandleError(Exception ex, string message = null)
		{
			string begin = "===============================\r\n" + DateTime.Now.ToString() + "\r\n";
			if (message != null)
				begin += message + "\r\n";

			if (ex.InnerException == null)
			{
				//No InnerException
				string result = begin + ex.Message + "\r\n" + ex.StackTrace + "\r\n";
				WriteLine(result);								
			}
			else
			{
				//With InnerException
				List<Exception> list = new List<Exception>();
				list.Add(ex);
				Exception inner = ex;
				while (inner.InnerException != null)
				{
					inner = inner.InnerException;
					list.Add(inner);
				}
				list.Reverse();
				StringBuilder sb = new StringBuilder();				
				foreach (var item in list)
				{
					sb.Append(ex.Message + "\r\n" + ex.StackTrace + "\r\n");					
				}
				string result = begin + sb.ToString();
				WriteLine(result);				
			}			
		}


		public static void WriteLine(string str)
		{
			File.AppendAllText(LogFileName, str + "\r\n");
		}
	}

}
