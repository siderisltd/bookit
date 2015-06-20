namespace BookIt.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Bookit.Data;
    using BookIt.Web.ViewModels.Home;

    using ViewModelType = BookIt.Web.ViewModels.Categories.CategoryViewModel;

    public class HomeController : BaseController
    {
        public HomeController()
            : this(new BookItData())
        {
        }

        public HomeController(IBookItData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel {
                Categories = this.Data.Categories.All().Select(ViewModelType.ViewModel),
            };

            return this.View(homeViewModel);
        }
    }
}