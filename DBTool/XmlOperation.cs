using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBTool
{
    class XmlOperation
    {
        #region
        private string xmlFileName = string.Empty; // Xml 文件路径

        public string XmlFileName
        {
            get { return xmlFileName; }
            set { xmlFileName = value; }
        }

        #endregion

        /// <summary>
        /// 构造方法（Xml 文件路径）
        /// </summary>
        /// <param name="xmlFileName"> Xml 文件路径 </param>
        public XmlOperation(string xmlFileName)
        {
            XmlFileName = xmlFileName;
        }

        /// <summary>
        /// 构造方法（无参）
        /// </summary>
        public XmlOperation()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// 查询属性值（根据节点名及属性名）
        /// </summary>
        /// <param name="nodeName"> 节点名 </param>
        /// <param name="attributeName"> 属性名 </param>
        /// <returns> 属性值 </returns>
        public string QueryElementAttribute(XName nodeName, XName attributeName)
        {
            // 需要异常处理
            XElement xe = XElement.Load(XmlFileName);
            XElement xele = xe.Element(nodeName);
            XAttribute xa = xele.Attribute(attributeName);
            return xa.Value;
        }

        /// <summary>
        /// 查询节点值（根据节点名）
        /// </summary>
        /// <param name="nodeName"> 节点名 </param>
        /// <returns> 节点值 </returns>
        public string QueryElementValue(XName nodeName)
        {
            // 需要异常处理
            XElement xe = XElement.Load(XmlFileName);
            XElement xele = xe.Element(nodeName);
            return xele.Value;
        }

    }
}
