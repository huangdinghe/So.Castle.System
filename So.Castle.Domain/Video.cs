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
    /// 视频实体
    /// </summary>

    [ActiveRecord("video")]
    public class Video : EntityBase
    {
        /// <summary>
        /// ID
        /// </summary>
        [PrimaryKey(PrimaryKeyType.Identity)]
        [Display(AutoGenerateField = false)]
        public int video_id { get; set; }

        /// <summary>
        /// 视频名称
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "视频名称")]
        public string video_name { get; set; }

        /// <summary>
        /// 视频分类
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "帐号")]
        public string video_category { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "视频地址")]
        public string url { get; set; }

        /// <summary>
        /// 视频作者
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "视频作者")]
        public string author { get; set; }

        [Property("classification_id")]
        public int classification_id { get; set; }

        /// <summary>
        /// 视频教程地址
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "视频教程地址")]
        public string class_file_url { get; set; }
    }
}
