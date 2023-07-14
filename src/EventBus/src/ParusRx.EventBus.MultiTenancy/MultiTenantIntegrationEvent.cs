// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ParusRx.EventBus.MultiTenancy;

/// <summary>
/// Represents an integration event with a tenant identifier.
/// </summary>
/// <param name="TenantId">The unique identifier of the tenant.</param>
public record MultiTenantIntegrationEvent(string TenantId) : IntegrationEvent;
