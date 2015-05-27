using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace kuznecov.SupportStation.DBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICallService
    {
        void Create();

        void Update();

        void Delete();

        CallType Get(int id);
    }

    public class CallType
    {
        DateTime date { get; set; }

        [DataMember]
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = date;
            }
        }
    }

}
