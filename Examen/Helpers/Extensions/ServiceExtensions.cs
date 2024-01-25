using Examen.Repositories.AuthorRepository;
using Examen.Repositories.BookRepository;
using Examen.Repositories.PublishingHouseRepository;
using Examen.Services.AuthorService;
using Examen.Services.BookService;
using Examen.Services.PublishingHouseService;

namespace Examen.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IPublishingHouseRepository, PublishingHouseRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IPublishingHouseService, PublishingHouseService>();
            return services;
        }
    }
}
