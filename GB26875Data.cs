namespace GB26875
{
    public class GB26875Data
    {
        public readonly byte[] STARTUP_IDENTIFIER = new byte[] { 0x40, 0x40 };
        public readonly byte[] END_IDENTIFIER = new byte[] { 0x35, 0x35 };
        public const int MAX_DATA_LENGTH = 1024;

        /// <summary>
        /// 业务流水号
        /// </summary>
        public uint SYN { get; set; }

        /// <summary>
        /// 协议版本号
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// 时间标签
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// 源地址
        /// </summary>
        public byte[] SourceAddress { get; set; }

        /// <summary>
        /// 目标地址
        /// </summary>
        public byte[] TargetAddress { get; set; }

        /// <summary>
        /// 应用数据单元长度
        /// </summary>
        public int DataLength { get; set; }

        /// <summary>
        /// 命令字节
        /// </summary>
        public int Command { get; set; }

        /// <summary>
        /// 应用数据单元
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// 校验和
        /// </summary>
        public int Crc { get; set; }

        public static GB26875Data Decode(byte[] data)
        {
            return new GB26875Data()
            {

            };
        }
    }
}