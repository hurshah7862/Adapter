using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile() {
            CreateMap<BusinessLogic.Models.User, DataAccess.Models.User>().ReverseMap();
        }
    }
}
