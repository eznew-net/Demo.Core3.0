using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.DTO.Sys.Cmd
{
    /// <summary>
    /// 检查授权操作分组名称
    /// </summary>
    public class ExistOperationGroupNameDto
    {
        /// <summary>
        /// 分组名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排除验证的分组编号
        /// </summary>
        public long ExcludeId { get; set; }
    }
}
