using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Services
{
	public interface ITaskService
	{
		Task<IList<Data.TaskResult>> RunTasksAsync(IList<Data.Task> tasks);

		Task<Data.TaskResult> RunTaskAsync(Data.Task task);
	}
}
