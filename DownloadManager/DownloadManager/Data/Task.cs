using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Data
{
	/// <summary>
	/// The class describes an abstract order to get particular resource through the HTTP client.
	/// </summary>
	public class Task
	{
		/// <summary>
		/// The title of the task
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The resource url.
		/// </summary>
		public string ResoureUrl { get; set; }
	}
}
