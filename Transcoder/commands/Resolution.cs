using System.Linq;

namespace Transcoder.commands
{
    public class Resolution : FfmpegCommand
    {
        public override void HandleRequest(FfmpegValue value)
        {
            if (value.Id == Commands.Resolution)
            {
                //This will be more complax logic based on what other objects are in the collection
                var ratio = ValueList.FirstOrDefault(x => x.Id == Commands.AspectRatio);
                value.Result = ratio != null && ratio.Value == "16:9" ? $"16:9 tr -{ value.Value}" : $"not 16:9 -{ value.Value}";
            }
            else
            {
                Command?.HandleRequest(value);
            }
        }
    }
}
