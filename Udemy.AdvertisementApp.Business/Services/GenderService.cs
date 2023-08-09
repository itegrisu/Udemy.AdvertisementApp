using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender> , IGenderService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createDto, IValidator<GenderUpdateDto> updateDto, IUow uow) : base(mapper, createDto, updateDto, uow)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
