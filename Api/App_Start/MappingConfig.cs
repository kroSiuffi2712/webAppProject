using AutoMapper;

namespace Api.App_Start
{
    public static class MappingConfig
    {
        public static IMapper Mapper { get; set; }

        public static void RegisterMappings()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new AutoMapping());
            });
            Mapper = mappingConfig.CreateMapper();
        }
    }
}