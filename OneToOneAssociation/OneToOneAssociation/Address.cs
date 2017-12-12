using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneAssociation
{
    class Address
    {
        public string RoadNo { get; set; }
        public string HouseNo { get; set; }
        public string Thana { get; set; }
        public string District { get; set; }
        public int PostCode { get; set; }
        public string GetFullAdderss()
        {
            return "\n Road No"+RoadNo +"\n House No"+ HouseNo +"\n Thana"+Thana +"\n District"+District +"\n Post Code"+PostCode;
        }
    }
}
