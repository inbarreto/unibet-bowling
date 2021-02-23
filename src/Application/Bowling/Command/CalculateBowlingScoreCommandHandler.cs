using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Unibet.Challange.Application.Model;

namespace Unibet.Challange.Application.Bowling.Command
{
    public class CalculateBowlingScoreCommandHandler : IRequestHandler<CalculateBowlingScoreCommand, BowlingDto>
    {
        public Task<BowlingDto> Handle(CalculateBowlingScoreCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}