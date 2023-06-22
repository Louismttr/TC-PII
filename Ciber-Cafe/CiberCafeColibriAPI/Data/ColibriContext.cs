using CiberCafeColibriAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CiberCafeColibriAPI.Data
{
    public class ColibriContext : DbContext
    {
        public ColibriContext(DbContextOptions<ColibriContext> options) : base(options) 
        { 
            
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetallesVenta> DetalleVentas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetallesCompra> DetallesCompras { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<DashBoard> DashBoards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Empleados
            modelBuilder.Entity<Empleado>().HasData(
                     new Empleado()
                     {
                         EmpleadoId = 0001,
                         DNI = "ASD1205FG",
                         Contraseña = "BAS0001",
                         RolId = 1000,
                         NombresEmpleado = "Karla",
                         ApellidosEmpleados = "Patricia",
                         Telofono = 22556677,
                         Direccion = "De los talleres modernos 3c al sur 1/2c arriba",
                         Salario = 8000
                     },
                     new Empleado()
                     {
                         EmpleadoId = 0002,
                         DNI = "BSA2004FG",
                         Contraseña = "P41lo+fr1zz0",
                         RolId = 1404,
                         NombresEmpleado = "Marcus",
                         ApellidosEmpleados = "Galán Blanco",
                         Telofono = 19384762,
                         Direccion = "Del reparto Tres fuentes 2c arriba y 1c al sur",
                         Salario = 7000
                     },
                    new Empleado()
                    {
                        EmpleadoId = 0003,
                        DNI = "AC3056DF",
                        Contraseña = "l4Ma¿37hA",
                        RolId = 1303,
                        NombresEmpleado = "Eleazar Santiago",
                        ApellidosEmpleados = "Torres Ferguson",
                        Telofono = 91827345,
                        Direccion = "De la refresquería Mi Niño 1c al sur y 3c abajo",
                        Salario = 6000
                    },
                    new Empleado()
                    {
                        EmpleadoId = 0004,
                        DNI = "RG7623BD",
                        Contraseña = "Tra00pe1l1a2d04",
                        RolId = 2000,
                        NombresEmpleado = "Juan Pedro",
                        ApellidosEmpleados = "Rodríguez Rodríguez",
                        Telofono = 12209345,
                        Direccion = "Del multicentro Las Pepitas 2c al lago",
                        Salario = 5000

                    },
                    new Empleado()
                    {
                        EmpleadoId = 0005,
                        DNI = "QE1203AS",
                        Contraseña = "Añesartnoc",
                        RolId = 1001,
                        NombresEmpleado = "Alejandro",
                        ApellidosEmpleados = "Puentes Contreras",
                        Telofono = 98761243,
                        Direccion = "Del parque Alfonso Mayor 5c al sur",
                        Salario = 4000
                    }); 
            #endregion
            
            #region Roles
            modelBuilder.Entity<Rol>().HasData(
                   new Rol()
                   {
                       RolId = 1000,
                       RolesEmpleado = "Encargada general de informática"
                   },
                   new Rol()
                   {
                       RolId = 1404,
                       RolesEmpleado = "Mesero"
                   },
                   new Rol()
                   {
                       RolId = 1303,
                       RolesEmpleado = "Cajero"
                   },
                   new Rol()
                   {
                       RolId = 2000,
                       RolesEmpleado = "Conserje"
                   },
                   new Rol()
                   {
                       RolId = 9009,
                       RolesEmpleado = "Gerente",
                   },
                   new Rol()
                   {
                       RolId = 2112,
                       RolesEmpleado = "Contador",
                   },
                   new Rol()
                   {
                       RolId = 1001,
                       RolesEmpleado = "Encargado general de compras"
                   });
            #endregion

            #region Ventas
            modelBuilder.Entity<Venta>().HasData(
                new Venta()
                {
                    VentasId = 0001,
                    ClienteId = 125,
                    EmpleadoId = 0001,
                    TipoComprobante = "Factura",
                    SerieComprobante = "FA01",
                    Fecha = DateTime.Parse("11/09/2020"),
                    Total = 250.50M
                },
                new Venta()
                {
                    VentasId = 0002,
                    ClienteId = 135,
                    EmpleadoId = 0002,
                    TipoComprobante = "Factura",
                    SerieComprobante = "FA02",
                    Fecha = DateTime.Parse("01/11/2020"),
                    Total = 200.55M
                },
                new Venta()
                {
                    VentasId = 0003,
                    ClienteId = 145,
                    EmpleadoId = 0004,
                    TipoComprobante = "Factura",
                    SerieComprobante = "FA03",
                    Fecha = DateTime.Parse("30/10/2020"),
                    Total = 200.00M
                });
            #endregion

            #region DetalleVentas
            modelBuilder.Entity<DetallesVenta>().HasData(
                new DetallesVenta()
                {
                    DetalleVentaId = 1,
                    VentaId = 0001,
                    ProductoId = 1,
                    PrecioVenta = 15.00M,
                    Cantidad = 25,
                    SubTotal = 10
                },
                new DetallesVenta()
                {
                    DetalleVentaId = 2,
                    VentaId = 0002,
                    ProductoId = 4,
                    PrecioVenta = 9.95M,
                    Cantidad = 55,
                    SubTotal = 15
                },
                new DetallesVenta()
                {
                    DetalleVentaId = 3,
                    VentaId = 0003,
                    ProductoId = 3,
                    PrecioVenta = 15.00M,
                    Cantidad = 45,
                    SubTotal = 10
                });
            #endregion

            #region Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    ClienteId = 125,
                    NombresCliente = "Anderson",
                    ApellidosCliente = "Reyes Cortés",
                    RUC = "193258476212",
                    Telefono = 23459786,
                    Direccion = "Del parque Alfonso Mayor 1c al sur"
                },
                new Cliente()
                {
                    ClienteId = 135,
                    NombresCliente = "Oscar",
                    ApellidosCliente = "Lopez Perez",
                    RUC = "103258565373",
                    Telefono = 23459786,
                    Direccion = "Del parque Caña Verde 3c al sur"
                },
                new Cliente()
                {
                    ClienteId = 145,
                    NombresCliente = "Jeremy",
                    ApellidosCliente = "Martínez Ortis",
                    RUC = "17482147456",
                    Telefono = 47421839,
                    Direccion = "De los talleres modernos 5c al sur y 1c arriba"
                });
            #endregion

            #region Productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    ProductoId = 1,
                    CategoriaId = 1,
                    MarcaId = 1,
                    Descripcion = "Dona glaseada",
                    PrecioCompra = 12.50M,
                    PrecioVenta = 15.00M,
                    Stock = 25,
                    Estado = "Con Etiqueta"
                },
                new Producto()
                {
                    ProductoId = 2,
                    CategoriaId = 1,
                    MarcaId = 3,
                    Descripcion = "Pan Bimbo artesano",
                    PrecioCompra = 20.55M,
                    PrecioVenta = 21.00M,
                    Stock = 35,
                    Estado = "Con Etiqueta"
                },
                new Producto()
                {
                    ProductoId = 3,
                    CategoriaId = 2,
                    MarcaId = 5,
                    Descripcion = "Taza de café capucchino",
                    PrecioCompra = 10.50M,
                    PrecioVenta = 15.00M,
                    Stock = 45,
                    Estado = "Como Nuevo"
                },
                new Producto()
                {
                    ProductoId = 4,
                    CategoriaId = 2,
                    MarcaId = 4,
                    Descripcion = "Taza de café negro",
                    PrecioCompra = 7.50M,
                    PrecioVenta = 9.95M,
                    Stock = 55,
                    Estado = "Semi Nuevo"
                },
                new Producto()
                {
                    ProductoId = 5,
                    CategoriaId = 2,
                    MarcaId = 8,
                    Descripcion = "Vaso de gaseosa",
                    PrecioCompra = 11.10M,
                    PrecioVenta = 15.00M,
                    Stock = 54,
                    Estado = "Como Nuevo"
                },
                new Producto()
                {
                    ProductoId = 6,
                    CategoriaId = 3,
                    MarcaId = 11,
                    Descripcion = "Computadora portátil (Razer)",
                    PrecioCompra = 300.00M,
                    PrecioVenta = 350.00M,
                    Stock = 15,
                    Estado = "Como Nuevo"
                },
                new Producto()
                {
                    ProductoId = 7,
                    CategoriaId = 3,
                    MarcaId = 12,
                    Descripcion = "Computadora portátil (Microsoft Surface)",
                    PrecioCompra = 250.00M,
                    PrecioVenta = 275.00M,
                    Stock = 20,
                    Estado = "Semi Nuevo"
                },
                new Producto()
                {
                    ProductoId = 8,
                    CategoriaId = 3,
                    MarcaId = 10,
                    Descripcion = "Computadora portátil (HP)",
                    PrecioCompra = 195.50M,
                    PrecioVenta = 200.00M,
                    Stock = 10,
                    Estado = "Con Imperfecciones"
                });
            #endregion

            #region Marcas
            modelBuilder.Entity<Marca>().HasData(
                new Marca()
                {
                    IMarcaId = 1,
                    Marcas = "Krispy Kreme"
                },
                new Marca()
                {
                    IMarcaId = 2,
                    Marcas = "Crisco"
                },
                new Marca()
                {
                    IMarcaId = 3,
                    Marcas = "Grupo Bimbo"
                },
                new Marca()
                {
                    IMarcaId = 4,
                    Marcas = "Café las Flores"
                },
                new Marca()
                {
                    IMarcaId = 5,
                    Marcas = "Café Presto"
                },
                new Marca()
                {
                    IMarcaId = 6,
                    Marcas = "Casa del Café"
                },
                new Marca()
                {
                    IMarcaId = 7,
                    Marcas = "Coca Cola"
                },
                new Marca()
                {
                    IMarcaId = 8,
                    Marcas = "Pepsi"
                },
                new Marca()
                {
                    IMarcaId = 9,
                    Marcas = "Apple"
                },
                new Marca()
                {
                    IMarcaId = 10,
                    Marcas = "HP"
                },
                new Marca()
                {
                    IMarcaId = 11,
                    Marcas = "Razer"
                },
                new Marca()
                {
                    IMarcaId = 12,
                    Marcas = "Microsoft Surface"
                }
                );
            #endregion

            #region Categoria

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    CategoriaId = 1,
                    Categorias = "Comida"
                },
                new Categoria()
                {
                    CategoriaId = 2,
                    Categorias = "Bebida"
                },
                new Categoria()
                {
                    CategoriaId = 3,
                    Categorias = "Computadora"
                });
            #endregion

            #region DetallesCompras
            modelBuilder.Entity<DetallesCompra>().HasData(
                new DetallesCompra()
                {
                    DetalleCompraId = 1,
                    CompraId = 0001,
                    ProductoId = 2,
                    PrecioCompra = 20.55M,
                    Cantidad = 35,
                    SubTotal = 15
                },
                new DetallesCompra()
                {
                    DetalleCompraId = 2,
                    CompraId = 0002,
                    ProductoId = 7,
                    PrecioCompra = 250.00M,
                    Cantidad = 20,
                    SubTotal = 5
                },
                new DetallesCompra()
                {
                    DetalleCompraId = 3,
                    CompraId = 0003,
                    ProductoId = 5,
                    PrecioCompra = 11.10M,
                    Cantidad = 54,
                    SubTotal = 12
                });
            #endregion

            #region Compras
            modelBuilder.Entity<Compra>().HasData(
                new Compra()
                {
                    CompraId = 0001,
                    SereiComprobante = "FA11",
                    Fecha = DateTime.Parse("01/01/2020"),
                    ProveedorId = 1,
                    Total = 215.00M
                },
                new Compra()
                {
                    CompraId = 0002,
                    SereiComprobante = "FA20",
                    Fecha = DateTime.Parse("01/03/2020"),
                    ProveedorId = 2,
                    Total = 225.50M
                },
                new Compra()
                {
                    CompraId = 0003,
                    SereiComprobante = "FA17",
                    Fecha = DateTime.Parse("01/02/2020"),
                    ProveedorId = 3,
                    Total = 105.00M
                });
            #endregion

            #region Proveedores
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor()
                {
                    ProveedorId = 1,
                    RazonSocial = "Arus Soda Resale, S.A.",
                    RUC = "29432100457",
                    Telefono = 19932651,
                    Direccion = "Del puente Pablito 1c al lago"
                },
                new Proveedor()
                {
                    ProveedorId = 2,
                    RazonSocial = "Servicios de Repostería, S.A.",
                    RUC = "57102110407",
                    Telefono = 10037158,
                    Direccion = "De los talleres modernos 1c al sur 4c arriba"
                },
                new Proveedor()
                {
                    ProveedorId = 3,
                    RazonSocial = "Tienda de Computación Sevasa, S.A.",
                    RUC = "10501219320",
                    Telefono = 36912153,
                    Direccion = "Calle principal de altamira, del bdf 1/2 c al sur"
                });
            #endregion

            #region Usuario
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    UserName = "Luisa",
                    Password = 12345678,
                    Role = "Administrador",
                    Email = "luisacrossway@gmail.com"
                },
                new User()
                {
                    Id = 2,
                    UserName = "Nelio",
                    Password = 87654321,
                    Role = "Contador",
                    Email = "ngomezanderson@gmail.com"
                },
                new User()
                {
                    Id = 3,
                    UserName = "Ernesto",
                    Password = 09786543,
                    Role = "Economista",
                    Email = "gabielurcuyo14@gmail.com"
                });
            #endregion

            modelBuilder.Entity<Nomina>().HasData(
               new Nomina()
               {
                   NomindaId = 1,
                   EmpleadoId = 0001,
                   Nombre = "Karla",
                   Apellido = "Patricia",
                   SalarioBruto = 8000,
                   HorasExtras = 10,
                   PrecioHorasExtras = 50,
                   PagoHorasExtras = 500,
                   BonoTransporte = 100,
                   TotalAsignaciones = 600,
                   SeguroMedico = 500,
                   AdelantoSueldo = 200,
                   TotalDeducciones = 300,
                   SalarioNeto = 8300
               });
        }

    }
}
