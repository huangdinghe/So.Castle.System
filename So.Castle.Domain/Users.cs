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
    /// 用户实体
    /// </summary
    [ActiveRecord("Users")]
    public class Users : EntityBase
    {
        /// <summary>
        /// ID
        /// </summary>
        [PrimaryKey(PrimaryKeyType.Identity)]
        [Display(AutoGenerateField = false)]
        public virtual int users_id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "用户名")]
        public virtual string users_name { get; set; }

        /// <summary>
        /// 帐户名
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "帐号")]
        public virtual string account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Display(Name = "密码")]
        public virtual string password { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Property(NotNull = true)]
        [Required]
        [Display(Name = "激活")]
        public virtual bool sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "邮箱")]
        public virtual string email { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "地址")]
        public virtual string address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "电话")]
        public virtual string telephone { get; set; }

        /// <summary>
        /// 当前用户收藏的视频
        /// </summary>
        [HasAndBelongsToMany(typeof(Video),
            Table = "collection",
            ColumnKey = "users_id",
            ColumnRef = "video_id",
            Cascade = ManyRelationCascadeEnum.None,
            Inverse = false,
            Lazy = true)]
        public virtual IList<Video> Video_Collection { get; set; }

        /// <summary>
        /// 当前用户点赞的视频
        /// </summary>
        [HasAndBelongsToMany(typeof(Video),Table = "thumbup",
            ColumnKey = "users_id",
            ColumnRef = "video_id",
            Cascade = ManyRelationCascadeEnum.None,
            Inverse = false,
            Lazy = true)]
        public virtual IList<Video> Video_Thumbup{ get; set; }


    }
}
