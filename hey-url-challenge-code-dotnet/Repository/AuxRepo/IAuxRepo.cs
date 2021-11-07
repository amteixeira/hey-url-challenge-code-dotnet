using hey_url_challenge_code_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Repository.AuxRepo
{
    public interface IAuxRepo
    {
        public IUrlRepository<UrlModel> UrlRepository { get; }
        void Commit();
    }
}
