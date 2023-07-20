using Microsoft.AspNetCore.Mvc;

namespace ScoreAPI.Models
{
    public class User
    {
        [FromBody]
        public string Name { get; set; }
    }
}