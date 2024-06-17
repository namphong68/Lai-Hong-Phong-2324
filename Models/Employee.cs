using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LHP2324.Models
{
    public class Employee 
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SoDienThoai { get; set; }
    } 
} 