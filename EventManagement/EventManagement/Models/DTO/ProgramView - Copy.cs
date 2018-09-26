namespace EventManagement.Models.DTO
{
    using System.ComponentModel.DataAnnotations;

    public class ProgramView
    {
        public int ProgramID { get; set; }

        [Required(ErrorMessage = "Program Name is Required")]
        [Display(Name = "Program Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Program Product is Required")]
        [Display(Name = "Product Name")]
        public string Product { get; set; }
    }
}