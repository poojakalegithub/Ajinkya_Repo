using DapperCRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Domain.Interfaces
{
    public interface IAuthanticationRepository
    {
        public User Get(UserLogin userLogin);
        
    }
}
