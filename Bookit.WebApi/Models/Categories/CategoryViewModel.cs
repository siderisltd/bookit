namespace Bookit.WebApi.Models.Categories
{
    using System;
    using System.Linq.Expressions;

    using BookIt.Models;

    public class CategoryViewModel
    {
        public static Expression<Func<Category, CategoryViewModel>> FromModel
        {
            get
            {
                return c => new CategoryViewModel()
                {
                    ID = c.ID,
                    Name = c.Name
                };
            }
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}