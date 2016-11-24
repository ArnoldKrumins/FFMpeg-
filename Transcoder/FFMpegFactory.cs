using Transcoder.commands;

namespace Transcoder
{
    public enum Commands
    {
        Resolution,
        AspectRatio,
        Scanning,
    }
    public static class FfMpegFactory
    {

        public static FfmpegCommand Create(string value)
        {
            switch (value)
            {
                case "AVI|MPEG2":
                    FfmpegCommand aviresolution = new Resolution();
                    FfmpegCommand aviaspect = new AspectRatio();
                    FfmpegCommand aviscanning = new Scanning();
                    aviresolution.SetSuccessor(aviaspect);
                    aviaspect.SetSuccessor(aviscanning);
                    return aviresolution;
                case "MP4|WEBM": // Don't need Scanning. Maybe need to add some other commands...
                    FfmpegCommand mp4Resolution = new Resolution();
                    FfmpegCommand mp4Aspect = new AspectRatio();
                    mp4Resolution.SetSuccessor(mp4Aspect);
                    return mp4Resolution;
                    //Etc etc...
            }

            return null;
        }
    }
}
