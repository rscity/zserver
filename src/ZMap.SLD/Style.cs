using System.Xml.Serialization;

namespace ZMap.SLD;

public class Style
{
    /// <summary>
    /// Required: false
    /// 样式的名称，用于从外部引用它。（对于目录样式忽略。）
    /// </summary>
    [XmlElement("Name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Description")]
    public Description Description { get; set; }
}