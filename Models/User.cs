using System.ComponentModel.DataAnnotations;

namespace RazorPagesLogin.Models
{
	public class User
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Username { get; set; } = string.Empty;
		[Required]
		public string Password { get; set; }
		[Required]
		public string Email { get; set; }
		[DataType(DataType.Date)]
		[Required]
		public DateTime Birthdate { get; set; }
		[Required]
		public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

		public string Question1 { get; set; }

		public string Answer1 { get; set; }
		public  string Question2 { get; set; }

		public string Answer2 { get; set; }
		
		public string Question3 { get; set; }
		public string Answer3 { get; set; }

	}
}
