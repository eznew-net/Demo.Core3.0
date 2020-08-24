using System;
using System.Collections.Generic;
using EZNEW.Domain.Sys.Parameter.Filter;
using EZNEW.Module.Sys;
using EZNEW.Paging;

namespace EZNEW.DTO.Sys.Filter
{
    /// <summary>
    /// 用户筛选信息
    /// </summary>
    public class UserFilterDto : PagingFilter
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public List<long> Ids { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 真实名称
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public UserType? UserType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public UserStatus? Status { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 超级管理员
        /// </summary>
        public bool? SuperUser { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 名称匹配关键字(UserName/RealName)
        /// </summary>
        public string NameMateKey { get; set; }

        /// <summary>
        /// 联系关键字(QQ/Email/Mobile)
        /// </summary>
        public string ContactMateKey { get; set; }

        #region 筛选条件转换

        /// <summary>
        /// 筛选条件转换
        /// </summary>
        /// <returns></returns>
        public virtual UserFilter ConvertToFilter()
        {
            return this.MapTo<UserFilter>();
        }

        #endregion
    }
}
