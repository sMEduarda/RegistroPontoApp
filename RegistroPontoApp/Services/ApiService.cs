using System.Net.Http.Json;
using RegistroPontoApp.Models;

namespace RegistroPontoApp.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7290/")  // ← mude para a porta real da sua API
        };
    }

    public async Task<bool> SincronizarCheckInAsync(CheckInModel checkIn)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/checkin", checkIn);
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}