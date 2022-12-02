namespace GB26875
{
    /// <summary>
    /// 建筑消防设施系统状态类型
    /// 2~9: 预留
    /// </summary>
    public enum FireSystemStatus : byte
    {
        /// <summary>
        /// 通用
        /// </summary>
        General = 0,

        /// <summary>
        /// 火灾报警系统
        /// </summary>
        FireAlarmSystem = 1,

        /// <summary>
        /// 消防联动控制器
        /// </summary>
        FireLinkageController = 10,

        /// <summary>
        /// 消火栓系统
        /// </summary>
        HydrantSystem = 11,

        /// <summary>
        /// 自动喷水灭火系统
        /// </summary>
        SprinklerSystem = 12,

        /// <summary>
        /// 气体灭火系统
        /// </summary>
        GasFireSystem = 13,

        /// <summary>
        /// 水喷雾灭火系统（泵启动方式）
        /// </summary>
        WaterSprayFireSystem_Pump = 14,

        /// <summary>
        /// 水喷雾灭火系统（压力容器启动方式）
        /// </summary>
        WaterSprayFireSystem_Pressure = 15,

        /// <summary>
        /// 泡沫灭火系统
        /// </summary>
        FoamFireSystem = 16,

        /// <summary>
        /// 干粉灭火系统
        /// </summary>
        DryPowderFireSystem = 17,

        /// <summary>
        /// 防烟排烟系统
        /// </summary>
        SmokeSystem = 18,

        /// <summary>
        /// 防火门及卷帘系统
        /// </summary>
        FireDoorsSystem = 19,

        /// <summary>
        /// 消防电梯
        /// </summary>
        FireElevator = 20,

        /// <summary>
        /// 消防应急广播
        /// </summary>
        FireBroadcast = 21,

        /// <summary>
        /// 消防应急照明和疏散指示系统
        /// </summary>
        FireLightingSystem = 22,

        /// <summary>
        /// 消防电源
        /// </summary>
        FirePowerSupply = 23,

        /// <summary>
        /// 消防电话
        /// </summary>
        FireTelephone = 24
    }
}