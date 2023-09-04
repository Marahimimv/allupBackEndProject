using System.ComponentModel.DataAnnotations;

namespace allupBackEndProject.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        [StringLength(255)]
        public string? Image { get; set; }
        public bool IsMain { get; set; }
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }

    }
}
