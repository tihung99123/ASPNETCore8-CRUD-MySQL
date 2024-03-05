using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class SinhVienModel
    {
        [Key]
        public int MaSinhVien { get; set; }
        [Required]
        public string HoVaTen { get; set; }
        [Required]
        public string Lop { get; set; }
        [Required]
        public string Khoa { get; set; }
        [Required]
        public int SoDienThoai { get; set; }
    }
}
