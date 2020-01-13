namespace FluentMigrator.Sample.Migrations
{
    [Migration(6)]
    class AddEmailTo_sp_SelectUsers : Migration
    {
        public override void Up()
        {
            Execute.Script(@"FluentMigrator.Sample\StoredProcedures\sp_SelectUsers.sql");
        }

        public override void Down()
        {
        }
    }
}
