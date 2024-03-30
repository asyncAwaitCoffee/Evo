namespace EvoApp.Models
{
	public class GatherContent
	{
		private int[] Content { get; init; } = [1,2,3];
		public int[] ToolContent { get; init; } = [4,5,6];
		public int[] SpecialContent { get; init; } = [7,8,9];

		public int[] Gather()
		{
			return Content;
		}
    }
}
