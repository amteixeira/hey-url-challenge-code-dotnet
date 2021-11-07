using hey_url_challenge_code_dotnet.Models;
using HeyUrlChallengeCodeDotnet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Repository.AuxRepo
{
    public class AuxRepo : IAuxRepo
    {
        private readonly ApplicationContext context = null;

        public AuxRepo(ApplicationContext context)
        {
            this.context = context;
        }

        private UrlRepository<UrlModel> Repository { get; set; }

        public IUrlRepository<UrlModel> UrlRepository
        {
            get
            {
                if (Repository == null)
                    Repository = new UrlRepository<UrlModel>(context);

                return Repository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
