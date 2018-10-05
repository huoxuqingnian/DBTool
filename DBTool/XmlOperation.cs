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

        private XDocument xdoc = new XDocument();

        public XDocument Xdoc
        {
            get { return xdoc; }
            set { xdoc = value; }
        }

        private string rootNodeName = "config";

        public string RootNodeName
        {
            get { return rootNodeName; }
            set { rootNodeName = value; }
        }
        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="xmlFileName"> Xml 文件路径 </param>
        public XmlOperation(string xmlFileName)
            :this()
        {
            XmlFileName = xmlFileName;
            this.Xdoc = GetXDocument(xmlFileName);
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="xmlFileName"> Xml 文件路径 </param>
        /// <param name="rootNodeName"> 根节点名 </param>
        public XmlOperation(string xmlFileName, string rootNodeName)
            :this(xmlFileName)
        {
            this.rootNodeName = rootNodeName;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        public XmlOperation()
        {

        }

        /// <summary>
        /// 获取 XDocument 对象
        /// </summary>
        /// <param name="xmlFileName"></param>
        /// <returns></returns>
        public XDocument GetXDocument(string xmlFileName)
        {
            return XDocument.Load(xmlFileName);
        }

        /// <summary>
        /// 获取 XElement 对象
        /// </summary>
        /// <param name="xdoc"></param>
        /// <param name="parentNodeName"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public XElement GetXElement(XDocument xdoc, XName parentNodeName, XName targetNodeName)
        {
            parentNodeName = (parentNodeName == null) ? this.RootNodeName : parentNodeName;
            return xdoc.Elements(parentNodeName).Elements().Where(x => x.Name == targetNodeName).Single();
        }

        /// <summary>
        /// 查询节点属性值（根据节点名及属性名）
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public string QueryElementAttribute(XName parentNodeName, XName targetNodeName, XName attributeName)
        {
            XElement xele = GetXElement(this.Xdoc, parentNodeName, targetNodeName);
            return xele.Attribute(attributeName).Value;
        }

        /// <summary>
        /// 更新节点属性
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="attributeName"></param>
        /// <param name="newAttributeValue"></param>
        public void UpdateElementAttribute(XName parentNodeName, XName targetNodeName, XName attributeName, string newAttributeValue)
        {
            XElement xele = GetXElement(this.Xdoc, parentNodeName, targetNodeName);
            xele.SetAttributeValue(attributeName, newAttributeValue);
            this.Xdoc.Save(XmlFileName);
        }
    }
}
