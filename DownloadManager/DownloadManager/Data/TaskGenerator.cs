using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using HtmlAgilityPack;

namespace DownloadManager.Data
{
	public static class TaskGenerator
	{
		public static List<Task> ReadTasks()
		{
			var taskList = new List<Task>();

			var webClient = new System.Net.WebClient();
			string picturesUrl = ConfigurationManager.AppSettings["ContentURL"];
			string pageContent = webClient.DownloadString(picturesUrl);

			HtmlDocument htmlDoc = new HtmlDocument();
			htmlDoc.LoadHtml(pageContent);

			if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
			{
				// Handle any parse errors as required
			}
			else
			{
				if (htmlDoc.DocumentNode != null)
				{
					HtmlNodeCollection imageNodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='thumb']");
					HtmlNodeCollection titleNodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='tit']");

					if (imageNodes != null && titleNodes != null && imageNodes.Count == titleNodes.Count)
					{
						for (int i = 0; i < titleNodes.Count; i++)
						{
							HtmlNode titleNode = titleNodes[i];
							taskList.Add(new Task { Title = titleNode.InnerText });
						}

						for (int i = 0; i < imageNodes.Count; i++)
						{
							taskList[i].ResoureUrl = imageNodes[i].Attributes["href"].Value;
						}
					}
				}
			}

			return taskList;
		}
	}
}
