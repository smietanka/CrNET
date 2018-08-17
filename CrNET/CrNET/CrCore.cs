using CrNET.Interfaces;
using CrNET.Methods;
using CrNET.Services;
using Funq;
using System;

namespace CrNET
{
    public class CrCore
    {
        private static object syncRoot = new Object();

        public Container Container { get; set; }
        private static CrCore instance;
        public static CrCore Instance(string token)
        {
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new CrCore(token);
                }
            }
            return instance;
        }
        /// <summary>
        /// Initialize your core.
        /// </summary>
        private CrCore(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentException("Token is nullable or empty.");
            }
            Container = new Funq.Container();

            Container.Register("Request", new Request(token));

            Container.Register<ICrCoreCards>(new CrCoreCards(Container.ResolveNamed<Request>("Request")));
            Container.Register<ICrCoreClans>(new CrCoreClans(Container.ResolveNamed<Request>("Request")));
        }
    }
}
