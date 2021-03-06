﻿using System;
using System.Collections.Generic;
using System.Text;
using EZNEW.DTO.Sys.Cmd;
using EZNEW.Response;

namespace EZNEW.AppServiceContract.Sys
{
    /// <summary>
    /// 角色授权应用服务
    /// </summary>
    public interface IRolePermissionAppService
    {
        #region 修改角色授权

        /// <summary>
        /// 修改角色授权
        /// </summary>
        /// <param name="modifyRolePermissionDto">角色授权修改信息</param>
        /// <returns>返回执行结果</returns>
        Result ModifyRolePermission(ModifyRolePermissionDto modifyRolePermissionDto);

        #endregion

        #region 清除角色授权

        /// <summary>
        /// 清除角色授权
        /// </summary>
        /// <param name="roleIds">角色系统编号</param>
        /// <returns>返回执行结果</returns>
        Result ClearRolePermission(IEnumerable<long> roleIds);

        #endregion
    }
}
