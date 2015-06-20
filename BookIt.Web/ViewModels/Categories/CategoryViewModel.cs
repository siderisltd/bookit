namespace BookIt.Web.ViewModels.Categories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using BookIt.Models;

    public class CategoryViewModel
    {
        public static Expression<Func<Category, CategoryViewModel>> ViewModel
        {
            get
            {
                return category => new CategoryViewModel
                {
                    ID = category.ID, 
                    Name = category.Name
                };
            }
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}