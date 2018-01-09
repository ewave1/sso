﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SmartSSO.Entities
{
    public class ManageUser
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        [Key]
        [MaxLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        [MaxLength(32)]
        public string UserPwd { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Nick { get; set; }

        /// <summary>
        /// 用户的折扣
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 是否管理员
        /// </summary>
        [Required]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }
    }
}