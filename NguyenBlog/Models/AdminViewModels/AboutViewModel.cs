using Microsoft.AspNetCore.Http;
using NguyenBlog.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace NguyenBlog.Models.AdminViewModels
{
    public class AboutViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        [Display(Name = "Sub-header")]
        public string SubHeader { get; set; }
        public string Content { get; set; }
    }
}
