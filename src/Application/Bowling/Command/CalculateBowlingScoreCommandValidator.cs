using FluentValidation;

namespace Unibet.Challange.Application.Bowling.Command
{
    public class CalculateBowlingScoreCommandValidator : AbstractValidator<CalculateBowlingScoreCommand>
    {
        public CalculateBowlingScoreCommandValidator()
        {
            RuleFor(v => v.Scores).NotEmpty();
        }
    }
}