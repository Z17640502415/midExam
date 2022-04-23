using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentMVC.Models
{
    public class Students
    {
        public int Id { get; set; }


        [StringLength(300)]
        [Required]
        [Display(Name = "姓名")]
        public string? Name { get; set; }


        [StringLength(1)]
        [Required]
        [Display(Name = "性别")]
        public string? Sex { get; set; }


        [Range(1, 200)]
        [Display(Name = "年龄")]
        public int Age { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "出生日期")]
        public DateTime ReleaseDate { get; set; }


        [Display(Name = "手机号")]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        [StringLength(13)]
        public string? Phone { get; set; }


        [Range(30, 50)]
        [Display(Name = "体温")]
        public decimal? tempreture { get; set; }


        
        [Display(Name = "填表日期")]
        public DateTime Data { get; set; }
    }
}
