using AutoMapper;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.CompanyEntities;

namespace OnlineAccountingServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyRequest, Company>().ReverseMap();
            CreateMap<CreateUCAFRequest, UniformChartOfAccount>().ReverseMap();
        }
    }
}
