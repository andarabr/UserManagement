using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Contract : BaseModel
    {
        public Contract() { }
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StatusContract { get; set; }
        public Employee Employee { get; set; }

        public Contract(ContractVM ContractVM)
        {
            this.JoinDate = ContractVM.JoinDate;
            this.EndDate = ContractVM.EndDate;
            this.StatusContract = ContractVM.StatusContract;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(ContractVM ContractVM)
        {
            this.JoinDate = ContractVM.JoinDate;
            this.EndDate = ContractVM.EndDate;
            this.StatusContract = ContractVM.StatusContract;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }
    }
}
