namespace Transcoder.commands
{
    public class Scanning : FfmpegCommand
    {
        public override void HandleRequest(FfmpegValue value)
        {
            if (value.Id == Commands.Scanning)
            {
                value.Result = $"scanning - {value.Value}";
            }
            else
            {
                Command?.HandleRequest(value);
            }
        }
    }
}
