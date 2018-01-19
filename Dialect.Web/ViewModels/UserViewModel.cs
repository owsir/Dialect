using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dialect.Model;

namespace Dialect.Web.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public Forum Forum { get; set; }
    }
}