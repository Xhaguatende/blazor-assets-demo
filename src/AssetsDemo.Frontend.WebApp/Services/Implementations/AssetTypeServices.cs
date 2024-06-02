// -------------------------------------------------------------------------------------
//  <copyright file="AssetTypeServices.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Implementations;

using System.Threading;
using Base;
using Interfaces;
using Models.AssetTypes;

public class AssetTypeServices : ServiceBase, IAssetTypeServices
{
    public AssetTypeServices(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task CreateAsync(AssetTypeModel assetTypeModel, CancellationToken cancellationToken = default)
    {
        await PostAsync(string.Empty, assetTypeModel, cancellationToken);
    }

    public async Task<List<AssetTypeModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var assets = await GetAsync<List<AssetTypeModel>>(string.Empty, cancellationToken);

        return assets ?? [];
    }

    public async Task<AssetTypeModel> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await GetAsync<AssetTypeModel>($"{id}", cancellationToken) ?? default!;
    }

    public async Task UpdateAsync(AssetTypeModel assetTypeModel, CancellationToken cancellationToken = default)
    {
        await PutAsync(string.Empty, assetTypeModel, cancellationToken);
    }
}