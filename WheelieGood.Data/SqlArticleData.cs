using System.Collections.Generic;
using System.Linq;
using WheelieGood.Core;

namespace WheelieGood.Data
{
    public class SqlArticleData : IArticleData
    {
        private readonly WheelieGoodDbContext db;
        public SqlArticleData(WheelieGoodDbContext db)
        {
            this.db = db;
        }

        public Article Add(Article newArticle)
        {
            db.Add(newArticle);
            return newArticle;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Article Delete(int id)
        {
            var article = GetById(id);
            if (article != null)
            {
                db.Articles.Remove(article);
            }
            return article;
        }

        public IEnumerable<Article> GetArticles(int count)
        {
            return db.Articles.Take(count)
        }

        public Article GetById(int id)
        {
            return db.Articles.Where(a => a.Id == id).FirstOrDefault();
        }

        public int GetCount()
        {
            return db.Articles.Count();
        }

        public Article Update(Article article)
        {
            var entity = db.Articles.Attach(article);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return article;
        }
    }
}
