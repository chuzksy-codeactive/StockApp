using Microsoft.EntityFrameworkCore.Migrations;

namespace StockApp.Migrations
{
    public partial class spGetStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"
                  CREATE PROCEDURE [dbo].[GetStocks]
                    @UserId uniqueidentifier,
                    @MerchantId varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Stocks WHERE UserId = @UserId OR MerchantId = @MerchantId
                    ORDER BY CreatedAt DESC
                END
            ";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
