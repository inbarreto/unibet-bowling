using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unibet.Challange.Application.Bowling.Command;
using Unibet.Challange.Application.Common.Interfaces;
using Xunit;

namespace Application.UnitTest.Command
{
    public class CalculateBowlingScoreCommandTest
    {
        private readonly ICalculateBowl _calculateBowl;

        public CalculateBowlingScoreCommandTest(ICalculateBowl calculateBowl)
        {
            _calculateBowl = calculateBowl;
        }

        public static IEnumerable<object[]> RollsData
        {
            get
            {
                return new[]
                {
                new object[] { new int[] {10,10,10,10,10,10,10,10,10,10,10,10}, true,300 },
                new object[] { new int[] {1,1,1,1,1,1,1,1,1,1,1,1 }, false,12 },
                new object[] { new int[] { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,9,1}, true,29 }
            };
            }
        }

        [Theory, MemberData(nameof(RollsData))]
        public async Task CalculateBowlingScore(int[] rolls, bool isFrameComplete, int totalScore)
        {
            var handler = new CalculateBowlingScoreCommandHandler(_calculateBowl);

            var result = await handler.Handle(new CalculateBowlingScoreCommand() { Scores = rolls }, new CancellationToken());

            Assert.Equal(totalScore, result.Score);
            Assert.Equal(isFrameComplete, result.FrameCompleted);
        }
    }
}