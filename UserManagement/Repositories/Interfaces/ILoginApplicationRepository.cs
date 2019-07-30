using System.Collections.Generic;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface ILoginApplicationRepository
    {
        List<LoginApplication> Get();
        LoginApplication Get(int id);
        List<LoginApplication> Get(string value);
        bool Insert(LoginApplicationVM loginApplicationVM);
        bool Update(int id, LoginApplicationVM loginApplicationVM);
        bool Delete(int id);
    }
}