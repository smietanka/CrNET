using CrNET.Interfaces;
using CrNET.Methods;
using CrNET.Types.Clans;
using CrNET.Types.Default;
using System;
using System.Collections.Generic;

namespace CrNET.Services
{
    public class CrCoreClans : ICrCoreClans
    {
        private const string API_URL_CLANS = "clans";
        private Request Request;

        public CrCoreClans(Request requestClient)
        {
            Request = requestClient ?? throw new ArgumentNullException("RequestClient is null.");
        }

        /// <summary>
        /// Get clans by search filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Clan> GetClans(SearchFilter filter)
        {
            var call = Request.GetCall(API_URL_CLANS);
            var searchFilterParam = UrlBuilder.GetCallBySearchFilter(filter, API_URL_CLANS);
            var clans = Request.GetResponse<Clans>(call, searchFilterParam);

            return clans.ClanList;
        }
    }
}