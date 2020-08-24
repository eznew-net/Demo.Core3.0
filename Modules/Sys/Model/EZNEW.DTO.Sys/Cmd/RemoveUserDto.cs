using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.DTO.Sys.Cmd
{
    /// <summary>
    /// 删除管理账户
    /// </summary>
    public class RemoveUserDto
    {
        /// <summary>
        /// 要删除的用户编号
        /// </summary>
        public IEnumerable<long> Ids { get; set; }
    }
}
