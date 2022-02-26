using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.WebUI.Services.Abstract
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}
