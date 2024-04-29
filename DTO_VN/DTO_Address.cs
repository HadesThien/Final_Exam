using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_VN
{
    public class DTO_Address
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public DTO_Address(string city, string district, string ward)
        {
            City = city;
            District = district;
            Ward = ward;
        }
    }
}
