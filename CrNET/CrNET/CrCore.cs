using System;
using CocNET.Interfaces;
using CocNET.Services;
using CrNET.Methods;
using Funq;

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

            Container.Register<Request>("Request", new Request(token));

            Container.Register<ICrCoreCards>(new CrCoreCards(Container.ResolveNamed<Request>("Request")));
        }
    }
}
