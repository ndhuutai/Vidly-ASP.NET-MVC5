namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id = 1");
            Sql("DELETE FROM Genres WHERE Id = 2");
            Sql("DELETE FROM Genres WHERE Id = 3");
            Sql("DELETE FROM Genres WHERE Id = 4");
        }
    }
}
