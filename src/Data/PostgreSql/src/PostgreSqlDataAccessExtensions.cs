﻿// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Npgsql;
using ParusRx.Data.Core;

namespace ParusRx.Data.PostgreSql;

/// <summary>
/// Extension methods for <see cref="IConnection"/> to configure PostgreSQL.
/// </summary>
public static class PostgreSqlDataAccessExtensions
{
    /// <summary>
    /// Configures to connect to a PostgreSQL database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="connectionString">The connection string.</param>
    /// <returns>The <see cref="IConnection"/> so that additional calls can be chained.</returns>
    /// <exception cref="ArgumentNullException">The <paramref name="connection"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentNullException">The <paramref name="connectionString"/> is <c>null</c>.</exception>   
    public static IConnection UsePostgreSql(this IConnection connection, string connectionString)
    {
        ArgumentNullException.ThrowIfNull(connection, nameof(connection));
        ArgumentNullException.ThrowIfNull(connectionString, nameof(connectionString));

        connection.ConnectionFactory = new ConnectionFactory<NpgsqlConnection>(connectionString);

        return connection;
    }
}
