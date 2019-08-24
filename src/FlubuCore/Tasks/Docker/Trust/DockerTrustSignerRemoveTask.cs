
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Trust
{
     public partial class DockerTrustSignerRemoveTask : ExternalProcessTaskBase<int, DockerTrustSignerRemoveTask>
     {
        private string _name;
private string[] _repository;

        
        public DockerTrustSignerRemoveTask(string name,  params string[] repository)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_name = name;
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not prompt for confirmation before removing the most recent signer

        /// </summary>
        [ArgKey("force")]
        public DockerTrustSignerRemoveTask Force()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_name);
 WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}