using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLProject
{
    //XML Implementation of IParser
    public class XMLParser:IParser
    {
        // 1 - Define Delegate (Defines Contract between publisher and subscriber)
        public delegate void XMLParserEventHandler(Object source, String args);
        // 2 - Define Event Based on Delegate
        public event XMLParserEventHandler XMLParsed;
        public void ParseFile()
        {
            bool isTagEnd = false;
            XmlReader reader = XmlReader.Create(Utils.xmlFilePath);
            while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == Utils.xmlTag))
                    {
                        if ((reader.HasAttributes) && (reader.GetAttribute(Utils.attributeName) == Utils.attributeValue))
                        {
                            while (reader.Read() && !isTagEnd)
                            {
                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.Text: //Display the text in each element.
                                    // 3 - Publish Event(notify subscriber)
                                    OnXmlParsing(reader.Value);
                                        break;
                                    case XmlNodeType.EndElement: //Display the end of the element.
                                        if (reader.Name == Utils.xmlTag)
                                        {

                                            isTagEnd = true;
                                        }
                                        break;
                                }

                            }

                        }
                    }
                }
        }
        public virtual void OnXmlParsing(String reader)
        {
            if(XMLParsed != null)
            {
                XMLParsed(this, reader);
            }
        }
    }
}
