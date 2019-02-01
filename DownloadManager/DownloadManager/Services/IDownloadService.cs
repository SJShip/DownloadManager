using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Services
{
	public interface ITaskService
	{
		Task<List<Data.TaskResult>> RunTasksAsync(List<Data.Task> tasks);

		Task<Data.TaskResult> RunTaskAsync(Data.Task task);
	}
}
