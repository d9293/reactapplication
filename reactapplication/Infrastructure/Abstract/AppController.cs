using reactapplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace reactapplication.Controllers
{
    public abstract class AppController : Controller
    {
        public AppUserPrincipal CurrentUser
        {
            get
            {
                return new AppUserPrincipal(this.User as ClaimsPrincipal);
            }
        }
    }
}