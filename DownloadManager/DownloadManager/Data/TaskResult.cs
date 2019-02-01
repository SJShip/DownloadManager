using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Data
{
	/// <summary>
	/// Describes the task result.
	/// </summary>
	public class TaskResult
	{
		/// <summary>
		/// The status of the operation
		/// </summary>
		TaskStatus Status { get; set; }
		
		/// <summary>
		/// Http code that describes the result of downloading the resource
		/// </summary>
		int Code { get; set; }

		/// <summary>
		/// The location to where the requested resource has been stored.
		/// </summary>
		string ResourceLocation { get; set; }

		/// <summary>
		/// The error message
		/// </summary>
		string ErrorMessage { get; set; }
	}
}
