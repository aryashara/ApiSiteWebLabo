using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace ApiSiteWeb.Tools.Database
{
    public static class DbConnectionExtensions
    {
        public static int ExecuteNonQuery(this DbConnection connection, string query, bool isProcedure = false, object? parameters = null)
        {
            EnsureOpenConnection(connection);

            using (DbCommand command = CreateCommand(connection, query, isProcedure, parameters))
            {
                return command.ExecuteNonQuery();
            }
        }

        public static object? ExecuteScalar(this DbConnection connection, string query, bool isProcedure = false, object? parameters = null)
        {
            EnsureOpenConnection(connection);

            using (DbCommand command = CreateCommand(connection, query, isProcedure, parameters))
            {
                object? result = command.ExecuteScalar();
                return result is DBNull ? null : result;
            }
        }

        public static IEnumerable<TResult> ExecuteReader<TResult>(this DbConnection connection, string query, Func<IDataRecord, TResult> selector, bool isProcedure = false, object? parameters = null)
        {
            ArgumentNullException.ThrowIfNull(selector);
            EnsureOpenConnection(connection);

            using (DbCommand command = CreateCommand(connection, query, isProcedure, parameters))
            using (DbDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    yield return selector(reader);
                }
            }
        }

        private static void EnsureOpenConnection(DbConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("La connexion doit être ouverte pour exécuter la requête");
            }
        }

        private static DbCommand CreateCommand(DbConnection connection, string query, bool isProcedure, object? parameters)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = query;

            if (isProcedure)
            {
                command.CommandType = CommandType.StoredProcedure;
            }

            if (parameters is not null)
            {
                Type type = parameters.GetType();

                foreach (PropertyInfo propertyInfo in type.GetProperties().Where(p => p.CanRead))
                {
                    DbParameter parameter = command.CreateParameter();
                    parameter.ParameterName = propertyInfo.Name;
                    parameter.Value = propertyInfo.GetValue(parameters) ?? DBNull.Value;

                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }
    }
}
