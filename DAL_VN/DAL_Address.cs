using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO_VN;

namespace DAL_VN
{
    public class DAL_Address
    {
        private DTO_Address address;
        public DAL_Address(string city, string district, string ward) {
            address = new DTO_Address(city, district, ward);
        }

        public DataTable selectCities()
        {
            string s = "SELECT full_name " +
                       "FROM provinces";
            return Connection.selectQuery(s);
        }

        public DataTable selectDistricts()
        {
            string s = "SELECT d.full_name " +
                       "FROM districts d " +
                       "INNER JOIN provinces p ON p.code = d.province_code " +
                       "WHERE p.full_name = N'" + address.City + "'";
            return Connection.selectQuery(s);
        }

        public DataTable selectWards()
        {
            string s = "SELECT w.full_name " +
                       "FROM wards w " +
                       "INNER JOIN districts d ON w.district_code = d.code " +
                       "WHERE d.full_name = N'" + address.District + "'";
            return Connection.selectQuery(s);
        }
    }
}
