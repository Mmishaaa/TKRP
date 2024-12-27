﻿using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class TennisCourtService : GenericService<TennisCourtModel, TennisCourtEntity>, ITennisCourtService
    {
        public TennisCourtService(ITennisCourtRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}