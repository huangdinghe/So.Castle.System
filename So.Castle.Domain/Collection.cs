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
    /// 收藏表
    /// </summary>

   // [ActiveRecord("collection")]
    public class Collection : EntityBase
    {
        /// <summary>
        /// 收藏日期
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "收藏日期")]
        public DateTime collection_date { get; set; }
    }
}
