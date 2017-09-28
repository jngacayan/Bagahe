using System.Threading.Tasks;

namespace Bagahe.Core.Services
{
    public interface ILoginService
    {
        Task<bool> ValidateLogin(string username, string password);
    }
}