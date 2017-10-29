﻿using PortfolioApplication.Services.CQRS.Commands;
using PortfolioApplication.Services.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PortfolioApplication.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class DivingGearController : Controller
    {

        private readonly IDivingGearTypeQuery _divingGearTypeQuery;
        private readonly ICommandBus _commandBus;

        public DivingGearController(IDivingGearTypeQuery divingGearTypeQuery, ICommandBus commandBus)
        {
            _divingGearTypeQuery = divingGearTypeQuery;
            _commandBus = commandBus;
        }

        [HttpGet]
        public async Task<IActionResult> GetDivingGearTypes()
        {
            return new JsonResult(await _divingGearTypeQuery.GetDivingGearTypesAsync());
        }
    }
}