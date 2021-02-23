using MediatR;
using Unibet.Challange.Application.Model;

namespace Unibet.Challange.Application.Bowling.Command
{
    public class CalculateBowlingScoreCommand : IRequest<BowlingDto>
    {
    }
}