using GetAHomeApi.Models;
using GetAHomeApi.ViewModels.ResidenceType;

namespace GetAHomeApi.Helpers;

public class AutoMapperProfiles : AutoMapper.Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<ResidenceType, ResidenceTypeViewModel>();
        CreateMap<PostResidenceTypeViewModel, ResidenceType>();
        CreateMap<UpdateResidenceTypeViewModel, ResidenceType>();
    }
}
