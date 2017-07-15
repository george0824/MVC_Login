using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Login.ViewModel
{
    public class Login
    {
        [DisplayName("帳號")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote("CheckLogin", "Validate", ErrorMessage = "帳號 欄位 不可含有以下字串(skilltree,demo,twMVC)")]
        [RegularExpression(@"\w.+\@\w.+", ErrorMessage = "帳號 欄位 不是正確的eMail格式")]
        public string LOGIN_ID { get; set; }

        [DisplayName("密碼")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4)]
        public string PASSWORD { get; set; }
    }
}