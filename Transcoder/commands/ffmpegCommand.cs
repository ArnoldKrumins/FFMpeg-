using System.Collections.Generic;

namespace Transcoder.commands
{


    public abstract class FfmpegCommand
    {

        // The original list. Might be used to evalute what commands and values the user has selected.
        public static List<FfmpegValue> ValueList = new List<FfmpegValue>();

        //protected FfmpegCommand()
        //{
        //    ValueList = new List<FfmpegValue>();
        //}

        protected FfmpegCommand Command;

        public void SetSuccessor(FfmpegCommand command)
        {
            this.Command = command;
        }

        public abstract void HandleRequest(FfmpegValue value);
    }
}
