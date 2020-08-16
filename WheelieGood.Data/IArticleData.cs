using WheelieGood.Core;
using System.Collections.Generic;

namespace WheelieGood.Data
{
    public interface IArticleData
    {
        IEnumerable<Article> GetArticles(int count);
        Article GetById(int id);
        Article Update(Article bike);
        Article Add(Article newArticle);
        Article Delete(int id);
        int Commit();
        int GetCount();
    }
}
