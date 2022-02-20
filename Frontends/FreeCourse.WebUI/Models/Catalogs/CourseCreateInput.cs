using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FreeCourse.WebUI.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Course name")]
        public string Name { get; set; }

        [Display(Name = "Course description")]
        public string Description { get; set; }

        [Display(Name = "Course price")]
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Display(Name = "Course category")]
        public string CategoryId { get; set; }

        [Display(Name = "Course picture")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
