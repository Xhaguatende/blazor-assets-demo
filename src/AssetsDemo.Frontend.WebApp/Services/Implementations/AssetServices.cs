// -------------------------------------------------------------------------------------
//  <copyright file="AssetServices.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Implementations;

using Base;
using Interfaces;
using Models.Assets;

public class AssetServices : ServiceBase, IAssetServices
{
    public AssetServices(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task CreateAsync(AssetModel asset, CancellationToken cancellationToken = default)
    {
        await PostAsync(string.Empty, asset, cancellationToken);
    }

    public async Task<List<AssetRowModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var assets = await GetAsync<List<AssetRowModel>>(string.Empty, cancellationToken);

        return assets ?? [];
    }

    public async Task<AssetModel> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await GetAsync<AssetModel>($"{id}", cancellationToken) ?? default!;
    }

    public async Task UpdateAsync(AssetModel asset, CancellationToken cancellationToken = default)
    {
        await PutAsync(string.Empty, asset, cancellationToken);
    }
}