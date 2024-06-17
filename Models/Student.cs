using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LHP2324.Models
{
    public class Student
    {
        [Key]
        public string MaSV { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
    } 
} 