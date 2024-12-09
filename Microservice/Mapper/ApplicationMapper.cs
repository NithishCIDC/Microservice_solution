using AutoMapper;
using Microservice.Domain.DTO;
using Microservice.Domain.Modal;

namespace Microservice.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<CustomerDTO,Customer>();
        }
    }
}
