using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.Before;

namespace OpenClosed.Before.Interface
{
    public interface IUserRepository
    {
        void Create(User user);
    }
}
