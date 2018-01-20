namespace EmployeesSystem.App
{
    using EmployeesSystem.App.Core;
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Data;
    using EmployeesSystem.Services;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using AutoMapper;
    using EmployeesSystem.Dtos;
    using EmployeesSystem.Models;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new EmployeesDbContext())
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();
                InitializeAutomapper();
                IServiceProvider serviceProvider = ConfigureServices();
                IEngine engine = new Engine(serviceProvider);
                engine.Run();
            }            
        }

        private static IServiceProvider ConfigureServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeesDbContext>(options =>
                options.UseSqlServer(ServerConfig.ConnectionString));

            serviceCollection.AddTransient<IEmployeeService, EmployeeService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }


        private static void InitializeAutomapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<EmployeeDto, Employee>();
                cfg.CreateMap<Employee, EmployeePersonalInfoDto>();
                cfg.CreateMap<Employee, ManagerDto>()
                    .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.ManagedEmployees));
                cfg.CreateMap<Employee, EmployeeByBirthdayDto>();
            });
        }
    }
}
