using AutoMapper;
using FluentValidation;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto,ProvidedServiceUpdateDto,ProvidedServiceListDto,ProvidedService>,IProvidedServiceService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public ProvidedServiceService(IMapper mapper, IValidator<ProvidedServiceCreateDto> createDto, IValidator<ProvidedServiceUpdateDto> updateDto, IUow uow) : base(mapper, createDto, updateDto, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }




    }
}
