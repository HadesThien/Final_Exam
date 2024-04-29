using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_VN;

namespace BUS_VN
{
    public class BUS_Address
    {
        private DAL_Address address;

        public BUS_Address(string city, string district, string ward)
        {
            address = new DAL_Address(city, district, ward);
        }

        public DataTable selectCities()
        {
            return address.selectCities();
        }

        public DataTable selectDistricts()
        {
            return address.selectDistricts();
        }

        public DataTable selectWards()
        {
            return address.selectWards();
        }
    }
}
