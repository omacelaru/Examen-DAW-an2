﻿using System.Runtime.CompilerServices;
using AutoMapper;
using Examen.Models.Author;
using Examen.Models.Author.Dto;
using Examen.Models.Author.Dto.WithBooks;
using Examen.Models.Book;
using Examen.Models.BookAuthor;
using Examen.Repositories.AuthorRepository;

namespace Examen.Services.AuthorService
{
    public class AuthorService:IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorResponseDto>> GetAuthors()
        {
            var authors = await _authorRepository.FindAllAuthorsAsync();
            var authorsDto = _mapper.Map<IEnumerable<AuthorResponseDto>>(authors);
            return authorsDto;
        }

        public async Task<AuthorResponseDto> CreateAuthor(AuthorRequestDto author)
        {
            var newAuthor = _mapper.Map<Author>(author);
            await _authorRepository.CreateAsync(newAuthor);
            await _authorRepository.SaveAsync();
            var newAuthorDto = _mapper.Map<AuthorResponseDto>(newAuthor);
            return newAuthorDto;
        }

        public async Task<AuthorWithBooksResponseDto> CreateAuthorWithBooks(AuthorWithBooksRequestDto author)
        {
            var newAuthor = new Author()
            {
                Name = author.Name
            };
            foreach (var book in author.Books)
            {
                
            }
            await _authorRepository.CreateAsync(newAuthor);
            await _authorRepository.SaveAsync();
            var newAuthorDto = _mapper.Map<AuthorWithBooksResponseDto>(newAuthor);
            return newAuthorDto;

        }
    }
}
