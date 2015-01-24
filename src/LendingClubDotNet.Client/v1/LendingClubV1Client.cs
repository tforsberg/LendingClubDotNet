using LendingClubDotNet.Models.Responses;

namespace LendingClubDotNet.Client.v1
{
	public class LendingClubV1Client
	{
		public LendingClubV1Client(string baseUrl, string authorizationToken, string investorId)
		{
			m_baseUrl = baseUrl;
			m_authorizationToken = authorizationToken;
			m_investorId = investorId;
		}

		public LendingClubV1Client(string authorizationToken, string investorId)
		{
			m_authorizationToken = authorizationToken;
			m_baseUrl = c_defaultBaseUrl;
			m_investorId = investorId;
		}

		public AvailableCashResponse GetAvailableCash()
		{
			return RequestUtility.ExecuteGetRequest<AvailableCashResponse>(string.Format("{0}accounts/{1}/availablecash", m_baseUrl, m_investorId), m_authorizationToken);
		}

		private readonly string m_baseUrl;

		private readonly string m_authorizationToken;

		private readonly string m_investorId;

		private const string c_defaultBaseUrl = "https://api.lendingclub.com/api/investor/v1/";
	}
}
