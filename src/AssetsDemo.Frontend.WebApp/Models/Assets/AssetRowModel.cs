// -------------------------------------------------------------------------------------
//  <copyright file="AssetRowModel.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Models.Assets;

public class AssetRowModel
{
    public string AssetType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}