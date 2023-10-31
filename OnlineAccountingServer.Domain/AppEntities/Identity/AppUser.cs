﻿using Microsoft.AspNetCore.Identity;

namespace OnlineAccountingServer.Domain.AppEntities.Identity
{
    public sealed class AppUser : IdentityUser<string>
    {
        public string NameLastName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpires { get; set; }
    }
}
