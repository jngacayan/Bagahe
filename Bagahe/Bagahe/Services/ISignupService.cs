using Bagahe.Core.Models;
using System.Threading.Tasks;

namespace Bagahe.Core.Services
{
    public interface ISignupService
    {
        Task<bool> AddNewUser(SignupFields SignupField);
    }
}
