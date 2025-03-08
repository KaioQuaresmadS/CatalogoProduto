using Microsoft.EntityFrameworkCore.Migrations;
using CatalogoProdutos.Context;

#nullable disable

namespace CatalogoProdutos.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (NameProduct,Description,Price,imageProduct) VALUES ('Placa-mãe', 'Placa-Mãe Gigabyte H510M H V2, Intel LGA 1200, 10ª E 11ª Geração', 500.00, 'placamae.jpg')");
            migrationBuilder.Sql("INSERT INTO Produtos (NameProduct,Description,Price,imageProduct) VALUES ('Memória Ram', 'DDR4 8 GB HyperX', 200.00, 'memoriaram.jpg')");
            migrationBuilder.Sql("INSERT INTO Produtos (NameProduct, Description, Price, imageProduct) VALUES ('Mouse', 'Mouse Gamer Sem Fio Logitech G PRO Wireless LIGHTSPEED', 300.00, 'mouselogtech.jpg')");
            migrationBuilder.Sql("INSERT INTO Produtos (NameProduct, Description, Price, imageProduct) VALUES ('Teclado', 'Teclado Mecânico Gamer Redragon Kumara', 150.00, 'tecladoredgradon.jpg')");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete FROM * Produtos");
        }
    }
}
