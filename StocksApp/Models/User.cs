using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class User
    {
        private int id {  get; set; }
        [Required]
        private string? FirstName { get; set; }
        [Required]
        private string? LastName { get; set; }
        [Required]
        private Portfolio userPortfolio { get; set; } = new Portfolio();
        [Required]
        private Account account { get; set; } = new Account();

    }
}
