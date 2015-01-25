namespace LendingClubDotNet.Models.Requests
{
	public sealed class CreatePortfolioRequest
	{
		public int ActorId { get; set; }

		public string PortfolioName { get; set; }

		public string PortfolioDescription { get; set; }
	}
}
