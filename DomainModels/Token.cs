using System;
namespace StudentPlus.DomainModels
{
    public class Token
    {
        public string TokenId { get; set; }
        public string Value { get; set; }
        public string ExpirationDate { get; set; }
        public string UserId { get; set; }

        public Token(string tokenId, string value, string expirationDate, string userId)
        {
            TokenId = tokenId;
            Value = value;
            ExpirationDate = expirationDate;
            UserId = userId;
        }

        public string GenerateNewToken(string token)
        {
            return this.Value;
        }        
    }
}

