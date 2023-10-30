using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMAUIDEMO.Models
{
    public class CCustomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email {  get; set; }

        public override string ToString() { return this.name + "/" + this.email; }
    }
}
