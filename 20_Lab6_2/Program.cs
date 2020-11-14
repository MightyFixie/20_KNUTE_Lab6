using System;
using System.IO;
using System.Text;

namespace _20_Lab6_2 {
	class Program {
		static void Main() {
			Console.OutputEncoding = Encoding.UTF8;
			Console.Title = "20_Lab6_2";

			Console.WriteLine("Перелік файлів у теці Media:");
			Console.WriteLine("Назва\t\tФормат\tМожливі дії");
			foreach (string s in Directory.EnumerateFiles("media\\")) {
				Console.Write(Path.GetFileName(s) + '\t');
				PlayerItem item = PlayerItem.DefineMedia(s);
				if (item is MatroskaVideo) {
					Console.Write("MKV\t");
					Console.Write("Відтворення, пауза, зупинка");
				} else if (item is MP3Audio) {
					Console.Write("MP3\t");
					Console.Write("Запис, пауза, зупинка");
				} else if (item is WaveAudio) {
					Console.Write("WAVE\t");
					Console.Write("Запис, відтворення, пауза, зупинка");
				} else {
					Console.Write("Невід-й\t");
					Console.Write("N/A");
				}
				Console.WriteLine();
			}
		}
	}
}
