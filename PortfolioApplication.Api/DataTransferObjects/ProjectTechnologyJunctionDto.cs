﻿using PortfolioApplication.Api.DataTransferObjects.Projects;
using PortfolioApplication.Api.DataTransferObjects.Technologies;

namespace PortfolioApplication.Api.DataTransferObjects
{
    /// <summary>
    /// Data transfer object for ProjectTechnologyJunction entity
    /// </summary>
    public class ProjectTechnologyJunctionDto : BaseDto
    {
        /// <summary>
        /// Project associated to the technology
        /// </summary>
        public ProjectDto Project { get; set; }

        /// <summary>
        /// Technology associated to the project
        /// </summary>
        public TechnologyDto Technology { get; set; }
    }
}
