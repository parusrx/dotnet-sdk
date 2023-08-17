// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Data;
using Dapper;
using Npgsql;
using ParusRx.Data.Core;

namespace ParusRx.Storage.Postgres;

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

            using var transaction = connection.BeginTransaction();

            var param = new DynamicParameters();
            param.Add("sID", id);
            param.Add("sNOTE", message);

            await connection.QueryAsync<int>("PARUS.PKG_PRXMB$SET_ERROR", param, commandType: CommandType.StoredProcedure);

            await transaction.CommitAsync();
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

            var param = new DynamicParameters();
            param.Add("sID", id);
            param.Add("bREQUEST", dbType: DbType.Binary, direction: ParameterDirection.Output);

            await connection.QueryAsync<int>("PARUS.PKG_PRXMB$GET_REQUEST", param, commandType: CommandType.StoredProcedure);

            return param.Get<byte[]>("bREQUEST");
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

            using var transaction = connection.BeginTransaction();

            var param = new DynamicParameters();
            param.Add("sID", id);
            param.Add("bRESPONSE", value: data, dbType: DbType.Binary, direction: ParameterDirection.Input);

            await connection.QueryAsync<int>("PARUS.PKG_PRXMB$SET_RESPONSE", param, commandType: CommandType.StoredProcedure);

            await transaction.CommitAsync();
        }
        catch(Exception ex)
        {
            throw new InvalidOperationException($"Failed to save response for request with id {id}", ex);
        }
    }
}
