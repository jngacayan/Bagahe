using System.Threading.Tasks;

namespace Bagahe.Core.Services
{
    public class LoginService : ILoginService
    {

        async Task<bool> ILoginService.ValidateLogin(string username, string password)
        {
            bool isExisting = false;
            
            // temporary code for checking login
            await Task.Delay(2000);
            
            if (username == "admin" && password == "admin")
            {
                isExisting = true;
            }

            return isExisting;
        }

    }
}