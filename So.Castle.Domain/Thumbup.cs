using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So.Castle.Domain
{
    /// <summary>
    /// 点赞表
    /// </summary>
    
   // [ActiveRecord("thumbup")]
    public class Thumbup:EntityBase
    {
        /// <summary>
        /// 点赞日期
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "点赞日期")]
        public DateTime thumbup_date { get; set; }
    }
}
