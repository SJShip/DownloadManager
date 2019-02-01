using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Data
{
	/// <summary>
	/// The possible states in which a task can be.
	/// </summary>
	public enum TaskStatus
	{
		/// <summary>
		/// The task in the initial state. Not processed.
		/// </summary>
		Pending = 0,
		/// <summary>
		/// The task is in progress.
		/// </summary>
		InProgress,
		/// <summary>
		/// The task has been finished.
		/// </summary>
		Completed
	}
}
