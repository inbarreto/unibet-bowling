using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unibet.Challange.Application.Common.Interfaces;

namespace Unibet.Challange.Infrastructure.Infrastructure
{
    public class BowlingProvider : ICalculateBowl
    {
        private List<int> RollsScore { get; set; } = new List<int>();

        /// <summary>
        /// Calculates the bowl score and if the game is complete
        /// </summary>
        /// <param name="rolls">The rolls.</param>
        /// <returns></returns>
        public async Task<(int, bool)> CalculateBowlScore(int[] rolls)
        {
            CalculateScores(rolls);
            return await Task.Run(() =>

            (RollsScore.Sum(), RollsScore.Count == 10));
        }

        private void CalculateScores(int[] rolls)
        {
            for (int i = 0; i + 1 < rolls.Count(); i += 2)
            {
                // Neither strike or spare
                if (rolls[i] + rolls[i + 1] < 10)
                {
                    RollsScore.Add(rolls[i] + rolls[i + 1]);
                    continue;
                }

                // Score can only be determined if third roll is available
                if (i + 2 >= rolls.Count()) break;

                RollsScore.Add(rolls[i] + rolls[i + 1] + rolls[i + 2]);

                // In case of strike, advance only by one
                if (rolls[i] == 10)
                    i--;
            }
        }
    }
}