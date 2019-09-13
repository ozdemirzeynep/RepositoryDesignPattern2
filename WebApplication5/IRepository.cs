using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public interface IRepository
    {
       
        void Insert(Blog blog);
        void Update(Blog blog);
    }
}
