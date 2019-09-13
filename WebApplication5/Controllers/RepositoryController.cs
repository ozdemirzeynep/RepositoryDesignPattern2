using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class RepositoryController : Controller
    {
        private IRepository _repository;
        public RepositoryController(IRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Update([FromBody] Blog blog)
        {
            _repository.Update(blog);
            return new JsonResult(blog);
        }

        public JsonResult Insert([FromQuery] string url)
        {
            Blog blog = new Blog() { Url=url};
            _repository.Insert(blog);
            return new JsonResult(blog);
        }
    }
}