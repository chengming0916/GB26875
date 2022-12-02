namespace GB26875
{
    /// <summary>
    /// 控制单元命令字节定义
    /// 0: 预留 7~127 预留 128~255 用户自行定义
    /// </summary>
    public enum Command : byte
    {
        Control = 1,
        Report = 2,
        Confirm = 3,
        Request = 4,
        Response = 5,
        Deny = 6
    }
}