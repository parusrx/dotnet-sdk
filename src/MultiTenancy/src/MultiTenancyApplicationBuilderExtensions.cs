// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Builder;

namespace ParusRx.MultiTenancy;

/// <summary>
/// Multi-tenancy application builder extensions.
/// </summary>
/// <remarks>
/// <para>Use <see cref="UseMultiTenancy"/> to enable multi-tenancy.</para>
/// </remarks>
public static class MultiTenancyApplicationBuilderExtensions
{
    /// <summary>
    /// Use multi-tenancy.
    /// </summary>
    /// <param name="app">Application builder.</param>
    /// <returns>Application builder.</returns>
    public static IApplicationBuilder UseMultiTenancy(this IApplicationBuilder app)
        => app.UseMiddleware<MultiTenancyMiddleware>();
}
