using CocNET.Interfaces;
using CocNET.Methods;
using CrNET.Methods;
using CrNET.Types.Cards;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Web;

namespace CocNET.Services
{
    public class CrCoreCards : ICrCoreCards
    {
        private const string API_URL_CLANS = "cards";
        private Request Request;

        public CrCoreCards(Request requestClient)
        {
            Request = requestClient ?? throw new ArgumentNullException("RequestClient is null.");
        }
        /// <summary>
        /// Get list of all game cards
        /// </summary>
        /// <returns>List of cards</returns>
        public List<Card> GetCards()
        {
            var call = Request.GetCall(API_URL_CLANS);

            var myClan = Request.GetResponse<List<Card>>(call);

            return myClan;
        }
    }
}