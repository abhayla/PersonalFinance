//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities.MutualFunds
{
    using System;
    using System.Collections.Generic;
    
    public partial class MF_Funds
    {
        public MF_Funds()
        {
            this.MF_Transactions = new HashSet<MF_Transactions>();
        }
    
        public int FundId { get; set; }
        public int FundHouseId { get; set; }
        public int FundTypeId { get; set; }
        public int FundClassId { get; set; }
        public int FundOptionId { get; set; }
        public string FundName { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual MF_FundCategory MF_FundCategory { get; set; }
        public virtual MF_FundHouses MF_FundHouses { get; set; }
        public virtual MF_FundOptions MF_FundOptions { get; set; }
        public virtual MF_FundTypes MF_FundTypes { get; set; }
        public virtual ICollection<MF_Transactions> MF_Transactions { get; set; }
    }
}
