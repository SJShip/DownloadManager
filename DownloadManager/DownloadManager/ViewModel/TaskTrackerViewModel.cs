using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.ViewModel
{
	class TaskTrackerViewModel: INotifyPropertyChanged
	{
		private string imageSource;
		private string tooltip;
		private string title;

		public string ImageSource
		{
			get { return imageSource; }
			set
			{
				OnPropertyChanged("imageSource");
				imageSource = value;
			}
		}

		public string Tooltip
		{
			get { return tooltip; }
			set
			{
				OnPropertyChanged("tooltip");
				tooltip = value;
			}
		}

		public string Title
		{
			get { return title; }
			set
			{
				OnPropertyChanged("title");
				title = value;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string caller = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(caller));
			}
		}
	}
}
