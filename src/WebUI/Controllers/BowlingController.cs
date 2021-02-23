﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Unibet.Challange.Application.Bowling.Command;
using Unibet.Challange.Application.Model;

namespace Unibet.Challange.WebUI.Controllers
{
    public class BowlingController : ApiController
    {
        [HttpPost]
        public async Task<BowlingDto> CalculateBowlingScore(CalculateBowlingScoreCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}