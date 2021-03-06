using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesShopBlazor.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Ratchet & Clank is a 3D platform video game developed by Insomniac Games and published by Sony Computer Entertainment for the PlayStation 2 in 2002. Ratchet & Clank is the first game in the series and precedes Going Commando. The game follows the anthropomorphic character Ratchet meeting the robot Clank on his home planet, Veldin. Clank discovers that the villainous Chairman Drek of the Blarg race plans to create a new planet for his species, destroying other planets in the process. Clank convinces Ratchet to help him in his mission to secure the assistance of the famous hero Captain Qwark.", "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/RaCbox.jpg/220px-RaCbox.jpg", "Ratchet & Clank", 8.00m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "Devil May Cry[a] is a 2001 action-adventure game developed by Capcom Production Studio 4[4] and published by Capcom. Released from August to December, originally for the PlayStation 2, it is the first installment in the Devil May Cry series. Set in modern times on the fictional Mallet Island, the story centers on Dante, a demon hunter who uses his business to carry out a lifelong vendetta against all demons. He meets a woman named Trish who takes him on a journey to defeat the demon lord Mundus, who is responsible for the deaths of Dante's brother and mother. The story is told primarily through a mixture of cutscenes, which use the game engine and several pre-rendered full motion videos. The game is very loosely based on the Italian poem Divine Comedy by the use of allusions, including the game's protagonist Dante (named after Dante Alighieri) and other characters like Trish (Beatrice Portinari) and Vergil (Virgil).[5]", "https://upload.wikimedia.org/wikipedia/en/1/1e/DMC1FrontCover.jpg", "Devil May Cry", 9.00m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Gran Turismo 3: A-Spec is a 2001 racing game, the first in the Gran Turismo series released for the PlayStation 2. During its demonstration at E3 2000 and E3 2001 the game's working title was Gran Turismo 2000. The game was a critical and commercial success and went on to become one of the best-selling video games of all time. It has been listed as one of the greatest video games of all time.", "https://upload.wikimedia.org/wikipedia/en/0/0d/Gran_Turismo_3.jpg", "Gran Turismo 3: A-Spec", 10.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
