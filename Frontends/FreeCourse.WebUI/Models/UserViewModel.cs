using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.WebUI.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        
        public IEnumerable<string> GetUserProps()
        {
            yield return UserName;
            yield return Email;
        }
    }
}
