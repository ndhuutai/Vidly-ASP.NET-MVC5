namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeededCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate ='1980-01-01' WHERE Id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}
