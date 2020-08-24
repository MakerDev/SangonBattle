using SangonBattle.Shared;
using SangonBattle.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SangonBattle.Client.Helpers
{
    public class SurveyRepository
    {
        private readonly string _url = "api/survey";
        private readonly IHttpService _httpService;

        public SurveyRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<Question>> GetQuestions()
        {
            var response = await _httpService.GetAsync<List<Question>>(_url);

            if (response.Success)
            {
                return response.Response;
            }

            throw new ApplicationException(await response.GetBodyAsync());
        }

        public async Task<ISurveyResult> GetResult(int id)
        {
            var response = await _httpService.GetAsync<SurveyResult>($"{_url}/results/{id}");

            if (response.Success)
            {
                return response.Response;
            }

            throw new ApplicationException(await response.GetBodyAsync());
        }

        public async Task<int> Submit(List<Submission> submissions)
        {
            var response = await _httpService.PostAsync<List<Submission>, int>($"{_url}/submit", submissions);

            if (response.Success)
            {
                return response.Response;
            }

            throw new ApplicationException(await response.GetBodyAsync());
        }
    }
}
