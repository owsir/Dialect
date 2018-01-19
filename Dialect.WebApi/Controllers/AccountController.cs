using System;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;
using Dialect.ILogic;
using Dialect.Infrustructure;
using Dialect.Model;
using Dialect.WebApi.UICommand;

namespace FFCG.VisitorLog.WebAPI.Controllers.Account
{
    public class AccountController : ApiController
    {
        private readonly IUserLogic _userLogic;

        public AccountController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [Route("api/v1/account/login")]
        [HttpPost]
        public UserModel Login(LoginCommand loginCommand)
        {
            return new UserModel
            {
                Id = 1,
                Email = "Peking",
                Name= "AAAAABBBB",
                Password = "22222"
            };
            //return LoginUser(loginCommand);
        }

        [Route("api/v1/account/logout")]
        [HttpGet]
        public void Logout([FromUri]string token)
        {
            CacheManager.Remove(token);
        }

        //[Route("api/account/resetPassword")]
        //[HttpPost]
        //public void ResetPassword(ResetPasswordUserModel resetPasswordUser)
        //{
        //    _userLogic.ResetPassword(resetPasswordUser.Name, resetPasswordUser.OldPassword, resetPasswordUser.NewPassword);
        //}

        //[Route("api/account/checkUserIsValid")]
        //[HttpPost]
        //public bool CheckUserIsValid(UserModel user)
        //{
        //    return _userLogic.CheckValidUser(user.Name, user.Password);
        //}

        //[Route("api/account/resetPasswordByEmail")]
        //[HttpPost]
        //public void ResetPasswordByEmail(ResetPasswordUserModel resetPasswordUser)
        //{
        //    _userLogic.ResetPasswordByEmail(resetPasswordUser.Name, resetPasswordUser.OldPassword, resetPasswordUser.NewPassword);
        //}

        //[Route("api/account/sendForgetPasswordEmail")]
        //[HttpGet]
        //public void SendForgetPasswordEmail(string email)
        //{
        //    _userLogic.SendForgetPasswordEmail(email);
        //}

    }
}
