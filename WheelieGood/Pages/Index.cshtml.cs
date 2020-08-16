using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WheelieGood.Core;
using WheelieGood.Data;

namespace WheelieGood.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IArticleData _articleData;
        public IndexModel(ILogger<IndexModel> logger, IArticleData data)
        {
            _logger = logger;
            _articleData = data;
        }
        public List<Article> Articles { get; set; }
        public void OnGet()
        {
            Articles = _articleData.GetArticles(3).ToList();
        }
    }
}
