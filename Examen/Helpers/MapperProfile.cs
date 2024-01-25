using AutoMapper;
using Examen.Models.Author;
using Examen.Models.Author.Dto;
using Examen.Models.Author.Dto.WithBooks;
using Examen.Models.Book;
using Examen.Models.Book.Dto;
using Examen.Models.BookAuthor;
using Examen.Models.PublishingHouse;
using Examen.Models.PublishingHouse.Dto;

namespace Examen.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();

            CreateMap<Book, BookResponseDto>();
            CreateMap<BookRequestDto, Book>();

            CreateMap<Author, AuthorResponseDto>();
            CreateMap<AuthorRequestDto, Author>();

            CreateMap<PublishingHouse, PublishingHouseResponseDto>();
            CreateMap<PublishingHouseRequestDto, PublishingHouse>();

            CreateMap<AuthorWithBooksRequestDto, Author>();
            CreateMap<Author, AuthorWithBooksResponseDto>();
        }
    }
}