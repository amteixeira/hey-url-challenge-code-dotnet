using hey_url_challenge_code_dotnet.Repository.AuxRepo;
using HeyUrlChallengeCodeDotnet.Data;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{

    public class BaseTest
    {
        public ApplicationContext context;
        public AuxRepo auxRepo;

        public BaseTest()
        {

        }
    }
}
