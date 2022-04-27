using Microsoft.AspNetCore.Mvc;
using Shopping.Helpers;

namespace Shopping.Controllers
{
    public class AccountController :Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper )
        {
            _userHelper = userHelper;
        }


    }
}
