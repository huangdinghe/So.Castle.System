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
    /// 分类表
    /// </summary>

    //[ActiveRecord("classification")]
    public  class Classification : EntityBase
    {
        [Property("classification_id")]
        public int classification_id { get; set; }

        /// <summary>
        /// 父级功能（外键ParentID的映射）
        /// 用一对一关系实现
        /// </summary>
        [BelongsTo(Type = typeof(Classification), Table = "classification", Column = "parent_id", NotNull = false, Cascade = CascadeEnum.None, Lazy = FetchWhen.OnInvoke)]
        [Required(ErrorMessage = "不能为空")]
        public int parent_id { get; set; }

     
        public string classification_name { get; set; }

    }
}
