using System.Threading.Tasks;
using Unibet.Challange.Application.Common.Interfaces;

namespace Unibet.Challange.Infrastructure.Infrastructure
{
    public class BowlProvider : ICalculateBowl
    {
        public async Task<int> CalculateBowlScore(int[] pins)
        {
            return  300;
        }

        public async Task<bool> IsBowlFinished(int[] pins)
        {
            return true;
        }
    }
}