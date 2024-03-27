using EvoApp.Models;

namespace EvoApp.Interfaces
{
	public interface IEvolve<T>
	{
		public Threshold<T> Threshold { get; set; }
	}
}
