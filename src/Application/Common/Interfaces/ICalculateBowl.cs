using System.Threading.Tasks;

namespace Unibet.Challange.Application.Common.Interfaces
{
    public interface ICalculateBowl
    {
        Task<int> CalculateBowlScore(int[] pins);

        Task<bool> IsBowlFinished(int[] pins);
    }
}