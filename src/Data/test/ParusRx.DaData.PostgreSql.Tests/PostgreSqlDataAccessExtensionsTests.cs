// Copyright (c) The Parus RX Authors. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Npgsql;

using ParusRx.Data.Core;
using ParusRx.Data.PostgreSql;

namespace ParusRx.DaData.PostgreSql.Tests;

public class PostgreSqlDataAccessExtensionsTests
{
    private const string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres;";

    [Fact]
    public void UsePostgreSQL_ThrowsAnException_WhenConnectionIsNull()
    {
        // Arrange
        IConnection? connection = null;

        // Act
        var exception = Assert.Throws<ArgumentNullException>(() => connection!.UsePostgreSql(ConnectionString));

        // Assert
        Assert.Equal("connection", exception.ParamName);
    }

    [Fact]
    public void UsePostgreSQL_ThrowsAnException_WhenConnectionStringIsNull()
    {
        // Arrange
        var connection = new Connection();

        // Act
        var exception = Assert.Throws<ArgumentNullException>(() => connection.UsePostgreSql(null!));

        // Assert
        Assert.Equal("connectionString", exception.ParamName);
    }

    [Fact]
    public void UsePostgreSQL_SetsTheConnectionFactory()
    {
        // Arrange
        var connection = new Connection();

        // Act
        connection.UsePostgreSql(ConnectionString);

        // Assert
        Assert.NotNull(connection.ConnectionFactory);
    }

    [Fact]
    public void UsePostgreSQL_SetsTheConnectionFactoryToPostgreSQL()
    {
        // Arrange
        var connection = new Connection();

        // Act
        connection.UsePostgreSql(ConnectionString);

        // Assert
        Assert.IsType<ConnectionFactory<NpgsqlConnection>>(connection.ConnectionFactory);
    }

    [Fact]
    public void AddDataAccess_RegisterPostgreSQLDataAccess()
    {
        // Arrange
        var serviceCollection = new ServiceCollection();

        // Act
        serviceCollection.AddDataAccess(c => c.UsePostgreSql(ConnectionString));

        // Assert
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var connection = serviceProvider.GetRequiredService<IConnection>();
        Assert.NotNull(connection);
        Assert.IsType<NpgsqlConnection>(connection.ConnectionFactory.CreateConnection());
    }
}