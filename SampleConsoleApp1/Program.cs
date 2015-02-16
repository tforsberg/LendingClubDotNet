using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingClubDotNet.Client.v1;
using LendingClubDotNet.Models.Requests;
using LendingClubDotNet.Models.Responses;

namespace SampleConsoleApp1
{
    class Program
    {
        private static string actorId;
        private static string authenticationToken;
        private static int loanId;
        private static long? portfolioId;


        static void Main(string[] args)
        {

            //var authenticationToken = 'authtoken';
            //var actorId = 'actorId';

            // Initialize the client with credentials.
            // Replace 'authenticationToken' with the one provided to you by Lending Club
            // Replace 'actorId' with your Lending Club Id
            LendingClubV1Client lendingClubV1Client = new LendingClubV1Client(authenticationToken, actorId);

            // Get all Listed Loans.
            ListedLoansResponse listedLoansResponse = lendingClubV1Client.LoanResource.GetListedLoans();

            // Get all Portfolios that you have.
            PortfoliosOwnedResponse portfoliosOwnedResponse = lendingClubV1Client.AccountResource.GetPortfoliosOwned();

            // Submit an Orders Request (invest in loans).
            SubmitOrdersRequest submitOrdersRequest = new SubmitOrdersRequest
            {
                aid = Convert.ToInt32(actorId),
                orders = new List<Order> { new Order
                {
                    loanId = loanId,
                    portfolioId =  portfolioId,
                    requestedAmount = 25
                } }
            };

            // Congratulations, at this point if the request has been submitted successfully, you will have programatically invested!
            SubmitOrdersResponse submitOrdersResponse = lendingClubV1Client.AccountResource.SubmitOrders(submitOrdersRequest);

        }

    }
}
