namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondary : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Credencial", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Credencial", c => c.Int(nullable: false));
        }
    }
}
