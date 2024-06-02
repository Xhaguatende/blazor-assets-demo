// -------------------------------------------------------------------------------------
//  <copyright file="IAssetTypeServices.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Services.Interfaces;

using Models.AssetTypes;

public interface IAssetTypeServices
{
    Task<List<AssetTypeModel>> GetAllAsync(CancellationToken cancellationToken = default);
}