﻿using Article.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Repos.Contracts
{
    public interface IArticleRepository
    {

        IEnumerable<Articles> GetArticles();
        Articles GetArticle(int id);
    }
}
