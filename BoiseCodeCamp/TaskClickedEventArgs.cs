using System;
using ExternalLibrary.BL;

namespace BoiseCodeCamp.AL
{
	public class TaskClickedEventArgs : EventArgs
	{
		public Task Task { get; set; }
		
		public TaskClickedEventArgs (Task task) : base ()
		{
			this.Task = task;
		}
	}
}

