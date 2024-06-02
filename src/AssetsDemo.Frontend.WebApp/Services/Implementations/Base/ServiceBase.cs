// -------------------------------------------------------------------------------------
//  <copyright file="ServiceBase.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Implementations.Base;

public abstract class ServiceBase
{
    private readonly HttpClient _httpClient;

    protected ServiceBase(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    protected async Task DeleteAsync(string uri, CancellationToken cancellationToken = default)
    {
        await _httpClient.DeleteAsync(uri, cancellationToken);
    }

    protected async Task<T?> GetAsync<T>(string uri, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetFromJsonAsync<T>(uri, cancellationToken);

        return response;
    }

    protected async Task PostAsync<T>(string uri, T data, CancellationToken cancellationToken = default)
    {
        await _httpClient.PostAsJsonAsync(uri, data, cancellationToken);
    }

    protected async Task<TValue?> PostAsync<T, TValue>(string uri, T data, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsJsonAsync(uri, data, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return default;
        }

        var result = await response.Content.ReadFromJsonAsync<TValue>(cancellationToken: cancellationToken);

        return result!;
    }

    protected async Task PutAsync<T>(string uri, T data, CancellationToken cancellationToken = default)
    {
        await _httpClient.PutAsJsonAsync(uri, data, cancellationToken);
    }

    protected async Task<TValue?> PutAsync<T, TValue>(string uri, T data, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PutAsJsonAsync(uri, data, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return default;
        }

        var result = await response.Content.ReadFromJsonAsync<TValue>(cancellationToken: cancellationToken);

        return result!;
    }
}