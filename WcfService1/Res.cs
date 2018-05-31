using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WcfService1
{
    [DataContract]
    [XmlSerializerFormat]
    [XmlRoot]
    public class Res
    {
        //[DataMember]
        [XmlAttribute("ID", Form = XmlSchemaForm.Qualified)]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime Birthdate { get; set; }
    }
}