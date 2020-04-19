using System;
using System.Collections.Generic;
using System.Text;

namespace XMLProject
{
    class Parser
    {
        private IParser parseObject;
        public Parser(IParser parser)
        {
            parseObject = parser;
        }
        public IParser getParser()
        {
            return parseObject;
        }
    }
}
