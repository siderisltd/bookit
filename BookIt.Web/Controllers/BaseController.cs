namespace BookIt.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Bookit.Data;
    using BookIt.Models;

    public class BaseController : Controller
    {
        public BaseController(IBookItData data)
        {
            this.Data = data;
        }

        public BaseController(IBookItData data, AppUser profile)
            : this(data)
        {
            this.AppUser = profile;
        }

        protected IBookItData Data { get; set; }

        protected AppUser AppUser { get; set; }
    }
}