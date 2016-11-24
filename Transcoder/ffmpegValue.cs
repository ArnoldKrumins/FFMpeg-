namespace Transcoder
{
    public class FfmpegValue
    {
        /// <summary>
        /// The enumeration Command
        /// </summary>
        public Commands Id { get; set; }
        /// <summary>
        /// The value from the UI
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// The result of the command and value.
        /// </summary>
        public string Result { get; set; }
    }
}
