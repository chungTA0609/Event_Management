using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf
{
    public class Event_A
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string eventStatus { get; set; }
        [DataMember]
        public string dataEvent { get; set; }
        [DataMember]
        public string timeStart { get; set; }
        [DataMember]
        public string timeEnd { get; set; }
        [DataMember]
        public string descriptionEvent { get; set; }
        [DataMember]
        public string createBy { get; set; }
        [DataMember]
        public DateTime createAt { get; set; }

    }
}
