using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MSSQLStoreAPI.Models
{
    [Table("Category", Schema ="dbo")]
    [Comment("ตารางไว้เก็บรายชื่อหมวดหมู่สินค้า")]
    public class Category
    {
        public int CategoryId { get; set; } // แบบที่หนึ่ง กำหนด Primary key
        
        // [Column("catergoryId")]
        // public int Id { get; set; } // แบบที่สอง PK
        
        // [Key]
        // [Column("catergoryId")]
        // public int CategoryNumber { get; set; } // แบบที่สาม คือ บอกว่าข้างบนว่า คือ อะไร
        [Required] 
        [Column("CategoryName", TypeName = "varchar(64)", Order =1)]
        public string CategoryName { get; set; }

        [Required]
        [Column(Order = 2)]
        public int CategoryStatus { get; set; }

    }
}