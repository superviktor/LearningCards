using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LearningCardsWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LearningCardsWebUI.Controllers
{
    public class DeckController : Controller
    {
        private static HttpClient Client;
        private static readonly string ApiUrl = "https://localhost:44306/api/";

        public DeckController()
        {
            Client = new HttpClient { BaseAddress = new Uri(ApiUrl) };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<ViewResult> Index()
        {
            var apiUrl = ApiUrl + "deck";
            var response = await Client.GetAsync(apiUrl);
            IEnumerable<DeckModel> decks = null;
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                decks = JsonConvert.DeserializeObject<IEnumerable<DeckModel>>(data);
            }
            return View(decks);
        }
    }
}