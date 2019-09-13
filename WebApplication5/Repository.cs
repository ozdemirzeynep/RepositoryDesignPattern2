using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Repository : IRepository
    {
        private DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Insert(Blog blog)
        {
            _dataContext.Blogs.Add(blog);
            _dataContext.SaveChanges();
        }

        public void Update(Blog blog)
        {
            _dataContext.Blogs.Update(blog);
            _dataContext.SaveChanges();
        }
    }
}
