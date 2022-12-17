using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFirmService.BLL
{
    public class Contact
    {
        public Contact(ContType contType)
        {
        BeginDt = DateTime.Now;
        CntType = contType;
        }
        public DateTime BeginDt { get; private set; }
        public DateTime? EndDt { get; set; }
        public ContType CntType { get;private set; }
        public string? DataInfo { get; set; }
        public string? Descr { get; set; }

        public Contact Clone()
        {
            Contact contact = new Contact(CntType) 
            {
                BeginDt=BeginDt,
                EndDt = EndDt,
                DataInfo = DataInfo,
                Descr = Descr
            };
            return contact;
        }
    }
}
