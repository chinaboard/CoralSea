using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace CoralSea.Injector
{
    /// <summary>
    /// 依赖注入配置项
    /// </summary>
    internal class InjectorConfig
    {
        private static readonly Object objLock = new object();
        public static String CONFIG_FILE_NAME = AppDomain.CurrentDomain.BaseDirectory + @"/App_Data/TCConfig/CoralSea.Injector.config";

        private static InjectorConfig instance = null;

        private InjectorConfig()
        {
            Initialize();
        }

        public static InjectorConfig GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new InjectorConfig();
                    }
                }
            }

            return instance;
        }

        #region 属性

        /// <summary>
        /// 获取程序集所在目录
        /// </summary>
        public String AssemblyPath { get; private set; }

        #endregion

        /// <summary>
        /// 初始化加载依赖注入配置项
        /// </summary>
        private void Initialize()
        {
            if (!File.Exists(CONFIG_FILE_NAME))
            {
                throw new Exception("错误：找不到依赖注入配置文件！");
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(CONFIG_FILE_NAME);

            XmlNode root = doc.DocumentElement;
            ParseConfig(root);
        }

        private void ParseConfig(XmlNode root)
        {
            XmlNode pathNode = root.SelectSingleNode("./AssemblyPath");
            if (pathNode != null)
            {
                XmlAttribute valAttr = pathNode.Attributes["value"];
                if (valAttr != null)
                {
                    AssemblyPath = AppDomain.CurrentDomain.BaseDirectory;
                    string temp = valAttr.Value;
                    if (!String.IsNullOrWhiteSpace(temp))
                    {
                        if (!temp.StartsWith("/"))
                        {
                            temp = "/" + temp;
                        }

                        AssemblyPath += temp;
                    }
                }
            }
        }
    }
}
