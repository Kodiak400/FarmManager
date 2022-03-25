using FarmManager.Shared;
using System.Text.Json;

namespace FarmManager.Client.Services
{
    public class AnimalsService
    {        
        private readonly HttpClient _httpClient;

        public AnimalsService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<IEnumerable<Animal>> GetAnimals() 
        {            
            var response = await _httpClient.GetAsync("Animals");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<List<Animal>>(responseBody));
            }
            else
                return null;
        }

        public async Task<Animal> GetAnimal(int id)
        {
            var response = await _httpClient.GetAsync($"Animals/{id}");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<Animal>(responseBody));
            }
            else
                return null;
        }

        public async Task<bool> AddAnimal(Animal animal)
        {
            var serializedAnimal = JsonSerializer.Serialize(animal);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Animals");

            requestMessage.Content = new StringContent(serializedAnimal);

            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<bool>(responseBody));
            }
            else
                return false;
        }

        public async Task<bool> UpdateAnimal(Animal animal, int id)
        {
            var serializedAnimal = JsonSerializer.Serialize(animal);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"Animals/{id}");

            requestMessage.Content = new StringContent(serializedAnimal);

            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<bool>(responseBody));
            }
            else
                return false;
        }

        public async Task<bool> DeleteAnimal(int id)
        {
            var response = await _httpClient.DeleteAsync($"Animals/{id}");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<bool>(responseBody));
            }
            else
                return false;
        }

        public async Task<IEnumerable<Species>> GetSpecies()
        {
            var response = await _httpClient.GetAsync($"Species");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<List<Species>>(responseBody));
            }
            else
                return null;
        }

        public async Task<IEnumerable<Breed>> GetBreeds()
        {
            var response = await _httpClient.GetAsync($"Breeds");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<List<Breed>>(responseBody));
            }
            else
                return null;
        }

        public async Task<IEnumerable<TransferReason>> GetTransferReasons()
        {
            var response = await _httpClient.GetAsync($"TransferReasons");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<List<TransferReason>>(responseBody));
            }
            else
                return null;
        }

        public async Task<IEnumerable<Sex>> GetSexes()
        {
            var response = await _httpClient.GetAsync($"Sexes");

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonSerializer.Deserialize<List<Sex>>(responseBody));
            }
            else
                return null;
        }
    }
}
