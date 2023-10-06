using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StocksApp.Models
{
    public class User
    {
        public int Id {  get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int? PortfolioId { get; set; }
        public Portfolio? userPortfolio { get; set; }


    }


}
