using System;
using System.Collections.Generic;
using System.Text;

namespace XMLProject
{
    class ParserFactory
    {
        //Factory Design Implementation
        static public Parser getParserObject(String parserType)
        {
            Parser parser = null;
            switch (parserType)
            {
                case "XML":
                    parser = new Parser(new XMLParser());   //Dependency Injector
                    break;
        //We can Add new parser types in future as per our requirment

            }
            return parser;
        }
        
    }
}
