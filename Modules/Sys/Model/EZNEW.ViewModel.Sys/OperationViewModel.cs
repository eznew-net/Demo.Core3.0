using EZNEW.Module.Sys;

namespace EZNEW.ViewModel.Sys
{
    /// <summary>
    /// 授权操作
    /// </summary>
    public class OperationViewModel
    {
        /// <summary>
        /// 主键编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public string ControllerCode { get; set; }

        /// <summary>
        /// 操作方法
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public OperationStatus Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 操作分组
        /// </summary>
        public OperationGroupViewModel Group { get; set; }

        /// <summary>
        /// 访问限制类型
        /// </summary>
        public OperationAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// 方法描述
        /// </summary>
        public string Remark { get; set; }
    }
}