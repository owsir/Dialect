using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dialect.Web.ViewModels;

namespace Dialect.Web.Controllers
{
    public class BaseController : Controller
    {
        protected UserViewModel LoginUser => Session["user"] as UserViewModel;
    }
}