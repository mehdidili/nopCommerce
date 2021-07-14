using System;
using System.Reflection;
using FluentMigrator.Builders.Create;
using FluentMigrator.Expressions;

namespace Nop.Data.Migrations
{
    /// <summary>
    /// Represents a migration manager
    /// </summary>
    public interface IMigrationManager
    {
        /// <summary>
        /// Executes an Up for all found unapplied migrations
        /// </summary>
        /// <param name="assembly">Assembly to find migrations</param>
        /// <param name="migrationProcessType">Type of migration process</param>
        void ApplyUpMigrations(Assembly assembly, MigrationProcessType migrationProcessType = MigrationProcessType.Install);

        /// <summary>
        /// Executes a Down for all found applied migrations
        /// </summary>
        /// <param name="assembly">Assembly to find migrations</param>
        /// <param name="migrationProcessType">Type of migration process</param>
        void ApplyDownMigrations(Assembly assembly, MigrationProcessType migrationProcessType = MigrationProcessType.Install);
    }
}