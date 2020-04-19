using System;
using System.IO;

namespace XMLProject
{
    public class FilesHandler
    {
        public FilesHandler( )
        {
            //Checks whether Files already exists or not, if exists delete existing file
            if (File.Exists(Utils.fileName))
            {
                File.Delete(Utils.fileName);
            }
        }
        public static void OnXmlParsing(Object source, String reader)//On XML Parsing , Writes to the File
        {
            System.IO.StreamWriter file;
            using (file = new System.IO.StreamWriter(Utils.fileName, true))
            {
                file.WriteLine(reader); //Append text at end of file
            }
        }
    }
}
