using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntSharesUI_Web_.Models
{
    public class Wallet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "钱包名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "钱包密码不能为空")]
        public string Password { get; set; }

        [Required(ErrorMessage = "确认密码不能为空")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "新密码不能为空")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "确认密码不能为空")]
        [Compare("NewPassword", ErrorMessage = "密码和确认密码不匹配。")]
        public string NewConfirmPassword { get; set; }
    }
}
