using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class LoginAlreadyRegisteredException : BadRequestException
    {
        public LoginAlreadyRegisteredException(string login)
            : base($"Já existe um cliente cadastrado com o login: {login}.")
        {
        }
    }
}
