using System.Threading.Tasks;

namespace Unibet.Challange.Application.Common.Interfaces
{
    public interface ICalculateBowl
    {
       Task<(int, bool)> CalculateBowlScore(int[] rolls);
    }
}