namespace PhotoShare.Client
{
    using System;
    using Core;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Services;
    using PhotoShare.Services.Contracts;

    public class Application
    {
        public static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();

            CommandDispatcher commandDispatcher = new CommandDispatcher();
            Engine engine = new Engine(commandDispatcher, serviceProvider);
            engine.Run();
            //ResetDatabase();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<PhotoShareContext>(options =>
                options.UseSqlServer(ServerConfig.ConnectionString));

            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ITownService, TownService>();
            serviceCollection.AddTransient<ITagService, TagService>();
            serviceCollection.AddTransient<IAlbumService, AlbumService>();
            serviceCollection.AddTransient<IFriendService, FriendService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }

        private static void ResetDatabase()
        {
            using (var db = new PhotoShareContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}
