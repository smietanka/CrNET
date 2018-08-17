using CrNET.Interfaces;
using CrNET.Types.Default;
using NUnit.Framework;
using System;
using System.Linq;

namespace CrNET.Test
{
    [TestFixture]
    public class ClanTest
    {
        private const string TOKEN = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImQ2MjZmNzcwLTI0M2UtNDRlOS1iYWI4LTc5YTIzYmE5MzE5OCIsImlhdCI6MTUzNDU0MDMzNiwic3ViIjoiZGV2ZWxvcGVyLzA5NjJjZjFjLTJkMzQtMzk0MS0wYjM1LTI1NjNjMGY2MjY0MiIsInNjb3BlcyI6WyJyb3lhbGUiXSwibGltaXRzIjpbeyJ0aWVyIjoiZGV2ZWxvcGVyL3NpbHZlciIsInR5cGUiOiJ0aHJvdHRsaW5nIn0seyJjaWRycyI6WyI5NS4xNjAuMTU2LjQ0Il0sInR5cGUiOiJjbGllbnQifV19.NPVginb8SpAJDsFR9IKANgJYTnRtD-9egbZQjxQ8-GZ11ATfMgUpd239ARlVGfNYK05l-WdYKMTrlsS7reAjPg";
        private ICrCoreClans ClanCore;

        [OneTimeSetUp]
        public void InitializeCore()
        {
            ClanCore = CrCore.Instance(TOKEN).Container.Resolve<ICrCoreClans>();
        }

        [Test]
        public void GetClans_ShouldReturnException()
        {
            Assert.Throws<Exception>(() => { ClanCore.GetClans(new SearchFilter()); });
        }

        [Test]
        public void GetClansByName()
        {
            var clans = ClanCore.GetClans(new SearchFilter()
            {
                Name = "Pandemia"
            });

            Assert.IsTrue(clans.Any());
        }
    }
}
