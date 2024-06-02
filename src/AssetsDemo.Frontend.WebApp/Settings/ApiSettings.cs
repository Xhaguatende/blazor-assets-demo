// -------------------------------------------------------------------------------------
//  <copyright file="ApiSettings.cs" company="{Company Name}">
//    Copyright (c) {Company Name}. All rights reserved.
//  </copyright>
// -------------------------------------------------------------------------------------

namespace AssetsDemo.Frontend.WebApp.Settings;

public class ApiSettings
{
    public string AssetsRoute { get; set; } = default!;
    public string AssetTypesRoute { get; set; } = default!;
    public string BaseUrl { get; set; } = default!;
}