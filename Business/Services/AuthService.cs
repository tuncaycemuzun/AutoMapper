using Core.Dtos;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class AuthService
    {
        public User Login (LoginDto loginDto)
        {
            var user = ObjectMapper.Mapper.Map<User>(loginDto);
            return user;
        }
    }
}
