
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Volume
{
     public partial class DockerVolumeInspectTask : ExternalProcessTaskBase<DockerVolumeInspectTask>
     {
        private string[] _volume;

        
        public DockerVolumeInspectTask(params string[] volume)
        {
            ExecutablePath = "docker";
            WithArguments("volume inspect");
_volume = volume;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerVolumeInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_volume);

            return base.DoExecute(context);
        }

     }
}
