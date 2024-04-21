using Automapper.lib.DTOs;
using Automapper.lib.Models;
using AutoMapper;

namespace Automapper.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(des => des.Id, src => src.MapFrom(s => s.BookId))
                .ForMember(des => des.Summary, src => src.MapFrom(s => s.Description))
                .ForMember(des => des.IsFree, src => src.MapFrom(s => s.Price == 0))
                .ReverseMap();

        }
    }
}
