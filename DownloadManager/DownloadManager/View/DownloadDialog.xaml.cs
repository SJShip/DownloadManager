using DownloadManager.Controls;
using DownloadManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DownloadManager
{
	/// <summary>
	/// Interaction logic for DownloadDialog.xaml
	/// </summary>
	public partial class DownloadDialog : Window
	{
		public DownloadDialog()
		{
			InitializeComponent();
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			Tasks = TaskGenerator.ReadTasks();
		}

		public List<Data.Task> Tasks { get; set; }

		private void OnLoaded(object sender, RoutedEventArgs e) {
			if (Tasks != null)
			{
				foreach (var task in Tasks)
				{

					var taskTracker = new TaskTracker();
					this.TaskPanel.Children.Add(taskTracker);
				}
			}
		}
	}
}
