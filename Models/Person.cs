using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LHP2324.Models
{
    public class Person 
    {
        [Key]
        public string MaID { get; set; }
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
    } 
} 