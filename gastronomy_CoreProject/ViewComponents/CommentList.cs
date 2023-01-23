using EntityLayer.Concrete;
using gastronomy_CoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gastronomy_CoreProject.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Fatih"
                },
                new UserComment
                {
                    ID=2,
                    Username="Murat"
                },
                new UserComment
                {
                    ID=3,
                    Username="Ayşe"
                },
            };
            return View(commentvalues);
        }
    }
}
