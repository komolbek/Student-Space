using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlus.DomainModels
{
    [Table("TOKEN")]
    public class Token
    {
        [Key]
        [Column("token_id")]
        public string TokenId { get; set; }

        [Column("value")]
        public string Value { get; set; }

        [Column("expiration_date")]
        public string ExpirationDate { get; set; }

        [Column("user_id")]
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

