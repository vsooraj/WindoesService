using System;
using System.IO;

namespace DataParserWindowsService
{
    public static class Library
    {
        public static void WriteErrorLog(Exception exception)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + exception.Source.ToString().Trim() + ":" + exception.Message.ToString());
                sw.Flush();
                sw.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void WriteErrorLog(string message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + message.Trim());
                sw.Flush();
                sw.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
