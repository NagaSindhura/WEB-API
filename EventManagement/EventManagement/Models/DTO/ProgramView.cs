namespace EventManagement.Models.DTO
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using System.Web.Services.Description;

    public class ProgramView
    {
        [Required]
        public int ProgramID { get; set; }

        [Required(ErrorMessage = "Program Name is Required")]
        [Display(Name = "Program Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Program Product is Required")]
        [Display(Name = "Product Name")]
        public string Product { get; set; }
    }
}