using Issue6672.Debugging;

namespace Issue6672
{
    public class Issue6672Consts
    {
        public const string LocalizationSourceName = "Issue6672";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c8b4a1c0b81b4916a147823ddccc8e94";
    }
}
