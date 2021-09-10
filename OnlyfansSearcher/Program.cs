using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.IO;
using System.Net;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Management;
using xNet;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading;
using System.Globalization;

namespace OnlyfansSearcher
{
    class Program
    {
		private static CultureInfo ci = CultureInfo.CurrentCulture;
		public static void Main(string[] args)
		{
			Console.Clear();
			Console.Title = "OnlyfansSearcher - Best Onlyfans searcher - cracked.to/Zekh";
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[1] Search onlyfans", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[2] Bypassing linkvertise url", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[3] Check my profil", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[4] Exit", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher();
				
			}
			if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Bypasser();
			}
			if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Process.Start("https://cracked.to/Zekh");
			}
			if (keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
		}
		public static void Main2()
		{
			Console.Clear();
			Console.Title = "OnlyfansSearcher - Best Onlyfans searcher - cracked.to/Zekh";
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[1] Search onlyfans", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[2] Bypassing linkvertise url", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[3] Check my profil", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[4] Exit", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher();

			}
			if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Bypasser();
			}
			if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Process.Start("https://cracked.to/Zekh");
			}
			if (keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
		}

		public static void TheSearcher()
		{
			Console.Clear();
			Console.Title = "OnlyfansSearcher - Search your onlyfans";
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		   > Enter a Onlyfans (ex: Belle Delphine, Amouranth...) :", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);

			string resp = Console.ReadLine();
			int count = 0;
			List<string> Links = new List<string>();
			using (WebClient wc = new WebClient())
			{
				string s = wc.DownloadString("https://www.google.com/search?q=site:drive.google.com+" + resp + "|");
				string s2 = wc.DownloadString("https://www.google.com/search?q=site:famouspaste.com+" + resp + "|");
				string s3 = wc.DownloadString("https://www.google.com/search?q=site:pastelink.net+" + resp + "|");
				string s4 = wc.DownloadString("https://www.google.com/search?q=site:0bin.net+" + resp + "|");
				string s5 = wc.DownloadString("https://www.google.com/search?q=site:rentry.co+" + resp + "|");
				string s6 = wc.DownloadString("https://www.google.com/search?q=site:pastesite.org+" + resp + "|");
				string s7 = wc.DownloadString("https://www.google.com/search?q=site:freepaste.link+" + resp + "|");
				string s8 = wc.DownloadString("https://www.google.com/search?q=site:leaklinks.com+" + resp + "|");
				string s9 = wc.DownloadString("https://www.google.com/search?q=site:gofile.io+" + resp + "|");
				string s10 = wc.DownloadString("https://www.google.com/search?q=site:justpaste.it+" + resp + "|");
				Regex r = new Regex(@"https:\/\/drive.google.com\/\w+\/\w+");
				Regex r2 = new Regex(@"https:\/\/famouspaste.com\/\w+\/\w+");
				Regex r3 = new Regex(@"https:\/\/pastelink.net\/\w+\/\w+");
				Regex r4 = new Regex(@"https:\/\/0bin.net\/\w+\/\w+");
				Regex r5 = new Regex(@"https:\/\/rentry.co\/\w+");
				Regex r6 = new Regex(@"https:\/\/pastesite.org\/\w+\/\w+");
				Regex r7 = new Regex(@"https:\/\/freepaste.link\/\w+\/\w+");
				Regex r8 = new Regex(@"https:\/\/leaklinks.com\/\w+\/\w+");
				Regex r9 = new Regex(@"https:\/\/gofile.io\/\w+\/\w+");
				Regex r10 = new Regex(@"https:\/\/justpaste.it\/\w+\/\w+");
				
				foreach (Match m in r.Matches(s))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r2.Matches(s2))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r3.Matches(s3))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r4.Matches(s4))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r5.Matches(s5))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r6.Matches(s6))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r7.Matches(s7))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r8.Matches(s8))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r9.Matches(s9))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r10.Matches(s10))
				{
					count++;
					Links.Add(m.ToString());
				}
				
			}

			using (TextWriter tw = new StreamWriter(@"ScrapedLinks.txt"))
			{
				foreach (string line in Links)
				{
					tw.WriteLine(line.ToString());
				}
			}

			Console.Clear();
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		> Scraped " + count.ToString() + " links! Your sesult has been save in 'ScrapedLinks.txt'", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[1] Scrape another onlyfans", Color.DeepPink);
			Console.WriteLine();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[Q] Quit", Color.DeepPink);
			Colorful.Console.WriteLine("		[M] Back to menu", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher2();
			}
			if (keyInfo.Key == ConsoleKey.Q || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
			if (keyInfo.Key == ConsoleKey.M || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Main2();
			}

		}
		public static void TheSearcher2()
		{
			Console.Clear();
			Console.Title = "OnlyfansSearcher - Search your onlyfans";
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		   > Enter a Onlyfans (ex: Belle Delphine, Amouranth...) :", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);

			string resp = Console.ReadLine();
			int count = 0;
			List<string> Links = new List<string>();
			using (WebClient wc = new WebClient())
			{
				string s = wc.DownloadString("https://www.google.com/search?q=site:drive.google.com+" + resp + "|");
				string s2 = wc.DownloadString("https://www.google.com/search?q=site:famouspaste.com+" + resp + "|");
				string s3 = wc.DownloadString("https://www.google.com/search?q=site:pastelink.net+" + resp + "|");
				string s4 = wc.DownloadString("https://www.google.com/search?q=site:0bin.net+" + resp + "|");
				string s5 = wc.DownloadString("https://www.google.com/search?q=site:rentry.co+" + resp + "|");
				string s6 = wc.DownloadString("https://www.google.com/search?q=site:pastesite.org+" + resp + "|");
				string s7 = wc.DownloadString("https://www.google.com/search?q=site:freepaste.link+" + resp + "|");
				string s8 = wc.DownloadString("https://www.google.com/search?q=site:leaklinks.com+" + resp + "|");
				string s9 = wc.DownloadString("https://www.google.com/search?q=site:gofile.io+" + resp + "|");
				string s10 = wc.DownloadString("https://www.google.com/search?q=site:justpaste.it+" + resp + "|");
				Regex r = new Regex(@"https:\/\/drive.google.com\/\w+\/\w+");
				Regex r2 = new Regex(@"https:\/\/famouspaste.com\/\w+\/\w+");
				Regex r3 = new Regex(@"https:\/\/pastelink.net\/\w+\/\w+");
				Regex r4 = new Regex(@"https:\/\/0bin.net\/\w+\/\w+");
				Regex r5 = new Regex(@"https:\/\/rentry.co\/\w+\/\w+");
				Regex r6 = new Regex(@"https:\/\/pastesite.org\/\w+\/\w+");
				Regex r7 = new Regex(@"https:\/\/freepaste.link\/\w+\/\w+");
				Regex r8 = new Regex(@"https:\/\/leaklinks.com\/\w+\/\w+");
				Regex r9 = new Regex(@"https:\/\/gofile.io\/\w+\/\w+");
				Regex r10 = new Regex(@"https:\/\/justpaste.it\/\w+\/\w+");
				foreach (Match m in r.Matches(s))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r2.Matches(s2))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r3.Matches(s3))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r4.Matches(s4))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r5.Matches(s5))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r6.Matches(s6))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r7.Matches(s7))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r8.Matches(s8))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r9.Matches(s9))
				{
					count++;
					Links.Add(m.ToString());
				}
				foreach (Match m in r10.Matches(s10))
				{
					count++;
					Links.Add(m.ToString());
				}
		}

			using (TextWriter tw = new StreamWriter(@"ScrapedLinks.txt"))
			{
				foreach (string line in Links)
				{
					tw.WriteLine(line.ToString());
				}
			}

			Console.Clear();
			Onlyfansheader.Header1();
			Console.WriteLine();
			Colorful.Console.WriteLine("		> Scraped " + count.ToString() + " links! Your sesult has been save in 'ScrapedLinks.txt'", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[1] Search another onlyfans", Color.DeepPink);
			Console.WriteLine();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[Q] Quit", Color.DeepPink);
			Colorful.Console.WriteLine("		[M] Back to menu", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher();
			}
			if (keyInfo.Key == ConsoleKey.Q || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
			if (keyInfo.Key == ConsoleKey.M || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Main2();
			}

		}
		public static void Bypasser()
		{
			Console.Clear();
			Onlyfansheader.Header1();
			Console.Title = "OnlyfansSearcher - Linkvertise bypasser";
			Colorful.Console.WriteLine("		   ||| If its not working go to : thebypasser.com |||", Color.DarkRed);
			Console.WriteLine();
			Colorful.Console.WriteLine("		   > Enter your linkvertise link :", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			string[] result = Bypass(Console.ReadLine());
			Console.Clear();
			Onlyfansheader.Header1();
			Console.WriteLine("\n  Input URL : " + result[0], Color.DeepPink);
			Console.WriteLine("  URL       : " + result[1], Color.DeepPink);
			Console.ReadLine();
			Colorful.Console.WriteLine("		[1] Bypass another link", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[2] Search another onlyfans ", Color.DeepPink);
			Console.WriteLine();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[Q] Quit", Color.DeepPink);
			Colorful.Console.WriteLine("		[M] Back to menu", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Bypasser2();
			}
			if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher();
			}
			if (keyInfo.Key == ConsoleKey.Q || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
			if (keyInfo.Key == ConsoleKey.M || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Main2();
			}
		}
		public static void Bypasser2()
		{
			Console.Clear();
			Onlyfansheader.Header1();
			Console.Title = "OnlyfansSearcher - Linkvertise bypasser";
			Colorful.Console.WriteLine("		   > Enter your linkvertise link :", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			string[] result = Bypass(Console.ReadLine());
			Console.Clear();
			Onlyfansheader.Header1();
			Console.WriteLine("\n  Input URL : " + result[0], Color.DeepPink);
			Console.WriteLine("  URL       : " + result[1], Color.DeepPink);
			Console.ReadLine();
			Colorful.Console.WriteLine("		[1] Bypass another link", Color.DeepPink);
			Console.WriteLine();
			Colorful.Console.WriteLine("		[2] Search another onlyfans ", Color.DeepPink);
			Console.WriteLine();
			Console.WriteLine();
			Colorful.Console.WriteLine("		[Q] Quit", Color.DeepPink);
			Colorful.Console.WriteLine("		[M] Back to menu", Color.DeepPink);
			Colorful.Console.Write("               > ", Color.DeepPink);
			ConsoleKeyInfo keyInfo = Console.ReadKey();
			if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Bypasser();
			}
			if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				TheSearcher();
			}
			if (keyInfo.Key == ConsoleKey.Q || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
			if (keyInfo.Key == ConsoleKey.M || keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.Clear();
				Onlyfansheader.Header1();
				Main2();
			}
		}
		static Random random = new Random();
		public static string GetRandomEnding()
		{
			return string.Format("{0}.{1}.{2}.{3}", new object[]
			{
				random.Next(1, 99),
				random.Next(0, 99),
				random.Next(0, 99),
				random.Next(0, 99)
			});
		}

		public static string[] Bypass(string url)
		{
			string resultUrl = url.Replace("https://linkvertise.com/", string.Empty);
			resultUrl = resultUrl.Replace("https://up-to-down.net/", string.Empty);
			resultUrl = resultUrl.Replace("https://link-to.net/", string.Empty);
			resultUrl = resultUrl.Replace("https://direct-link.net/", string.Empty);
			resultUrl = resultUrl.Replace("https://file-link.net", string.Empty);
			resultUrl = resultUrl.Replace("https://rentry.co", string.Empty);
			resultUrl = resultUrl.Replace("https://justpaste.it", string.Empty);
			resultUrl = resultUrl.Replace("?o=sharing", string.Empty);

			string randomProxy = GetRandomEnding();
			randomProxy = "/" + randomProxy.Replace(".", string.Empty);
			string address = @"https://Linkvertise-Bypass-API-SRC.waterthedev.repl.co/" + resultUrl + randomProxy;
			try
			{
				string[] results = new string[3];
				WebClient wClient = new WebClient();
				string value = wClient.DownloadString(address);
				API apiResult = JsonConvert.DeserializeObject<API>(value);

				if (apiResult.NewLink.Contains("invalid"))
				{
					Bypass(url);
				}
				results[0] = apiResult.InputLink;
				results[1] = (ci.Name == "tr-TR") ? (results[1] = apiResult.NewLink.Replace("pastebin.com", "pastebinp.com")) : (results[1] = apiResult.NewLink);
				results[2] = apiResult.TimesTried.ToString();
				return results;
			}
			catch
			{
				Bypass(url);
				return new string[] { "ERROR" };
			}
		}
		public class API
		{
			[JsonProperty("input_link")]
			public string InputLink { get; set; }

			[JsonProperty("new_link")]
			public string NewLink { get; set; }

			[JsonProperty("times_tried")]
			public int TimesTried { get; set; }
		}

		
	}
}
