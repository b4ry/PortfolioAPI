﻿using AutoMapper;
using PortfolioApplication.Api.DataTransferObjects.Technologies;
using PortfolioApplication.Entities.Entities;

namespace PortfolioApplication.Api.Mappings
{
    /// <summary>
    /// Mapping profile for ProjectType entity
    /// </summary>
    public class ProjectTypeProfile : Profile
    {
        /// <summary>
        /// ProjectTypeProfile constructor configuring mapping profile for ProjectType entity
        /// </summary>
        public ProjectTypeProfile()
        {
            CreateMap<TechnologyEntity, TechnologyDto>().ReverseMap();
        }
    }
}
