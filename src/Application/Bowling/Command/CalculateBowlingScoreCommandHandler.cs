using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Unibet.Challange.Application.Common.Interfaces;
using Unibet.Challange.Application.Model;

namespace Unibet.Challange.Application.Bowling.Command
{
    public class CalculateBowlingScoreCommandHandler : IRequestHandler<CalculateBowlingScoreCommand, BowlingDto>
    {
        private readonly ICalculateBowl _calculateBowl;

        public CalculateBowlingScoreCommandHandler(ICalculateBowl calculateBowl)
        {
            _calculateBowl = calculateBowl;
        }

        public async Task<BowlingDto> Handle(CalculateBowlingScoreCommand request, CancellationToken cancellationToken)
        {
            (int, bool) result = await _calculateBowl.CalculateBowlScore(request.Scores);
            return  new BowlingDto() { Score = result.Item1, FrameCompleted = result.Item2 };
        }
    }
}