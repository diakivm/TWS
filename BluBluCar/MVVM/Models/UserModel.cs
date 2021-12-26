using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Interfaces.Services;

namespace TWS.MVVM.Models
{
    public class UserModel 
    {
        private IUserService userService;
             
        public UserModel(IUserService userService)
        {
            this.userService = userService;
        }

        public UserResponse GetCurrentUser()
        {
            return userService.GetByIdAsync(1).Result;
        }

        public Task<IEnumerable<UserResponse>> GetAllUser()
        {
            return userService.GetAsync();
        }
    }
}
