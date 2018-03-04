using AutoMapper;
using BLL.Contract.DTOModel;
using DAL.EF;

namespace BLL
{
    public class AutomapperConfig
    {
        public static IMapper InitializeAutomapper()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<objects, ObjectsDTO>();
                cfg.CreateMap<sectors, SectorsDTO>().ForMember(a => a.objectName, o => o.MapFrom(s => s.objects.name));
                cfg.CreateMap<wells, WellsDTO>().ForMember(a => a.sector_name, o => o.MapFrom(s => s.sectors.name));
                cfg.CreateMap<objects, ObjectsDTO>();
                cfg.CreateMap<sectors, SectorsDTO>()
                    .ForMember(a => a.objectName, o => o.MapFrom(s => s.objects.name));
                cfg.CreateMap<wells, WellsDTO>().ForMember(a => a.sector_name, o => o.MapFrom(s => s.sectors.name));              
            });
            return Mapper.Instance;
        }
    }
}
