namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credenciales",
                c => new
                    {
                        NombreUsuario = c.String(nullable: false, maxLength: 128),
                        Contraseña = c.String(),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.NombreUsuario);
            
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
                        Credencial = c.Int(nullable: false),
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
