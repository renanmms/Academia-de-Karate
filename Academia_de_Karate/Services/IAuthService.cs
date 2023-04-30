using Academia_de_Karate.Models;

namespace Academia_de_Karate.Services
{
    public interface IAuthService
    {
        bool Authenticate(LoginInputModel model);
    }
}