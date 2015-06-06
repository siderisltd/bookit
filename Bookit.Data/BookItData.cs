namespace Bookit.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookItData : IBookItData
    {
        private IBookItDbContext context;

        public BookItData()
            : this(new BookItDbContext()) 
        { 
        }

        public BookItData(IBookItDbContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
