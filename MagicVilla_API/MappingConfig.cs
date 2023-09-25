using AutoMapper;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // Se indica la fuente y el destino
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            // Es lo mismo que lo que está arriba, pero en una sola línea
            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();
        }
    }
}
