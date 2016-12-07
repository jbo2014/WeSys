using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine
{
    /// <summary>
    /// 加载流程定义XML文件
    /// </summary>
    public class Flow
    {
        public void LoadFlow(string strXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strXml);
            XmlNodeList process = doc.GetElementsByTagName("process");

            foreach (XmlNode node1 in process)
            {
                foreach (XmlNode node in xn.ChildNodes)
                {
                    dt.Columns.Add(new DataColumn(node.Attributes["name"].Value));
                }
            }
        }
    }
}
