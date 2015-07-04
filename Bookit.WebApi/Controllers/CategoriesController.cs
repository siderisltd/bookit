namespace Bookit.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Description;

    using BookIt.Models;
    using Bookit.Data;
    using Bookit.WebApi.Models.Categories;

    public class CategoriesController : BaseController
    {
        public CategoriesController()
            : base(new BookItData())
        {
        }

        public CategoriesController(IBookItData data)
            : base(data)
        {
        }

        // GET: api/Categories
        [HttpGet]
        public IEnumerable<CategoryViewModel> All()
        {
            var list = this.Data.Categories.All()
                .Select(CategoryViewModel.FromModel);

            return list;
        }

        // GET: api/Categories/5
        [ResponseType(typeof(CategoryViewModel))]
        public IHttpActionResult Get(int id)
        {
            Category category = this.Data.Categories.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // PUT: api/Categories/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutCategory(int id, Category category)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != category.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(category).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CategoryExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Categories
        [ResponseType(typeof(CategoryViewModel))]
        public IHttpActionResult Post(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = new Category()
            {
                ID = model.ID,
                Name = model.Name
            };

            this.Data.Categories.Add(category);
            this.Data.SaveChanges();

            return this.Get(category.ID);
        }

        // DELETE: api/Categories/5
        //[ResponseType(typeof(Category))]
        //public IHttpActionResult DeleteCategory(int id)
        //{
        //    Category category = db.Categories.Find(id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Categories.Remove(category);
        //    db.SaveChanges();

        //    return Ok(category);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool CategoryExists(int id)
        //{
        //    return db.Categories.Count(e => e.ID == id) > 0;
        //}
    }
}