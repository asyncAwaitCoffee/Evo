namespace EvoApp.Models
{
	public class Threshold<T>(Predicate<T> predicate)
	{
		private Predicate<T> _isAchieved = predicate;
	}
}
