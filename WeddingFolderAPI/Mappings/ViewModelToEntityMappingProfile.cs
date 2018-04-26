using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WeddingFolderAPI.Models;
using WeddingFolderAPI.ViewModels;

namespace WeddingFolderAPI.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {

        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
