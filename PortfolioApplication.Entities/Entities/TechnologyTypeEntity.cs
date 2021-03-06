﻿using PortfolioApplication.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioApplication.Entities.Entities
{
    [Table("TechnologyTypes")]
    public class TechnologyTypeEntity : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public TechnologyTypeEnum TechnologyTypeEnum { get; set; }
    }
}
