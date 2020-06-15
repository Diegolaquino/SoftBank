using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftBankSPAapi.Models
{
    public interface IUser
    {
        string UserName { get; set; }

        string Role { get; set; }

        string Password { get; set; }

    }
}
