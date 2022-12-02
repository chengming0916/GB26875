namespace GB26875
{

    public class DataUnit
    {
        /// <summary>
        /// 类型标志
        /// </summary>
        public DataUnitType DataUnitType { get; set; }

        /// <summary>
        /// 信息对象数目
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 信息体
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// 时间标签
        /// </summary>
        public string Timestamp { get; set; }
    }

    public class DataUnitAnalogue
    {
        /// <summary>
        /// 系统类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 系统地址
        /// </summary>
        public int Address { get; set; }

        /// <summary>
        /// 部件类型
        /// </summary>
        public int PartType { get; set; }

        /// <summary>
        /// 部件地址
        /// </summary>
        public int PartAddress { get; set; }

        /// <summary>
        /// 模拟量类型
        /// </summary>
        public int ValueType { get; set; }

        /// <summary>
        /// 模拟量值
        /// </summary>
        public dynamic Value { get; set; }
    }
}