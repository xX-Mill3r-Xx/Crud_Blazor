using System.ComponentModel.DataAnnotations;

namespace CompanyCrud_Blazor.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(13)]
        public string Phone { get; set; }

        public void GenereteNewId()
        {
            Id = Guid.NewGuid();
        }
    }
}
