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

    public async Task<List<AssetTypeModel>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var assets = await GetAsync<List<AssetTypeModel>>(string.Empty, cancellationToken);

        return assets ?? [];
    }
}