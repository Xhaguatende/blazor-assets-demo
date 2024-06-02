// -------------------------------------------------------------------------------------
//  <copyright file="AssetTypeModel.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Models.AssetTypes;

public class AssetTypeModel
{
    public string Description { get; set; } = string.Empty;
    public Guid? Id { get; set; }
    public string Name { get; set; } = string.Empty;
}