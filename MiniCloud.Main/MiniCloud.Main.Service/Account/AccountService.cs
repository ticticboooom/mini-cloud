using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MiniCloud.Main.DataAccess.Repository.User;
using MiniCloud.Main.Helpers.Exceptions;
using MiniCloud.Main.Helpers.Password;
using MiniCloud.Main.Helpers.TokenHelper;
using MiniCloud.Main.Service.Account.Model;

namespace MiniCloud.Main.Service.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITokenHelper _tokenHelper;

        public AccountService(IAccountRepository accountRepository, ITokenHelper tokenHelper)
        {
            _accountRepository = accountRepository;
            _tokenHelper = tokenHelper;
        }

        public async Task Register(RegisterModel model)
        {
            await _accountRepository.CreateAccount(new DataAccess.Model.Account()
            {
                EmailAddress = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PasswordHash = PasswordHelper.HashPassword(model.Password),
            });
        }

        public async Task<string> Login(LoginModel model)
        {
            var user = await _accountRepository.GetUserByEmail(model.Email);
            if (user == null)
            {
                throw new ApiErrorException(HttpStatusCode.BadRequest, "Invalid Login details");
            }

            if (!PasswordHelper.VerifyPassword(user.PasswordHash, model.Password))
            {
                throw new ApiErrorException(HttpStatusCode.BadRequest, "Invalid Login details");
            }

            return _tokenHelper.Generate(new Dictionary<string, object>()
            {
                {"accId", user.Id},
            });
        }
    }
}
