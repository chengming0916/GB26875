namespace GB26875
{
    /// <summary>
    /// 数据单元类型标志
    /// 0: 预留 
    /// 9~20: 预留(建筑消防设施信息)
    /// 22,23,27 预留
    /// 29~40: 预留(用户信息传输装置信息)
    /// 41~46: 预留(控制信息)
    /// 69~80: 预留
    /// 82,83,87 预留
    /// 92~127: 预留
    /// 128~254: 用户自定义
    /// </summary>
    public enum DataUnitType : byte
    {
        /// <summary>
        /// 上传建筑消防设施系统状态
        /// </summary>
        ReportFireSystemStatus = 1,

        /// <summary>
        /// 上传建筑消防设施部件运行状态
        /// </summary>
        ReportFireSystemPartStatus = 2,

        /// <summary>
        /// 上传建筑消防设施部件模拟量
        /// </summary>
        ReportFireSystemPartAnalogue = 3,

        /// <summary>
        /// 上传建筑消防设施操作信息
        /// </summary>
        ReportFireSystemControl = 4,

        /// <summary>
        /// 上传建筑消防设施软件版本
        /// </summary>
        ReportFireSystemSoftVersion = 5,

        /// <summary>
        /// 上传建筑消防设施系统配置情况
        /// </summary>
        ReportFireSystemSetting = 6,

        /// <summary>
        /// 上传建筑消防设施部件配置情况
        /// </summary>
        ReportFireSystemPartSetting = 7,

        /// <summary>
        /// 上传建筑消防设施系统时间
        /// </summary>
        ReportFireSystemTimestamp = 8,

        /// <summary>
        /// 上传用户信息传输装置运行状态
        /// </summary>
        ReportUserInfoTransmissionStatus = 21,

        /// <summary>
        /// 上传用户信息传输装置操作信息
        /// </summary>
        ReportUserInfoTransmissionControl = 24,

        /// <summary>
        /// 上传用户信息传输装置软件版本
        /// </summary>
        ReportUserInfoTransmissionSoftVersion = 25,

        /// <summary>
        /// 上传用户信息传输装置配置情况
        /// </summary>
        ReportUserInfoTransmissionSetting = 26,

        /// <summary>
        /// 上传用户信息传输装置系统时间
        /// </summary>
        ReportUserInfoTransmissionTimestamp = 28,

        /// <summary>
        /// 读取建筑消防设施系统状态
        /// </summary>
        ReadFireSystemStatus = 61,

        /// <summary>
        /// 读取建筑消防设施部件运行状态
        /// </summary>
        ReadFireSystemPartStatus = 62,

        /// <summary>
        /// 读取建筑消防设施模拟量信息
        /// </summary>
        ReadFireSystemPartAnalogue = 63,

        /// <summary>
        /// 读取建筑消防设施操作信息
        /// </summary>
        ReadFireSystemControl = 64,

        /// <summary>
        /// 读取建筑消防设施软件版本
        /// </summary>
        ReadFireSystemSoftVersion = 65,

        /// <summary>
        /// 读取建筑消防设施系统配置情况
        /// </summary>
        ReadFireSystemSetting = 66,

        /// <summary>
        /// 读取建筑消防设施部件配置情况
        /// </summary>
        ReadFireSystemPartSetting = 67,

        /// <summary>
        /// 读取建筑消防设施系统时间
        /// </summary>
        ReadFireSystemTimestamp = 68,

        /// <summary>
        /// 读取用户信息传输装置运行状态
        /// </summary>
        ReadUserInfoTransmissionStatus = 81,

        /// <summary>
        /// 读取用户信息传输装置操作信息记录
        /// </summary>
        ReadUserInfoTransmissionControl = 84,

        /// <summary>
        /// 读取用户信息传输装置软件版本
        /// </summary>
        ReadUserInfoTransmissionSoftVersion = 85,

        /// <summary>
        /// 读取用户信息传输装置配置情况
        /// </summary>
        ReadUserInfoTransmissionSetting = 86,

        /// <summary>
        /// 读取用户信息传输装置时间
        /// </summary>
        ReadUserInfoTransmissionTimestamp = 88,

        /// <summary>
        /// 初始化用户信息传输装置
        /// </summary>
        InitUserInfoTransmission = 89,

        /// <summary>
        /// 同步用户信息传输装置时钟
        /// </summary>
        SyncUserInfoTransmissionTimestamp = 90,

        /// <summary>
        /// 查岗
        /// </summary>
        CheckThePost = 91
    }
}