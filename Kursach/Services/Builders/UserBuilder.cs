using ClassLibraryEF;
using Kursach.Models;

namespace Kursach.Services.Builders
{
    public class UserBuilder
    {
        public User Build(UserViewModel viewModel) {
            return new User {
                Email = viewModel.Email,
                Firstname = viewModel.Firstname,
                Lastname = viewModel.Lastname,
                Login = viewModel.Login,
                Pasword = viewModel.Pasword
            };
        }
    }
}