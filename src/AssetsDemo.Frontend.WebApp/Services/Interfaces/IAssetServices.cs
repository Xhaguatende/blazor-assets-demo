// -------------------------------------------------------------------------------------
//  <copyright file="IAssetServices.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Interfaces;

using Models.Assets;

public interface IAssetServices
{
    Task CreateAsync(AssetModel asset, CancellationToken cancellationToken = default);

    Task<List<AssetRowModel>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AssetModel> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task UpdateAsync(AssetModel asset, CancellationToken cancellationToken = default);
}