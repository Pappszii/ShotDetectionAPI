using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ShotDetectionAPI.Services
{
    interface IJWTTokenGenerator
    {
        string GenerateToken(IdentityUser user);
    }
}
