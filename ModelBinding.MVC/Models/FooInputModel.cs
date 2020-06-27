using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.MVC.Models
{
	[Bind(nameof(FirstName), nameof(LastName), nameof(FullName), nameof(Email))]
	public class FooInputModel
	{

		[Required]
		[Display(Name = "First Name")]
		[StringLength(50, MinimumLength = 5)]
		public string FirstName { get; set; }


		[Required]
		[Display(Name = "Last Name")]
		[StringLength(50, MinimumLength = 5, ErrorMessage = "{0} must have at least {2} characters")]
		public string LastName { get; set; }


		[Required(ErrorMessage = "{0} is required")]
		[StringLength(100, MinimumLength = 10, ErrorMessage = "{0} must have at least {2} characters")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please, use letters in the name. Digits are not allowed.")]
		[Display(Name = "Full Name")]
		public string FullName { get; set; }


		[Required(ErrorMessage = "{0} is required")]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
		public string Email { get; set; }


		// ignored (value will be null after model binding)
		public string Bar { get; set; }
	}
}
