using System;
using System.Xml;
using System.IO;
using System.Text;
namespace XMLProject
{
     class Driver
    {
        static void Main(string[] args)
        {
            Parser parser = ParserFactory.getParserObject(Utils.parserType);  //Get Object of XML Parser by sending Parser Type
            // XMLParser is Publisher
            //FilesHandler is Subscriber
            ((XMLParser)parser.getParser()).XMLParsed += FilesHandler.OnXmlParsing; // Register Handler to an event
            ((XMLParser)parser.getParser()).ParseFile();  //Call Parse Function of XML Parser
        }
    }
}
