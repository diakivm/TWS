using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TWS.BusinessLogicLayer.DTO.Responses;
using TWS.BusinessLogicLayer.Services;
using TWS.Core;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.MVVM.Models;

namespace TWS.MVVM.ViewModels
{
    public class UserViewModel : ObservableObject
    {
        private UserModel model;
        private ObservableCollection<UserResponse> userResponses;


        public UserViewModel(UserModel userModel)
        {
            this.model = userModel;
        }

        public  string CurrentUser { 
            get 
            {
                var user = userResponses.FirstOrDefault(t => t.Id == 1);
                return user.PhoneNumber;
            }
        
        }

    }
}
