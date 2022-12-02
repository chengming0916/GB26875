namespace GB26875
{

    public class DataUnit
    {
        /// <summary>
        /// ���ͱ�־
        /// </summary>
        public DataUnitType DataUnitType { get; set; }

        /// <summary>
        /// ��Ϣ������Ŀ
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// ��Ϣ��
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// ʱ���ǩ
        /// </summary>
        public string Timestamp { get; set; }
    }

    public class DataUnitAnalogue
    {
        /// <summary>
        /// ϵͳ����
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// ϵͳ��ַ
        /// </summary>
        public int Address { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public int PartType { get; set; }

        /// <summary>
        /// ������ַ
        /// </summary>
        public int PartAddress { get; set; }

        /// <summary>
        /// ģ��������
        /// </summary>
        public int ValueType { get; set; }

        /// <summary>
        /// ģ����ֵ
        /// </summary>
        public dynamic Value { get; set; }
    }
}