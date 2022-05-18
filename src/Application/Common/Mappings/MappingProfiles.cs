using Application.Authors;
using Application.Books;
using Application.FileFormats;
using Application.Pages;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Book, BookDTO>();
            
            CreateMap<Page, PageDTO>();

            CreateMap<BookFileFormat, FileFormatDTO>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.FileFormat.Name))
                .ForMember(d => d.Extention, o => o.MapFrom(s => s.FileFormat.Extention));

            CreateMap<BookAuthor, AuthorDTO>()
                .ForMember(d => d.Id, o => o.MapFrom(d => d.Author.Id))
                .ForMember(d => d.FirstName, o => o.MapFrom(d => d.Author.FirstName))
                .ForMember(d => d.MiddleName, o => o.MapFrom(d => d.Author.MiddleName))
                .ForMember(d => d.LastName, o => o.MapFrom(d => d.Author.LastName))
                .ForMember(d => d.Bio, o => o.MapFrom(d => d.Author.Bio));

        }

    }
}
