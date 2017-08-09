using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
   public class UserGroup
    {
        [Key]
        public int GroupID { get; set; }

        [Required(ErrorMessage ="必填")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="字符必须在{1}和{0}之间！")]
        [Display(Name ="名称")]
        public string Name { get; set; }

        [Required(ErrorMessage ="必填")]
        [Display(Name ="用户组类型")]
        public int GroupType { get; set; }

        [Required(ErrorMessage ="必填")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="字符必须小于{0}！")]
        [Display(Name ="说明")]
        public string Description { get; set; }
    }
}
