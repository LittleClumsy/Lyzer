﻿using Lyzer.Common.DTO;
using Lyzer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lyzer.Controllers
{
    [ApiController]
    [Route("/api/v1/drivers")]
    public class DriverController : ControllerBase
    {
        private readonly ILogger<DriverController> _logger;
        private readonly DriverService _driverService;

        public DriverController(ILogger<DriverController> logger, DriverService driverService)
        {
            _logger = logger;
            _driverService = driverService;
        }

        [HttpGet("standings", Name = "Get driver standings")]
        public async Task<ActionResult<DriverStandingsDTO>> GetCurrentDriverStandings()
        {
            return await _driverService.GetCurrentDriverStandings();
        }
    }
}