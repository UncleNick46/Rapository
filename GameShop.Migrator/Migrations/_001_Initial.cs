using ThinkingHome.Migrator.Framework;

namespace GameShop.Migrator.Migrations
{
    [Migration(1)]
    public class _001_Initial : Migration
    {
        #region Initial Script

        private string Script => @"
            create schema if not exists ps;

            create table ps.categories
            (
                id    uuid              not null primary key,
                title character varying not null
            );
        ";

        #endregion

        public override void Apply() => Database.ExecuteNonQuery(Script);
    }
}
