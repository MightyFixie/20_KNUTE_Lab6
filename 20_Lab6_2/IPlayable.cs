using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab6_2 {
	public interface IPlayable : IMedia {
		void Play();
		void Pause();
		void Stop();
	}
}
