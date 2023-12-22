namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credenciales",
                c => new
                    {
                        Usuario = c.String(nullable: false, maxLength: 128),
                        Contraseña = c.String(),
                    })
                .PrimaryKey(t => t.Usuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Identificacion = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        UltimoPago = c.DateTime(nullable: false),
                        Eps = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Credenciales");
        }
    }
}
