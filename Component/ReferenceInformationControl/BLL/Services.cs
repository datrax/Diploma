using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOModel;
using DAL;
using DAL.EF;

namespace BLL
{
    public class Services
    {
        private IUnitOfWork unitOfWork;
        public Services()
        {
            unitOfWork = new UnitOfWork<ModelContext>();
        }
        public IEnumerable<ObjectsDTO> GetObjects()
        {          
            var config = new MapperConfiguration(cfg => cfg.CreateMap<objects, ObjectsDTO>());
            var mapper = config.CreateMapper();
            return mapper.Map<List<ObjectsDTO>>(unitOfWork.GetRepository<objects>().GetAll().ToList());           
        }
        public IEnumerable<SectorsDTO> GetSectors()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<sectors, SectorsDTO>().ForMember(a=>a.objectName,o=>o.MapFrom(s=>s.objects.name)));
            var mapper = config.CreateMapper();
            return mapper.Map<List<SectorsDTO>>(unitOfWork.GetRepository<sectors>().GetAll().ToList());
        }

        public IEnumerable<WellsDTO> GetWells()
        {    
            var config = new MapperConfiguration(cfg => cfg.CreateMap<wells, WellsDTO>().ForMember(a => a.sector_name, o => o.MapFrom(s => s.sectors.name)));
            var mapper = config.CreateMapper();
            return mapper.Map<List<WellsDTO>>(unitOfWork.GetRepository<wells>().GetAll().ToList());
        }

        public static string GetItemAsString(object rowObject)
        {

            if (rowObject is WellsDTO)
             return   (rowObject as WellsDTO).ToString();

            if (rowObject is SectorsDTO)
                return (rowObject as SectorsDTO).ToString();

            if (rowObject is ObjectsDTO)
                return (rowObject as ObjectsDTO).ToString();
            return "";
        }
    }
}
