using System.ComponentModel.DataAnnotations;

namespace FreeCourse.WebUI.Models.Catalogs
{
    public class FeatureViewModel
    {
        [Display(Name = "Course time")]
        public int Duration { get; set; }
    }
}
