using EFRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Contracts
{
    public interface IUserContract
    {
        void SaveUser (DomainModel.User user);
        List<DomainModel.User> GetAllUsers ();
        DomainModel.User GetUserByID();
    }
}
