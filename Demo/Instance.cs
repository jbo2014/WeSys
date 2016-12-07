using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Demo
{
    class Instance
    {
        public string LoadStrXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"G:\GitHubs\WeSys\Demo\diagram.bpmn20.xml");
            string strXml = xml.InnerXml;
            return strXml;
        }

        public void run()
        {

            Console.Read();
        }
    }
}
