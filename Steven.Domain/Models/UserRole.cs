﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using Steven.Domain.Infrastructure;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Steven.Domain.Models
{

    [Table("UserRole")]
    public class UserRole : AggregateRoot
    {
        [MaxLength(20),Required]
        public virtual string Name
        {
            get;
            set;
        }

        [MaxLength(250)]
        public virtual string Remark
        {
            get;
            set;
        }

        public virtual int Sort
        {
            get;
            set;
        }

    }

}