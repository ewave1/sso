﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    /// <summary>
    /// 报价记录
    /// </summary>
    public class InquiryLog
    {
        //输入
        /// <summary>
        /// 自增
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 编码
        /// </summary>  
        public string Code { get; set; }

        /// <summary>
        /// 内径
        /// </summary> 
        public decimal SizeA { get; set; }

        /// <summary>
        /// 线径
        /// </summary> 
        public decimal SizeB { get; set; }
     
        /// <summary>
        /// 工厂或贸易商
        /// </summary>
        public string Factory { get; set; }

        public int Number { get; set; }
        //输出
        public string Material { get; set; }
        public int MaterialId { get; set; }

        public decimal discount { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; }
      

        //时间

        public int User { get; set; }
    }

  
}
