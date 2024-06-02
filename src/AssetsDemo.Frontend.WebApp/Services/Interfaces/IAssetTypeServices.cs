// -------------------------------------------------------------------------------------
//  <copyright file="IAssetTypeServices.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Interfaces;

using Models.AssetTypes;

public interface IAssetTypeServices
{
    Task CreateAsync(AssetTypeModel assetTypeModel, CancellationToken cancellationToken = default);

    Task<List<AssetTypeModel>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<AssetTypeModel> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task UpdateAsync(AssetTypeModel assetTypeModel, CancellationToken cancellationToken = default);
}