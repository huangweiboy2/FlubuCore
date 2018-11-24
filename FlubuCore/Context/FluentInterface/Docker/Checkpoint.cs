
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Checkpoint;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Checkpoint
    {  
        
            public DockerCheckpointCreateTask CheckpointCreate(string container ,  string checkpoint)
            {
                return new DockerCheckpointCreateTask(container,  checkpoint);
            }

            public DockerCheckpointLsTask CheckpointLs(string container)
            {
                return new DockerCheckpointLsTask(container);
            }

            public DockerCheckpointRmTask CheckpointRm(string container ,  string checkpoint)
            {
                return new DockerCheckpointRmTask(container,  checkpoint);
            }
        
    }
}

