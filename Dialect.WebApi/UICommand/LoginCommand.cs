using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dialect.WebApi.UICommand
{
    public class LoginCommand
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }


}