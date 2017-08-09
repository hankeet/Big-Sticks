using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
   public class UserConfig
    {
        [Key]
        public int ConfigID { get; set; }

        [Display(Name ="启用注册")]
        [Required(ErrorMessage ="必填")]
        public bool Enabled { get; set; }

        [Display(Name ="禁止使用的用户名")]
        public string ProhibiUserName { get; set; }

        [Display(Name ="启用邮件验证")]
        [Required(ErrorMessage ="必填")]
        public int DefaultGroupID { get; set; }

    }
}
