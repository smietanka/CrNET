using CrNET.Types.Clans;
using CrNET.Types.Default;
using System.Collections.Generic;

namespace CrNET.Interfaces
{
    public interface ICrCoreClans
    {
        List<Clan> GetClans(SearchFilter filter);
    }
}
