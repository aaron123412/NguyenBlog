using Microsoft.AspNetCore.Http;
using NguyenBlog.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace NguyenBlog.Models.PostViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}
