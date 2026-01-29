using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages
{
    public class CreateItemModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Please enter a name")]
            [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please select a job title")]
            public string Job { get; set; }

            [Required(ErrorMessage = "Please pick a favorite color")]
            public string FavoriteColor { get; set; }

            [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
            public int? Age { get; set; }

            public bool IsActive { get; set; }

            [DataType(DataType.EmailAddress)]
            [EmailAddress(ErrorMessage = "Invalid email formatting")]
            public string Email { get; set; }

            [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
            public string Notes { get; set; }
        }

        public string[] Jobs = { "Quality Control Specialist", "Desktop Support Technician", "Tax Accountant", "Software Engineer", "Project Manager" };
        public string[] Colors = { "Red", "Blue", "Green", "Purple", "Yellow", "Orange" };

        public void OnGet()
        {
            Input = new InputModel { IsActive = true };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Please correct the errors in the form.";
                return Page();
            }

            // Mock saving to database
            TempData["SuccessMessage"] = $"Item '{Input.Name}' has been created successfully!";
            
            return RedirectToPage("/Items");
        }
    }
}
