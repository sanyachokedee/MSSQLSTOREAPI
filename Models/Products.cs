using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MSSQLStoreAPI.Models
{
    [Table("Products", Schema = "dbo")]
    [Comment("ตารางไว้เก็บข้อมูลสินค้า")]
    public class Products
    {
        [Key]        
        public int ProductID { get; set; }

        [Required]
        [Column(TypeName = "varchar(64)", Order = 1)]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)", Order = 2)]
        public decimal UnitPrice { get; set; }

        [Required]
        [Column(Order = 3)]
        public int UnitInStock { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)", Order = 4)]
        public string ProductPicture { get; set; }  // ใส่ path ของรูปเข้าไป ไม่ได้โหลดไฟล์ตรง

        [Column(Order = 5)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        // ใ

        [Column(Order = 6)]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        [ForeignKey("CategoryInfo")] // กำหนดชื่อเรียกอะไรก็ได้ 
        public int CategoryId { get; set; }
        public virtual Category CategoryInfo { get; set;}  
        // หมายถึง เสมือนให้ตาราง Category กับ CategoryInfo

        // ผลการ Join เราอยากให้มาแสดงใน Table Products แต่เราไม่ต้องการให้สร้าง field เข้าไปจะซ้ำซ้อน
        // NotMapped คือ ไม่ต้องสร้าง ไม่มีข้อมูล ทำแค่สร้างโครงการต้องสร้าง Join 
        // สามารถนำไปใช้เพื่อลบข้อมูล ถ้าจะลบไม่ได้ ต้องมีก่อน คล้าย Trigger
        [NotMapped]
         public string CategoryName { get; set; }
    }
}