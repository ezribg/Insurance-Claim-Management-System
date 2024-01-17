using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMS
{
    public class clsClaimUpdate
    {

        public clsClaimUpdate(int claim_id, String currentStatus, DateTime date_filed, int assigned_id )
        {
            Claim_id = claim_id;
            CurrentStatus = currentStatus;
            Date_filed = date_filed;
            Assigned_id = assigned_id;
            InDatabase = false;
        }

        //local properties of clsClaimUpdate
        public int Claim_id { get; set; }
        public String CurrentStatus { get; set; }
        public DateTime Date_filed { get; set; }
        public int Assigned_id { get; set; }
        public bool InDatabase { get; set; }

        

    }
}
