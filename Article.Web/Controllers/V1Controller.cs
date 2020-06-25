using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Data.Model;
using Article.Repos;
using Article.Repos.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace Article.Web.Controllers
{
    [Route("[controller]")]
    public class V1Controller : Controller
    {
        private readonly UnityOfWork unityOfWork;

        public V1Controller(IUnityOfWork uow)
        {
            unityOfWork = uow as UnityOfWork;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Articles> GetArticles()
        {
            var result = unityOfWork.ArticleRepository.GetAll();
            List<Articles> Articles = new List<Articles>();
            if (result != null && result.Count() > 0)
            {
                Articles = result.Select(x => new Articles
                {
                    ArticleId = x.ArticleId,
                    Content = x.Content,
                    CreatedDate = x.CreatedDate,
                    RestorationDate = x.RestorationDate,
                    Statu = x.Statu,
                    Title = x.Title,
                    WriterId = x.WriterId,
                    WriterName = x.WriterName,
                    Comments = x.Comments,
                }).ToList();
            }

            return Articles;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Articles GetArticlesById(int id)
        {
            Articles Article = unityOfWork.ArticleRepository.GetById(id);
            return Article;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Articles Article)
        {
            unityOfWork.ArticleRepository.Add(Article);
        }

        // PUT api/<controller>
        [HttpPut("{id}")]
        public void Put(Articles Article)
        {
            unityOfWork.ArticleRepository.Update(Article);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(Articles Article)
        {
            unityOfWork.ArticleRepository.Delete(Article);
        }
    }
}
