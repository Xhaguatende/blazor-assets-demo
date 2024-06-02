// -------------------------------------------------------------------------------------
//  <copyright file="AssetModel.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Models.Assets;

using System.ComponentModel.DataAnnotations;

public class AssetModel
{
    [Required]
    public Guid? AssetTypeId { get; set; }

    [Required]
    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    public Guid? Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
}