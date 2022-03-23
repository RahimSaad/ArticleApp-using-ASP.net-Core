using ArticlesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ArticlesApp.Models;
namespace ArticlesApp.BL
{
    public class CLSArticle
    {
        public List<Article> GetAll()
        {
            ArticlesContext acx = new ArticlesContext();
            return acx.tbArticle.OrderByDescending(a => a.articleId).ToList();
        }

        public bool Add(Article article)
        {
            try
            {
                ArticlesContext acx = new ArticlesContext();
                acx.Add<Article>(article);
                acx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
