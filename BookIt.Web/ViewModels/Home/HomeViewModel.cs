namespace BookIt.Web.ViewModels.Home
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using BookIt.Web.ViewModels.Categories;

    public class HomeViewModel
    {
        public IQueryable<CategoryViewModel> Categories { get; set; }
    }
}