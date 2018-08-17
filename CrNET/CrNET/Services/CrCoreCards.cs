using CrNET.Interfaces;
using CrNET.Methods;
using CrNET.Types.Cards;
using System;
using System.Collections.Generic;

namespace CrNET.Services
{
    public class CrCoreCards : ICrCoreCards
    {
        private const string API_URL_CARDS = "cards";
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
            var call = Request.GetCall(API_URL_CARDS);

            var cards = Request.GetResponse<Cards>(call);

            return cards.CardList;
        }
    }
}