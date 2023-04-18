using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class RefreshTokens
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
        public DateTime TokenExpires { get; set; }
        public string AccessToken { get; set; }
        public string Token { get; set; }

        public virtual Users User { get; set; }
    }
}
