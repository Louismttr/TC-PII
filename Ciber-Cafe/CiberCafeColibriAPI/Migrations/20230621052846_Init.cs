using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CiberCafeColibriAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Categorias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    NombresCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidosCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IMarcaId = table.Column<int>(type: "int", nullable: false),
                    Marcas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IMarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RUC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false),
                    RolesEmpleado = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "IMarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    SereiComprobante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    NombresEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidosEmpleados = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Telofono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesCompras",
                columns: table => new
                {
                    DetalleCompraId = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesCompras", x => x.DetalleCompraId);
                    table.ForeignKey(
                        name: "FK_DetallesCompras_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesCompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DashBoards",
                columns: table => new
                {
                    DashBoardId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    MarcasId = table.Column<int>(type: "int", nullable: false),
                    IMarcaId = table.Column<int>(type: "int", nullable: true),
                    CategoriasId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    TotalVentas = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoards", x => x.DashBoardId);
                    table.ForeignKey(
                        name: "FK_DashBoards_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId");
                    table.ForeignKey(
                        name: "FK_DashBoards_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashBoards_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashBoards_Marcas_IMarcaId",
                        column: x => x.IMarcaId,
                        principalTable: "Marcas",
                        principalColumn: "IMarcaId");
                    table.ForeignKey(
                        name: "FK_DashBoards_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashBoards_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nominas",
                columns: table => new
                {
                    NomindaId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalarioBruto = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    HorasExtras = table.Column<int>(type: "int", nullable: false),
                    PrecioHorasExtras = table.Column<int>(type: "int", nullable: false),
                    PagoHorasExtras = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BonoTransporte = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalAsignaciones = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SeguroMedico = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    AdelantoSueldo = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalDeducciones = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SalarioNeto = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominas", x => x.NomindaId);
                    table.ForeignKey(
                        name: "FK_Nominas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentasId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    TipoComprobante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerieComprobante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentasId);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVentas",
                columns: table => new
                {
                    DetalleVentaId = table.Column<int>(type: "int", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    VentasId = table.Column<int>(type: "int", nullable: true),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVentas", x => x.DetalleVentaId);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVentas_Ventas_VentasId",
                        column: x => x.VentasId,
                        principalTable: "Ventas",
                        principalColumn: "VentasId");
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Categorias" },
                values: new object[,]
                {
                    { 1, "Comida" },
                    { 2, "Bebida" },
                    { 3, "Computadora" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "ApellidosCliente", "Direccion", "NombresCliente", "RUC", "Telefono" },
                values: new object[,]
                {
                    { 125, "Reyes Cortés", "Del parque Alfonso Mayor 1c al sur", "Anderson", "193258476212", 23459786 },
                    { 135, "Lopez Perez", "Del parque Caña Verde 3c al sur", "Oscar", "103258565373", 23459786 },
                    { 145, "Martínez Ortis", "De los talleres modernos 5c al sur y 1c arriba", "Jeremy", "17482147456", 47421839 }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "IMarcaId", "Marcas" },
                values: new object[,]
                {
                    { 1, "Krispy Kreme" },
                    { 2, "Crisco" },
                    { 3, "Grupo Bimbo" },
                    { 4, "Café las Flores" },
                    { 5, "Café Presto" },
                    { 6, "Casa del Café" },
                    { 7, "Coca Cola" },
                    { 8, "Pepsi" },
                    { 9, "Apple" },
                    { 10, "HP" },
                    { 11, "Razer" },
                    { 12, "Microsoft Surface" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Direccion", "RUC", "RazonSocial", "Telefono" },
                values: new object[,]
                {
                    { 1, "Del puente Pablito 1c al lago", "29432100457", "Arus Soda Resale, S.A.", 19932651 },
                    { 2, "De los talleres modernos 1c al sur 4c arriba", "57102110407", "Servicios de Repostería, S.A.", 10037158 },
                    { 3, "Calle principal de altamira, del bdf 1/2 c al sur", "10501219320", "Tienda de Computación Sevasa, S.A.", 36912153 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "RolesEmpleado" },
                values: new object[,]
                {
                    { 1000, "Encargada general de informática" },
                    { 1001, "Encargado general de compras" },
                    { 1303, "Cajero" },
                    { 1404, "Mesero" },
                    { 2000, "Conserje" },
                    { 2112, "Contador" },
                    { 9009, "Gerente" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "luisacrossway@gmail.com", 12345678, "Administrador", "Luisa" },
                    { 2, "ngomezanderson@gmail.com", 87654321, "Contador", "Nelio" },
                    { 3, "gabielurcuyo14@gmail.com", 9786543, "Economista", "Ernesto" }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "CompraId", "Fecha", "ProveedorId", "SereiComprobante", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "FA11", 215.00m },
                    { 2, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "FA20", 225.50m },
                    { 3, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "FA17", 105.00m }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "ApellidosEmpleados", "Contraseña", "DNI", "Direccion", "NombresEmpleado", "RolId", "Salario", "Telofono" },
                values: new object[,]
                {
                    { 1, "Patricia", "BAS0001", "ASD1205FG", "De los talleres modernos 3c al sur 1/2c arriba", "Karla", 1000, 8000m, 22556677 },
                    { 2, "Galán Blanco", "P41lo+fr1zz0", "BSA2004FG", "Del reparto Tres fuentes 2c arriba y 1c al sur", "Marcus", 1404, 7000m, 19384762 },
                    { 3, "Torres Ferguson", "l4Ma¿37hA", "AC3056DF", "De la refresquería Mi Niño 1c al sur y 3c abajo", "Eleazar Santiago", 1303, 6000m, 91827345 },
                    { 4, "Rodríguez Rodríguez", "Tra00pe1l1a2d04", "RG7623BD", "Del multicentro Las Pepitas 2c al lago", "Juan Pedro", 2000, 5000m, 12209345 },
                    { 5, "Puentes Contreras", "Añesartnoc", "QE1203AS", "Del parque Alfonso Mayor 5c al sur", "Alejandro", 1001, 4000m, 98761243 }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "CategoriaId", "Descripcion", "Estado", "MarcaId", "PrecioCompra", "PrecioVenta", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Dona glaseada", "Con Etiqueta", 1, 12.50m, 15.00m, 25 },
                    { 2, 1, "Pan Bimbo artesano", "Con Etiqueta", 3, 20.55m, 21.00m, 35 },
                    { 3, 2, "Taza de café capucchino", "Como Nuevo", 5, 10.50m, 15.00m, 45 },
                    { 4, 2, "Taza de café negro", "Semi Nuevo", 4, 7.50m, 9.95m, 55 },
                    { 5, 2, "Vaso de gaseosa", "Como Nuevo", 8, 11.10m, 15.00m, 54 },
                    { 6, 3, "Computadora portátil (Razer)", "Como Nuevo", 11, 300.00m, 350.00m, 15 },
                    { 7, 3, "Computadora portátil (Microsoft Surface)", "Semi Nuevo", 12, 250.00m, 275.00m, 20 },
                    { 8, 3, "Computadora portátil (HP)", "Con Imperfecciones", 10, 195.50m, 200.00m, 10 }
                });

            migrationBuilder.InsertData(
                table: "DetalleVentas",
                columns: new[] { "DetalleVentaId", "Cantidad", "PrecioVenta", "ProductoId", "SubTotal", "VentaId", "VentasId" },
                values: new object[,]
                {
                    { 1, 25, 15.00m, 1, 10m, 1, null },
                    { 2, 55, 9.95m, 4, 15m, 2, null },
                    { 3, 45, 15.00m, 3, 10m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "DetalleCompraId", "Cantidad", "CompraId", "PrecioCompra", "ProductoId", "SubTotal" },
                values: new object[,]
                {
                    { 1, 35, 1, 20.55m, 2, 15m },
                    { 2, 20, 2, 250.00m, 7, 5m },
                    { 3, 54, 3, 11.10m, 5, 12m }
                });

            migrationBuilder.InsertData(
                table: "Nominas",
                columns: new[] { "NomindaId", "AdelantoSueldo", "Apellido", "BonoTransporte", "EmpleadoId", "HorasExtras", "Nombre", "PagoHorasExtras", "PrecioHorasExtras", "SalarioBruto", "SalarioNeto", "SeguroMedico", "TotalAsignaciones", "TotalDeducciones" },
                values: new object[] { 1, 200m, "Patricia", 100m, 1, 10, "Karla", 500m, 50, 8000m, 8300m, 500m, 600m, 300m });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentasId", "ClienteId", "EmpleadoId", "Fecha", "SerieComprobante", "TipoComprobante", "Total" },
                values: new object[,]
                {
                    { 1, 125, 1, new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FA01", "Factura", 250.50m },
                    { 2, 135, 2, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FA02", "Factura", 200.55m },
                    { 3, 145, 4, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FA03", "Factura", 200.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProveedorId",
                table: "Compras",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_CategoriaId",
                table: "DashBoards",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_ClienteId",
                table: "DashBoards",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_EmpleadoId",
                table: "DashBoards",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_IMarcaId",
                table: "DashBoards",
                column: "IMarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_ProductoId",
                table: "DashBoards",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoards_ProveedorId",
                table: "DashBoards",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesCompras_CompraId",
                table: "DetallesCompras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesCompras_ProductoId",
                table: "DetallesCompras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_ProductoId",
                table: "DetalleVentas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVentas_VentasId",
                table: "DetalleVentas",
                column: "VentasId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RolId",
                table: "Empleados",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_EmpleadoId",
                table: "Nominas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashBoards");

            migrationBuilder.DropTable(
                name: "DetallesCompras");

            migrationBuilder.DropTable(
                name: "DetalleVentas");

            migrationBuilder.DropTable(
                name: "Nominas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
