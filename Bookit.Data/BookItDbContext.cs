namespace Bookit.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    using BookIt.Models;

    public class BookItDbContext : IdentityDbContext<AppUser>
    {
        public BookItDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
