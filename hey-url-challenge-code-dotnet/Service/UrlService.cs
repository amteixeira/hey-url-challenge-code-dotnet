using hey_url_challenge_code_dotnet.Models;
using hey_url_challenge_code_dotnet.Repository;
using hey_url_challenge_code_dotnet.Repository.AuxRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hey_url_challenge_code_dotnet.Service
{

    public class UrlService
    {
        private readonly AuxRepo auxRepo;

        public UrlService(AuxRepo auxRepo)
        {
            this.auxRepo = auxRepo;
        }

        public UrlModel GetUrl(Guid id)
        {            
            UrlModel url = auxRepo.UrlRepository.Get(x => x.Id.Equals(id));
            return url;
        }

        public List<UrlModel> getAllUrls()
        {

            return auxRepo.UrlRepository.GetAll().ToList();
        }

        public UrlModel AddUrl(UrlModel urlModel)
        {
            urlModel.ShortUrl = urlModel.ShortUrl.ToUpper();
            urlModel.Id = Guid.NewGuid();
            UrlValidation(urlModel.ShortUrl);
            return new UrlModel();
        }

        public void UpdateModel(Guid Id, UrlModel urlModel)
        {

        }

        public void DeleteUrl(UrlModel urlModel)
        {

        }

        private void UrlValidation(string shortUrl)
        {
            if (GetUrlByShortUrl(shortUrl) != null)
                throw new Exception("Short Url already exixtes");
            if (shortUrl.Contains(" "))
                throw new Exception("White spaces is not allowed");
            if (shortUrl.Contains(" "))
                throw new Exception("White spaces is not allowed");
            if (Regex.IsMatch(shortUrl, "[a-zA-Z]+"))
                throw new Exception("Special characters is not accepted");
        }

        private UrlModel GetUrlByShortUrl(string shortUrl)
        {
            return auxRepo.UrlRepository.Get(x => x.ShortUrl.Equals(shortUrl));
        }

    }
}
