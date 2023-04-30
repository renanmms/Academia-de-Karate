using Academia_de_Karate.Models;

namespace Academia_de_Karate.Services
{
    public class AuthService : IAuthService
    {
        public bool Authenticate(LoginInputModel model)
        {
            return (model.Login == "admin" && model.Senha == "admin") ? true : false;
        }
    }
}