using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Dtos
{
    public class TokenReesponseDto
    {
        public TokenReesponseDto(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
