using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS {
    internal class BUS_Payment {
        DAL_Payment payment;


        public BUS_Payment(string paymentId, DateTime dateCreated, DateTime period, string status , string note, float promotion, int n_session, string studentId) {
            payment = new DAL_Payment(paymentId,dateCreated,period,status,note ,promotion,n_session,studentId);
        }

    }
}
