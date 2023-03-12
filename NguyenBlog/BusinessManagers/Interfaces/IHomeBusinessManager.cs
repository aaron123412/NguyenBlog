using Microsoft.AspNetCore.Mvc;
using NguyenBlog.Models.HomeViewModels;

namespace NguyenBlog.BusinessManagers.Interfaces
{
    public interface IHomeBusinessManager
    {
        ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page);
    }
}
