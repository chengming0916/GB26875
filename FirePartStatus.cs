namespace GB26875
{
    /// <summary>
    /// 建筑消防设施部件状态
    /// 2~9 预留
    /// 14,15 预留
    /// 19,20 预留
    /// 26~29 预留
    /// 38,39 预留
    /// 45~49 预留
    /// 54~59 预留
    /// 60 预留
    /// 63~68 预留
    /// 70~73 预留
    /// 75~77 预留
    /// 80 预留
    /// 89,90 预留
    /// 93,94 预留
    /// 100 预留
    /// 107~110 预留
    /// 119~120 预留
    /// 122~127 预留
    /// 128~255 用户自定义
    /// </summary>
    public enum FirePartStatus
    {
        /// <summary>
        /// 通用
        /// </summary>
        Gerneral = 0,

        /// <summary>
        /// 可燃气体探测器
        /// </summary>
        GasDetector = 10,

        /// <summary>
        /// 点型可燃气体探测器
        /// </summary>
        GasDetector_Point = 11,

        /// <summary>
        /// 独立式可燃气体探测器
        /// </summary>
        GasDetector_StandAlone = 12,

        /// <summary>
        /// 线型可燃气体探测器
        /// </summary>
        GasDetector_Linear = 13,

        /// <summary>
        /// 电气火灾监控报警器
        /// </summary>
        ElectricalFireAlarm = 16,

        /// <summary>
        /// 剩余电流式电气火灾监控报警器
        /// </summary>
        ElectricalFireAlarm_ResidualCurrent = 17,

        /// <summary>
        /// 测温式电气火灾监控报警器
        /// </summary>
        ElectricalFireAlarm_Temperature = 18,

        /// <summary>
        /// 探测回路
        /// </summary>
        DetectionLoops = 21,

        /// <summary>
        /// 火灾显示盘
        /// </summary>
        FireDisplay = 22,

        /// <summary>
        /// 手动火灾报警按钮
        /// </summary>
        FireAlarmButton = 23,

        /// <summary>
        /// 消火栓按钮
        /// </summary>
        HydrantButton = 24,

        /// <summary>
        /// 火灾探测器
        /// </summary>
        FireDetector = 25,

        /// <summary>
        /// 感温火灾探测器
        /// </summary>
        TemperatueDetector = 30,

        /// <summary>
        /// 点型感温火灾探测器
        /// </summary>
        TemperatueDetector_Point = 31,
        /// <summary>
        /// 点型感温火灾探测器(S型)
        /// </summary>
        TemperatueDetector_Point_S = 32,
        /// <summary>
        /// 点型感温火灾探测器(R型)
        /// </summary>
        TemperatueDetector_Point_R = 33,

        /// <summary>
        /// 线型感温火灾探测器
        /// </summary>
        TemperatueDetector_Linear = 34,

        /// <summary>
        /// 线型感温火灾探测器(S型)
        /// </summary>
        TemperatueDetector_Linear_S = 35,

        /// <summary>
        /// 线型感温火灾探测器(R型)
        /// </summary>
        TemperatueDetector_Linear_R = 36,

        /// <summary>
        /// 光纤感温火灾探测器
        /// </summary>
        TemperatureDetector_Fiber = 37,

        /// <summary>
        /// 感烟火灾探测器
        /// </summary>
        SmokeDetector = 40,

        /// <summary>
        /// 点型离子感烟火灾探测器
        /// </summary>
        SmokeDetector_Point_Ion = 41,

        /// <summary>
        /// 点型光电感烟火灾探测器
        /// </summary>
        SmokeDetector_Point_PE = 42,

        /// <summary>
        /// 线型光束感烟火灾探测器
        /// </summary>
        SmokeDetector_Linear = 43,

        /// <summary>
        /// 吸入式感烟火灾探测器
        /// </summary>
        SmokeDetector_Aspirating = 44,

        /// <summary>
        /// 复合式火灾探测器
        /// </summary>
        CompositeFireDetector = 50,

        /// <summary>
        /// 复合式感烟感温火灾探测器
        /// </summary>
        CompositeFireDetector_Smoke_Temperature = 51,

        /// <summary>
        /// 复合式感光感温火灾探测器
        /// </summary>
        CompositeFireDetector_PE_Temperature = 52,

        /// <summary>
        /// 复合式感光感烟火灾探测器
        /// </summary>
        CompositeFireDetector_PE_Smoke = 53,

        紫外火焰探测器 = 61,
        红外火焰探测器 = 62,
        感光火灾探测器 = 69,
        气体探测器 = 74,
        图像摄像方式火灾探测器 = 78,
        感声火灾探测器 = 79,
        气体灭火控制器 = 81,
        消防电气控制装置 = 82,
        消防控制室图形显示装置 = 83,
        模块 = 84,
        输入模块 = 85,
        输出模块 = 86,
        输入输出模块 = 87,
        中继模块 = 88,
        消防水泵 = 91,
        消防水箱 = 92,
        喷淋泵 = 95,
        水流指示器 = 96,
        信号阀 = 97,
        报警阀 = 98,
        压力开关 = 99,
        阀驱动装置 = 101,
        防火门 = 102,
        防火阀 = 103,
        通风空调 = 104,
        泡沫液泵 = 105,
        管网电磁阀 = 106,
        防烟排烟机 = 111,
        排烟防火阀 = 113,
        常闭送风口 = 114,
        排烟口 = 115,
        电控挡烟垂壁 = 116,
        防火卷帘控制器 = 117,
        防火门监控器 = 118,
        报警装置 = 121
    }
}