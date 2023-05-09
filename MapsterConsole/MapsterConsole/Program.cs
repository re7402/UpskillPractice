using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Mapster;
namespace MapsterConsole
{
    public class SourceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DestinationObject
    {
        public int RollNumber { get; set; }
        public string FullName { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var destination = new DestinationObject();
            var source = new SourceObject { Id = 1, Name = "John Smith" };
            var config = new TypeAdapterConfig();
             config.ForType<SourceObject, DestinationObject>()
                 .Map(dest =>dest.FullName,src=>src.Name);
            Console.WriteLine(destination.FullName);
            //Console.WriteLine(source.Name);
            Console.ReadLine();
//
            // // Test the mapping
            // Console.WriteLine(destination.Id);         // Output: 1
            // Console.WriteLine(destination.FullName);
            // Console.ReadLine();
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<SourceObject, DestinationObject>()
            //        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //        .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name));
            //});

            //var mapper = config.CreateMapper();
            //var person = new SourceObject { FirstName = "John", LastName = "Doe", Age = 30 };
            //var dest = source.Adapt<DestinationObject>(config=>
            //config.Map(dest => dest.Name, src => src.FirstName + " " + src.LastName));
        }
    }
}
