namespace ServiceMonitorEVK.Source.Constants
{
    internal static class DisplayModeConstants
    {
        public const string PC_SCREEN_ONLY = "PC_SCREEN_ONLY";
        public const string DUPLICATE = "DUPLICATE";
        public const string EXTEND = "EXTEND";
        public const string SECOND_SCREEN_ONLY = "SECOND_SCREEN_ONLY";

        public static readonly string[] AllModes = new string[]
        {
            PC_SCREEN_ONLY,
            DUPLICATE,
            EXTEND,
            SECOND_SCREEN_ONLY
        };
    }
}
