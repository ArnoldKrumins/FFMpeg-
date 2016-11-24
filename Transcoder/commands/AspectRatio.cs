using System;

namespace Transcoder.commands
{
    public class AspectRatio : FfmpegCommand
    {
        public override void HandleRequest(FfmpegValue value)
        {
            if (value.Id == Commands.AspectRatio)
            {
                value.Result = $"aspect ratio - {value.Value}";
            }
            else
            {
                Command?.HandleRequest(value);
            }
        }
    }
}

