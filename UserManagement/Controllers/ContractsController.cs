using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.Repositories;
using UserManagement.Repositories.Interfaces;
using UserManagement.ViewModels;

namespace UserManagement.Controllers
{
    public class ContractsController
    {
        public IContractRepository iContractRepository = new ContractRepository();

        public List<Contract> Get()
        {
            return iContractRepository.Get();
        }

        public Contract Get(int id)
        {
            return iContractRepository.Get(id);
        }

        public List<Contract> Get(string value)
        {
            return iContractRepository.Get(value);
        }

        public bool Insert(ContractVM contractVM)
        {
            return iContractRepository.Insert(contractVM);
        }

        public bool Update(int id, ContractVM contractVM)
        {
            return iContractRepository.Update(id, contractVM);
        }

        public bool Delete(int id)
        {
            return iContractRepository.Delete(id);
        }
    }
}
