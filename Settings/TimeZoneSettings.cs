namespace CADE.Aurora.Settings
{
    /// <summary>
    /// 时区显示设置，供 TimeStampConverter 使用。
    /// </summary>
    public static class TimeZoneSettings
    {
        /// <summary>
        /// true = 使用本地时区显示时间戳
        /// false = 使用 UTC+0 显示时间戳
        /// </summary>
        public static bool UseLocalTime { get; set; } = false;
    }
}
