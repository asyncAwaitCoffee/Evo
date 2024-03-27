namespace EvoApp.Interfaces
{
	public interface ILive
	{
		public void Grow()
		{
			Age++;
		}
        public int Age { get; set; }
    }
}
