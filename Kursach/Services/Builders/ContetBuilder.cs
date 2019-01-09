using ClassLibraryEF;
using Kursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach.Services.Builders
{
    public class ContetBuilder
    {
        public ContentTable CBuilder(ContentViewModel Content)
        {
            return new ContentTable
            {
                ImagePath = Content.ImagePath,
                FullDetail = Content.FullDetail,
                SportDetail = Content.SportDetail,
                Title = Content.Title,
                IdSport = Content.IdSport,         
            };
        }
    }
}