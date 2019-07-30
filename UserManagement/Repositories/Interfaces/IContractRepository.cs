using System.Collections.Generic;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IContractRepository
    {
        List<Contract> Get();
        Contract Get(int id);
        List<Contract> Get(string value);
        bool Insert(ContractVM contractVM);
        bool Update(int id, ContractVM contractVM);
        bool Delete(int id);
    }
}