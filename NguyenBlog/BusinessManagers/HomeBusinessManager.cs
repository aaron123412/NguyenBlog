using NguyenBlog.Service.Interfaces;
using NguyenBlog.BusinessManagers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NguyenBlog.Models.HomeViewModels;
using System.Linq;
using PagedList.Core;
using NguyenBlog.Data.Models;

namespace NguyenBlog.BusinessManagers
{
    public class HomeBusinessManager : IHomeBusinessManager
    {
        private readonly IPostService postService;
        private readonly IUserService userService;
        private const int PageSize = 20;

        public HomeBusinessManager(IPostService postService, IUserService userService)
        {
            this.postService = postService;
            this.userService = userService;
        }
        public ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page)
        {
            if (authorId is null)
                return new BadRequestResult();

            var applicationUser = userService.Get(authorId);

            if (applicationUser is null)
                return new NotFoundResult();

            int pageSize = PageSize;
            int pageNumber = page ?? 1;

            var posts = postService.GetPosts(searchString ?? string.Empty)
                .Where(post => post.Published && post.Creator == applicationUser);
            return new AuthorViewModel
            {
                Author = applicationUser,
                Posts = new StaticPagedList<Post>(posts.Skip((pageNumber - 1) * pageSize).Take(pageSize), pageNumber, pageSize, posts.Count()),
                SearchString = searchString,
                PageNumber = pageNumber
            };
        }
    }
}
