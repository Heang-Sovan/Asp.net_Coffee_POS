using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_POS.Models
{
    [Table("products")]
    public class Product
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("qty")]
        public int Qty { get; set; }

        [Column("category_id")]
        public long CategoryId { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("image")]
        public string? Image { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public Category Category { get; set; }
    }
}
