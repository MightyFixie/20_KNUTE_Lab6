using System.IO;

namespace _20_Lab6_2 {
	class PlayerItem {
		public IMedia FileRef {
			get; set;
		}
		public static PlayerItem DefineMedia(string path) {
			if (!File.Exists(path))
				return null;
			switch (Path.GetExtension(path).ToUpper()) {
			case ".MKV":
				return new MatroskaVideo();
			case ".MP3":
				return new MP3Audio();
			case ".WAV":
			case ".WAVE":
				return new WaveAudio();
			default:
				return null;
			}
		}
	}
}
