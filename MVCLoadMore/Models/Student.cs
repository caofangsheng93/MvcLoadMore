using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLoadMore.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "请输入姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请填写年龄")]
        public int Age { get; set; }

        [Required(ErrorMessage = "请填写Email")]
        public string Email { get; set; }
    }
}