namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeededMoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate='2009-11-06', DateAdded='2016-05-04', StockAmount=5 WHERE Id = 1 ");
            Sql("UPDATE Movies SET ReleaseDate='2011-12-09', DateAdded='2016-05-04', StockAmount=4 WHERE Id = 2 ");
            Sql("UPDATE Movies SET ReleaseDate='2005-01-30', DateAdded='2016-05-04', StockAmount=2 WHERE Id = 3 ");
            Sql("UPDATE Movies SET ReleaseDate='2007-08-15', DateAdded='2016-06-01', StockAmount=3 WHERE Id = 4 ");
            Sql("UPDATE Movies SET ReleaseDate='2008-02-15', DateAdded='2016-02-20', StockAmount=7 WHERE Id = 5 ");

        }

        public override void Down()
        {
        }
    }
}
