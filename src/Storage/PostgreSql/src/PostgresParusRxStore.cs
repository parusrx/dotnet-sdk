﻿// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Data;
using Npgsql;
using ParusRx.Data.Core;

namespace ParusRx.Storage.PostgreSql;

/// <summary>
/// Provides methods allowing to manage the metadata stored in a PostgreSQL database.
/// </summary>
internal sealed class PostgresParusRxStore : IParusRxStore
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostgresParusRxStore"/>.
    /// </summary>
    /// <param name="connection">The <see cref="IConnection"/>.</param>
    public PostgresParusRxStore(IConnection connection)
    {
        Connection = connection;
    }

    /// <summary>
    /// The <see cref="IConnection"/>.
    /// </summary>
    public IConnection Connection { get; }

    /// <inheritdoc/>
    public async Task ErrorAsync(string id, string message)
    {
        try
        {
            using var connection = (NpgsqlConnection)Connection.ConnectionFactory.CreateConnection();
            await connection.OpenAsync();

            using var command = new NpgsqlCommand("PARUS.PKG_PRXMB$SET_ERROR(@sID, @sNOTE)", connection);
            command.Parameters.AddWithValue("sID", id);
            command.Parameters.AddWithValue("sNOTE", message);

            await command.ExecuteNonQueryAsync();
        }
        catch(Exception ex)
        {
            throw new InvalidOperationException($"Failed to set error for request with id {id}", ex);
        }
    }

    /// <inheritdoc/>
    public async Task<byte[]> ReadDataRequestAsync(string id)
    {
        try
        {
            using var connection = (NpgsqlConnection)Connection.ConnectionFactory.CreateConnection();
            await connection.OpenAsync();

            using var command = new NpgsqlCommand("PARUS.PKG_PRXMB$GET_REQUEST(@sID)", connection);
            command.Parameters.AddWithValue("sID", id);

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                return reader.GetFieldValue<byte[]>(0);
            }

            return Array.Empty<byte>();
        }
        catch(Exception ex)
        {
            throw new InvalidOperationException($"Failed to read request with id {id}", ex);
        }
    }

    /// <inheritdoc/>
    public async Task SaveDataResponseAsync(string id, byte[] data)
    {
        try
        {
            using var connection = (NpgsqlConnection)Connection.ConnectionFactory.CreateConnection();
            await connection.OpenAsync();

            using var command = new NpgsqlCommand("PARUS.PKG_PRXMB$SET_RESPONSE(@sID, @bRESPONSE)", connection);
            command.Parameters.AddWithValue("sID", id);
            command.Parameters.AddWithValue("bRESPONSE", data);

            await command.ExecuteNonQueryAsync();
        }
        catch(Exception ex)
        {
            throw new InvalidOperationException($"Failed to save response for request with id {id}", ex);
        }
    }
}
