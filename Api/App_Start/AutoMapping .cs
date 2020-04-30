using Api.Models;
using AutoMapper;
using Data.Dto;

namespace Api.App_Start
{
    public class AutoMapping : Profile
    {

        public AutoMapping()
        {
            CreateMap<Section, SectionViewModel>();
            CreateMap<SectionViewModel, Section>();

            CreateMap<Content, ContentViewModel>()
           .ForMember(o => o.Section, m => m.MapFrom(s => s.Section));

            CreateMap<ContentViewModel, Content>()
           .ForMember(o => o.Section, m => m.MapFrom(s => s.Section));


        }
    }
}

