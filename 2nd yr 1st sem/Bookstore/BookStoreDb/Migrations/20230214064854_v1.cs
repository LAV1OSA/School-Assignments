using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreDb.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Isbn = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false, computedColumnSql: "[NumPages]*10"),
                    DatePublished = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumPages = table.Column<int>(type: "INTEGER", nullable: false),
                    DaysOld = table.Column<int>(type: "INTEGER", nullable: false),
                    PublisherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wrote",
                columns: table => new
                {
                    BookAuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoyaltyRate = table.Column<float>(type: "REAL", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wrote", x => x.BookAuthorId);
                    table.ForeignKey(
                        name: "FK_Wrote_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wrote_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 1, "6612 Schmeler Rapids, Port Sidport, Wallis and Futuna", "Noel Klein" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 2, "8573 Littel Village, East Angiestad, Guinea", "Bobbie Olson" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 3, "419 Kailyn Rest, Corwinport, Tonga", "Timmothy Stanton" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 4, "5695 Emerson Club, Port Coy, Cocos (Keeling) Islands", "Adolf Kertzmann" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 5, "2268 Eldred Camp, Kesslerborough, Portugal", "Joesph Crooks" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 6, "04021 Allen Ramp, New Alexandra, Equatorial Guinea", "Albert Anderson" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 7, "935 Yasmine Green, North Shad, Grenada", "Haleigh Collins" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 8, "10744 Zella Ports, Jesusland, Iraq", "Berneice Farrell" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 9, "92709 Keagan Fords, Lake Rozella, Netherlands", "Makayla Reynolds" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 10, "126 Wuckert Prairie, East Randi, Czech Republic", "Delpha Moen" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 11, "83886 Lottie Canyon, Johnschester, Papua New Guinea", "Nikita Schmitt" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 12, "39920 Misty Track, East Timmyport, Papua New Guinea", "Tristian Kihn" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 13, "214 Brendon Falls, North Aydenfort, Togo", "Amara Ward" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 14, "174 Schmitt Crest, Port Miracle, Angola", "Terence Ortiz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 15, "770 Dibbert Lights, Hagenesfort, Poland", "Ashlee Wolff" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 16, "663 Keaton Locks, Judeview, Saint Helena", "Stephan Turner" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 17, "83239 Duane Via, South Larryberg, Jordan", "Joshuah Cremin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 18, "3281 Kylie Squares, New Armaniburgh, Venezuela", "Montana Toy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 19, "782 Damian Summit, Kieranside, Yemen", "Kristin Hessel" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 20, "314 Bartholome Trail, Arnulfoville, New Caledonia", "Wilhelmine Gerhold" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 21, "93903 Georgette Bypass, Franeckitown, Russian Federation", "Demetrius Mitchell" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 22, "8926 Crystal Road, Kadenport, Togo", "Tracy Bartell" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 23, "648 Ethelyn Glens, Sylvesterton, Bangladesh", "Eliane Toy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 24, "169 Esmeralda Overpass, East Amira, Saint Martin", "Oma Dietrich" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 25, "26007 Kuhn Drive, North Daphneymouth, Colombia", "Lou McGlynn" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 26, "3751 Little Harbor, Lake Violette, French Polynesia", "Vance Goodwin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 27, "59760 Domenico Field, Lake Lucasshire, Liechtenstein", "Mandy Mertz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 28, "8207 Rippin Lane, Brownton, Netherlands", "Tiffany Daniel" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 29, "17364 Greyson Stravenue, Julianmouth, Belgium", "Jarret Reynolds" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 30, "868 Sporer Vista, MacGyverchester, Cambodia", "Maiya Jacobi" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 31, "4268 Ervin Ridge, Lake Mathewland, Qatar", "Abbie Bosco" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 32, "575 Beatty Canyon, New Mavis, Peru", "Sigrid Kiehn" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 33, "62504 O'Connell Stream, Cummerataview, Gabon", "Jaeden Hane" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 34, "33590 Chadrick Route, East Mya, Macao", "Velda Pagac" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 35, "2907 Charity Islands, Salliestad, Lesotho", "Ezequiel Miller" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 36, "677 Terry Crest, Kaceyport, Norfolk Island", "Gabrielle Lubowitz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 37, "51688 Shields View, Veumton, Northern Mariana Islands", "Erna Daugherty" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 38, "6541 Mohr Key, New Uriel, Madagascar", "Jason Franecki" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 39, "3002 Purdy Village, New Ernestina, Libyan Arab Jamahiriya", "Albin Predovic" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 40, "18217 Sibyl Centers, Reyburgh, Svalbard & Jan Mayen Islands", "Carolanne Kautzer" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 41, "0551 Feil Route, Emmyburgh, Yemen", "Lonny Jones" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 42, "559 Langosh Curve, Granvillemouth, Latvia", "Mona Fay" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 43, "197 Bosco Pine, South Tabithaside, Trinidad and Tobago", "Taryn Roob" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 44, "80204 Green Roads, North Olaton, French Polynesia", "Ambrose Funk" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 45, "4219 Jane Meadow, Shanyside, Malta", "Andres Spinka" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 46, "507 Carter Rapids, South Loismouth, Brunei Darussalam", "Darian Hodkiewicz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 47, "0977 Cormier Common, Goodwinmouth, New Caledonia", "Emmy Bartell" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 48, "0265 Lorenza Keys, East Madonna, Samoa", "Otto Dibbert" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 49, "61833 Jenkins Street, South Dalton, Cameroon", "Kenyatta Oberbrunner" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 50, "15707 Derrick Rapid, Marlinfurt, Pitcairn Islands", "Cayla Barton" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 51, "11285 Hackett Forges, Collierborough, Lao People's Democratic Republic", "Milton White" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 52, "232 Zemlak Plains, East Bustertown, Haiti", "Agustin Bergnaum" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 53, "8699 Louisa Cove, Judsonport, Saudi Arabia", "Ibrahim Homenick" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 54, "51349 Weimann Lock, Rhiannaborough, Palau", "Lance McClure" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 55, "8752 Armstrong Shoal, South Yesseniaborough, Papua New Guinea", "Mazie Trantow" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 56, "870 Abshire Valley, Laurenview, Rwanda", "Bernice Welch" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 57, "11661 Titus Harbor, Wolfside, Sweden", "Ludwig Schamberger" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 58, "95108 Ralph Road, New Eldred, Bangladesh", "Bernie Wiegand" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 59, "03283 Stamm Forges, Bradhaven, Seychelles", "Zena Hilll" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 60, "8541 Vicky Loop, Grantberg, Mali", "Jane Breitenberg" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 61, "122 Izaiah Route, Purdymouth, Armenia", "Kristina O'Kon" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 62, "543 Tillman Shores, Wardstad, Holy See (Vatican City State)", "Friedrich Schultz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 63, "461 Kuhn Pine, Port Elberthaven, Palau", "Casey Bernier" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 64, "682 Margarett Viaduct, Lake Lexifurt, Afghanistan", "Pearline Lemke" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 65, "90204 Bosco Views, South Damien, Canada", "Maryam Bayer" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 66, "18606 Tillman Spring, Hyattshire, French Southern Territories", "Everett Buckridge" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 67, "52717 Kareem Cliff, Taureanside, Kyrgyz Republic", "Kaleb Rowe" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 68, "21831 Schmitt Square, Lake Ashly, Iceland", "Harmony McLaughlin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 69, "10258 Prosacco Rue, Schusterbury, Republic of Korea", "Micaela Monahan" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 70, "7008 Antwon Orchard, Lake Maryse, United Kingdom", "Stephanie McGlynn" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 71, "82027 Hank Station, Port Mia, Reunion", "Lexie Champlin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 72, "94792 Romaguera Plaza, Murphyshire, Mauritania", "Berniece Farrell" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 73, "71469 Stephen Walk, Mooremouth, Guyana", "Louie Bernhard" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 74, "15419 Grayce Course, North Marielaberg, Oman", "Madisyn Tillman" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 75, "82762 Marge Ports, Misaelhaven, India", "Toney West" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 76, "56438 Kiehn Lakes, Boscoland, Uruguay", "Liam Barrows" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 77, "914 Windler Landing, Kuhicfort, Zimbabwe", "Hershel Roberts" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 78, "221 Cora Coves, Rebeccachester, Liechtenstein", "Marcia Batz" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 79, "392 Greenfelder Throughway, Eladiohaven, Switzerland", "Rosie Weimann" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 80, "5759 Celestino Rapid, West Peter, Cyprus", "Emmett Bergstrom" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 81, "899 Cordia Dale, New Dan, Belgium", "Orlo Von" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 82, "4199 Adonis Heights, Binsfurt, Anguilla", "Rafael Sauer" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 83, "5028 Janis Plains, Marvinborough, Niue", "Abbie Reinger" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 84, "759 Jarret Cove, South Amayaland, Luxembourg", "Jon Cremin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 85, "7994 Bahringer Union, South Keanu, Botswana", "Coty Thiel" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 86, "2593 Ignatius Key, Port Edwina, Panama", "Axel Stanton" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 87, "686 Kessler Forks, West Therese, Czech Republic", "Eloisa Dibbert" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 88, "69570 Letitia Plaza, Port Stephan, Republic of Korea", "Eleanora Bailey" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 89, "513 Baby Square, Mertieborough, Bermuda", "Grayce Kessler" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 90, "7748 Strosin Pike, West Alford, Gambia", "Jaylen Kautzer" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 91, "26521 Quigley Trace, West Devinberg, Cocos (Keeling) Islands", "Candice Leffler" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 92, "6293 Ben Freeway, North Gerson, Argentina", "Cicero Torphy" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 93, "2097 Murazik Shoals, West Bertafort, Niue", "Esta Denesik" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 94, "551 Thiel Run, Monaport, Israel", "Julia Ratke" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 95, "18132 Fadel Well, Euniceview, Croatia", "Manuel Witting" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 96, "65220 Arnaldo Shoal, South Paxtonmouth, Syrian Arab Republic", "Justine Crona" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 97, "861 Ziemann Ridges, Kasandrashire, Papua New Guinea", "Bethel Hoeger" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 98, "1015 Alexandra Corner, North Lucious, Macao", "Jovany Rutherford" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 99, "710 Annalise Junction, North Melvinburgh, Luxembourg", "Mathias Romaguera" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Address", "Name" },
                values: new object[] { 100, "598 Mackenzie Freeway, Port Tyrellview, Sao Tome and Principe", "Kayden Denesik" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 1, "Buzzbean" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 2, "Meezzy" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 3, "Kwinu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 4, "Nlounge" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 5, "Riffpath" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 6, "Devcast" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 7, "Flashspan" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 8, "Twimm" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 9, "Zoomzone" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 10, "Avavee" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 11, "Mydeo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 12, "DabZ" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 13, "Yakidoo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 14, "Yadel" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 15, "Kwinu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 16, "Zoomcast" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 17, "Jatri" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 18, "Jayo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 19, "Thoughtbridge" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 20, "Oyoyo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 21, "Yodo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 22, "Linkbuzz" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 23, "Meeveo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 24, "Eare" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 25, "Babbleset" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 26, "Snaptags" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 27, "Miboo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 28, "Jamia" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 29, "Voolith" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 30, "Thoughtsphere" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 31, "Bubblemix" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 32, "Kare" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 33, "Jabbertype" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 34, "Realbuzz" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 35, "Flashpoint" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 36, "Topiclounge" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 37, "Tagchat" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 38, "Quaxo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 39, "Yadel" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 40, "Devshare" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 41, "Babbleblab" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 42, "Ozu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 43, "Yakijo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 44, "Roomm" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 45, "Dazzlesphere" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 46, "Pixonyx" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 47, "Brainbox" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 48, "Gigazoom" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 49, "Yodoo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 50, "Edgeify" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 51, "Oyondu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 52, "Mita" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 53, "Realbridge" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 54, "Skajo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 55, "Topicware" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 56, "Npath" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 57, "Demimbu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 58, "Skibox" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 59, "Youopia" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 60, "Gabtune" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 61, "Innojam" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 62, "Eadel" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 63, "Youspan" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 64, "Thoughtbridge" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 65, "Devbug" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 66, "Blogtag" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 67, "Trudeo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 68, "Yotz" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 69, "Dynava" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 70, "Quimba" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 71, "Dabvine" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 72, "Youopia" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 73, "Realfire" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 74, "Jabbercube" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 75, "Browsebug" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 76, "Divavu" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 77, "Skyba" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 78, "Bubblebox" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 79, "Yambee" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 80, "Shuffledrive" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 81, "Pixonyx" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 82, "Tagpad" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 83, "Trudeo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 84, "Kare" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 85, "Oyoba" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 86, "Centidel" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 87, "Twinder" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 88, "Layo" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 89, "Chatterpoint" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 90, "Skiptube" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 91, "Voolith" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 92, "Skyba" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 93, "Gabcube" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 94, "Divape" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 95, "Skipstorm" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 96, "Yabox" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 97, "Browseblab" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 98, "Gabtune" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 99, "Shufflester" });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { 100, "Zooveo" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(1962, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 22190, "190322175-7", 890, 92, "Dr. Dolittle 2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 2, new DateTime(1902, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 44113, "712544395-8", 1621, 71, "Trembling Before G-d" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2016, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2270, "891775104-0", 2251, 26, "Texas Across the River" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 4, new DateTime(1935, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 32145, "339391758-7", 2645, 61, "Pentagon Wars  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(1976, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17185, "395559965-5", 903, 10, "Watermarks" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(1910, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 41252, "344493308-8", 916, 28, "Wallace & Gromit in The Curse of the Were-Rabbit" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 7, new DateTime(1959, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23062, "781966329-4", 415, 39, "Guns at Batasi" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(1916, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38839, "631503389-X", 142, 92, "Letters from Iwo Jima" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1068, "020771937-3", 2792, 50, "Canyons  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 10, new DateTime(1956, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 24346, "794151958-5", 1055, 16, "Side by Side" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 11, new DateTime(1931, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 33534, "238122032-1", 1468, 5, "Pulling Strings" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 12, new DateTime(1924, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 36047, "639710540-7", 368, 8, "Promised Land (Ziemia Obiecana)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 13, new DateTime(1927, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34974, "147231094-2", 2111, 84, "Flickering Lights (Blinkende lygter)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 14, new DateTime(1903, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 43619, "581334590-6", 770, 61, "Higher Learning" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 15, new DateTime(1947, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 27701, "058191475-9", 2512, 83, "Seven-Per-Cent Solution  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 16, new DateTime(1913, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40017, "145323847-6", 2769, 69, "Some Girls" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 17, new DateTime(1954, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25089, "356178841-6", 2206, 27, "Cohen and Tate" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 18, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1211, "724075536-3", 1464, 6, "I Am Fishead" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 19, new DateTime(1901, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44298, "605257310-4", 2835, 1, "Kung Fu Dunk" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 20, new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8702, "142808910-1", 1297, 14, "Wraith  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 21, new DateTime(2018, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1584, "027563881-2", 352, 85, "All About Anna" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 22, new DateTime(1912, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 40480, "634082016-6", 1296, 12, "Sordid Lives" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 23, new DateTime(1994, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10264, "954924251-X", 1417, 41, "Tiger Eyes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 24, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5747, "074615698-7", 2480, 51, "Bridge  The (Most)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 25, new DateTime(1904, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 43482, "147117803-X", 1239, 1, "Cannery Row" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 26, new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, "680963388-X", 1269, 91, "Jealousy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 27, new DateTime(1980, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15498, "490461954-4", 2589, 27, "Love Parade  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 28, new DateTime(1902, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44063, "868916746-3", 2070, 51, "Straits of Love and Hate  The (Aien kyo)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 29, new DateTime(1942, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29308, "901862637-6", 1331, 2, "Killer: A Journal of Murder" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 30, new DateTime(1984, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14113, "466358683-X", 1741, 2, "Carpetbaggers  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 31, new DateTime(2009, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5013, "640445859-4", 722, 83, "Alien³ (a.k.a. Alien 3)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 32, new DateTime(2014, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3103, "042510993-3", 319, 71, "The Last Diamond" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 33, new DateTime(1906, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42608, "621640695-7", 1895, 83, "Out of Life (Hors la vie)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 34, new DateTime(1984, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14058, "802878757-6", 1427, 52, "Savages" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 35, new DateTime(1973, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17942, "006050126-X", 2397, 97, "Last Call (Hoogste tijd)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 36, new DateTime(1935, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 31871, "002202399-2", 344, 7, "Keep Your Distance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 37, new DateTime(1960, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 22952, "970895904-9", 1274, 93, "Sucker  The (Corniaud  Le)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 38, new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8475, "402032808-0", 2671, 93, "Beyond Borders" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 39, new DateTime(1965, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21163, "433919353-4", 1302, 92, "This Girl's Life" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 40, new DateTime(1994, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10576, "003775927-2", 395, 78, "Harrison Bergeron" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 41, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2214, "285134932-5", 123, 11, "Return of the Magnificent Seven  The (a.k.a. Return of the Seven)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 42, new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13763, "188706613-6", 922, 28, "Poor Little Rich Girl" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 43, new DateTime(1979, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15804, "427336729-7", 625, 83, "Idle Hands" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 44, new DateTime(1947, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 27538, "845346844-3", 1911, 54, "High Tech  Low Life" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 45, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1407, "102292520-2", 251, 98, "Shag" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 46, new DateTime(1945, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28419, "754179252-7", 2508, 20, "Women in Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 47, new DateTime(1997, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9454, "810207308-X", 1876, 65, "Day Night Day Night" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 48, new DateTime(1951, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 26316, "757289880-7", 1032, 11, "Stuff and Dough (Marfa si banii)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 49, new DateTime(1911, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40821, "988908489-9", 533, 83, "The Derby Stallion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 50, new DateTime(1995, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10056, "249150646-7", 1846, 22, "Love Me Tender" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 51, new DateTime(1993, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10915, "438961935-7", 254, 50, "Ring of Darkness" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 52, new DateTime(1932, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32974, "193753327-1", 2316, 100, "Hart's War" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 53, new DateTime(1929, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 34074, "369750444-4", 1283, 33, "Pancho  the Millionaire Dog" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 54, new DateTime(2000, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8257, "291731675-6", 367, 96, "Sword of the Valiant" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 55, new DateTime(1958, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 23617, "427431323-9", 1581, 11, "Fellini: I'm a Born Liar (Fellini: Je Suis um Grand Menteur)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 56, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1569, "402100476-9", 2005, 58, "Made in Britain" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 57, new DateTime(2011, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4306, "150555687-2", 38, 93, "Japan's Longest Day (Nihon no ichiban nagai hi)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 58, new DateTime(1946, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27877, "932638214-1", 2488, 67, "Love & Savagery" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 59, new DateTime(1923, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36484, "431761769-2", 855, 13, "I Accuse" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 60, new DateTime(1996, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9613, "855710980-6", 2807, 58, "Scourge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 61, new DateTime(1903, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 43613, "904161901-1", 2522, 7, "Zatoichi Goes to the Fire Festival (Zatôichi abare-himatsuri) (Zatôichi 21)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 62, new DateTime(1928, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34459, "832552939-3", 250, 60, "19th Wife  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 63, new DateTime(2017, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2085, "683292113-6", 2982, 100, "Leontine" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 64, new DateTime(1936, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 31692, "873738193-8", 2412, 26, "Cool Runnings" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 65, new DateTime(1994, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10576, "000367024-4", 2600, 37, "Ladies Man  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 66, new DateTime(1974, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 17660, "716695072-2", 1549, 48, "Bound" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 67, new DateTime(1962, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 22091, "246034861-4", 642, 81, "Invitation to the Dance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 68, new DateTime(1936, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 31491, "212567767-9", 2363, 43, "Katyn" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 69, new DateTime(1961, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22600, "249174939-4", 1430, 86, "Superman IV: The Quest for Peace" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 70, new DateTime(1948, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27372, "688411562-9", 1807, 38, "Look  Up in the Sky! The Amazing Story of Superman" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 71, new DateTime(1918, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 38214, "272969472-2", 896, 97, "Time of the Wolf  The (Le temps du loup)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 72, new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 42019, "127733294-0", 511, 22, "Butterfly Kiss" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 73, new DateTime(2017, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2110, "994925820-0", 1833, 74, "Beverly Hills Ninja" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 74, new DateTime(1960, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22755, "937340700-7", 1339, 45, "Gravity (Schwerkraft)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 75, new DateTime(1974, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 17599, "795491420-8", 2317, 39, "Quartet" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 76, new DateTime(1950, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 26673, "274838935-2", 2184, 3, "Pineapple Express" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 77, new DateTime(1901, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 44334, "155268611-6", 2914, 89, "Dungeons & Dragons" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 78, new DateTime(2006, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5883, "609128328-6", 1075, 34, "Looking for Hortense (Cherchez Hortense) " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 79, new DateTime(1991, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11599, "708345240-7", 2092, 7, "All That Jazz" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 80, new DateTime(1996, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9708, "467985187-2", 1501, 71, "Sword of the Valiant" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 81, new DateTime(1954, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25009, "014636247-0", 1841, 75, "GhostWatcher" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 82, new DateTime(1923, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 36430, "278966059-X", 891, 56, "Demetrius and the Gladiators" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 83, new DateTime(1964, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 21313, "248044520-8", 1173, 66, "Captain Horatio Hornblower R.N." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 84, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 402, "004584382-1", 2681, 46, "Closet Land" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 85, new DateTime(1994, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10432, "878651142-4", 2326, 63, "Black God  White Devil (Deus e o Diabo na Terra do Sol)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 86, new DateTime(1959, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23153, "550063915-3", 465, 91, "Pale Rider" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 87, new DateTime(1991, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11611, "138034747-5", 2862, 74, "Cencoroll" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 88, new DateTime(2012, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3792, "097687186-6", 636, 90, "Fire Down Below" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 89, new DateTime(1962, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22291, "219631019-0", 2581, 70, "Prison Break: The Final Break" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 90, new DateTime(2005, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6549, "423051349-6", 2802, 63, "5 Fingers" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 91, new DateTime(1952, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25878, "016953743-9", 2028, 51, "Marrying Man  The (Too Hot to Handle)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 92, new DateTime(2008, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5137, "208889695-3", 1599, 49, "Cheap Detective  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 93, new DateTime(1984, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14170, "769926003-1", 1221, 20, "Tarnation" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 94, new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10866, "229059579-9", 683, 44, "Inhuman Resources (Redd Inc.)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 95, new DateTime(2003, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7245, "609937705-0", 738, 70, "Melody" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 96, new DateTime(2003, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7086, "028577349-6", 1687, 52, "Gang Tapes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 97, new DateTime(1989, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12226, "254878337-5", 724, 9, "May in the Summer" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 98, new DateTime(1998, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8865, "823844441-1", 2620, 5, "Home Alone 2: Lost in New York" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 99, new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11484, "911289326-9", 2143, 97, "Woman In Berlin  A (Anonyma - Eine Frau in Berlin)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 100, new DateTime(1970, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19345, "762917943-X", 2809, 6, "Dante's Peak" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 101, new DateTime(1928, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34430, "599846022-7", 2873, 20, "Mrs. Winterbourne" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 102, new DateTime(1912, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40452, "963817410-2", 93, 68, "Dolls" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 103, new DateTime(1941, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29660, "359871000-3", 2409, 31, "Everything Put Together" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 104, new DateTime(1919, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 37863, "359204205-X", 2576, 2, "Gate  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 105, new DateTime(1958, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23750, "750273328-0", 347, 46, "Santa Claus Has Blue Eyes (Le père Noël a les yeux bleus)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 106, new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9782, "960146694-0", 1321, 59, "Charter Trip  The (a.k.a. Package Tour  The) (Sällskapsresan)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 107, new DateTime(1968, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 19872, "841666492-7", 1082, 5, "Hamlet" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 108, new DateTime(1903, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 43772, "678193983-1", 626, 92, "Koch" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 109, new DateTime(1937, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 31370, "528047927-6", 1099, 7, "Rat King" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 110, new DateTime(1971, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18882, "048884908-X", 1062, 35, "Monster's Ball" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 111, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 997, "668312280-6", 2683, 44, "Two Years at Sea" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 112, new DateTime(1923, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 36279, "718505555-5", 1055, 94, "Striking Range" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 113, new DateTime(1918, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 38082, "372286515-8", 394, 19, "Tammy and the T-Rex" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 114, new DateTime(1990, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11980, "093481015-X", 527, 65, "Passion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 115, new DateTime(1989, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12105, "328801158-1", 2970, 21, "Top Five" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 116, new DateTime(1953, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25488, "354898978-0", 2501, 11, "Lust  Caution (Se  jie)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 117, new DateTime(1960, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22993, "871214001-5", 1427, 49, "Little Hamlet" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 118, new DateTime(1905, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42758, "563540750-1", 2429, 24, "Lost Battalion  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 119, new DateTime(2013, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3445, "182690242-2", 1859, 95, "Dreamscape" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 120, new DateTime(1954, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25122, "044265176-7", 1150, 55, "Burn  Witch  Burn (Night of the Eagle)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 121, new DateTime(1900, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44913, "911907250-3", 574, 52, "Heroic Purgatory (Rengoku eroica)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 122, new DateTime(1974, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17596, "550455675-9", 2507, 31, "Love That Boy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 123, new DateTime(1968, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19930, "163317681-9", 1991, 4, "Stormbreaker (Alex Rider: Operation Stormbreaker)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 124, new DateTime(2006, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6203, "755577498-4", 2889, 60, "Unknown Known  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 125, new DateTime(2009, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5089, "215489832-7", 2817, 87, "Love That Boy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 126, new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29287, "404130221-8", 715, 25, "Goodbye First Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 127, new DateTime(1955, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24557, "725324096-0", 1251, 69, "Pagemaster  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 128, new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5380, "725941687-4", 72, 9, "The Land Before Time V: The Mysterious Island" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 129, new DateTime(1945, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28467, "609490595-4", 764, 53, "Kindergarten Cop" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 130, new DateTime(2003, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7204, "774460758-9", 1418, 19, "Strange Days" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 131, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, "287215078-1", 2412, 60, "Hitting Home" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 132, new DateTime(2007, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5515, "298612277-9", 248, 3, "Rhapsody in Blue" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 133, new DateTime(1972, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18425, "677231523-5", 519, 99, "Grey  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 134, new DateTime(2002, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7432, "086334233-7", 504, 49, "Genghis Blues" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 135, new DateTime(1932, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 33088, "960442790-3", 2383, 68, "Factory  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 136, new DateTime(1922, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36637, "309188456-2", 527, 89, "Planet of the Future  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 137, new DateTime(1956, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24253, "220031644-5", 2252, 95, "Lady Killer" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 138, new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5747, "076592349-1", 400, 55, "Cadence" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 139, new DateTime(1965, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20920, "442541474-8", 1443, 73, "Sandpiper  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 140, new DateTime(1958, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23763, "747061417-6", 999, 29, "Kirikou and the Sorceress (Kirikou et la sorcière)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 141, new DateTime(1967, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20217, "218469152-6", 313, 72, "Let the Good Times Roll" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 142, new DateTime(2003, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 7221, "825715508-X", 629, 13, "The Great Northfield Minnesota Raid" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 143, new DateTime(1941, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29631, "495083960-8", 229, 29, "Out in the Dark" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 144, new DateTime(1998, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8796, "275125638-4", 2476, 44, "Sands of Iwo Jima" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 145, new DateTime(1951, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 26149, "780238395-1", 1720, 77, "High Hopes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 146, new DateTime(1922, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 36791, "109571758-8", 866, 18, "All I Want (Try Seventeen)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 147, new DateTime(1917, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 38460, "805810014-5", 2823, 24, "Onibi: The Fire Within" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 148, new DateTime(1904, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 43173, "315612481-8", 344, 81, "Tucker & Dale vs Evil" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 149, new DateTime(1939, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30360, "319358760-5", 2007, 35, "71 Fragments of a Chronology of Chance (71 Fragmente einer Chronologie des Zufalls)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 150, new DateTime(1924, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 36013, "822232919-7", 1575, 54, "Zookeeper" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 151, new DateTime(1940, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30317, "596117558-8", 454, 90, "Paisan (Paisà)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 152, new DateTime(1930, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 33632, "377582120-1", 2230, 57, "Experiment Perilous" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 153, new DateTime(1924, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 36030, "098304928-9", 776, 68, "Smash His Camera" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 154, new DateTime(1935, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 31851, "262170241-4", 2461, 36, "Neon Genesis Evangelion: Death & Rebirth (Shin seiki Evangelion Gekijô-ban: Shito shinsei)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 155, new DateTime(1941, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 29963, "077145266-7", 65, 26, "Book of Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 156, new DateTime(1949, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26968, "942663718-4", 2319, 68, "Seventh Horse of the Sun  (Suraj Ka Satvan Ghoda)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 157, new DateTime(1928, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 34536, "212330394-1", 235, 6, "Salvatore Giuliano" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 158, new DateTime(2018, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1712, "688440818-9", 2530, 76, "Swell Season  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 159, new DateTime(1954, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25091, "398390232-4", 2892, 56, "Dead Man and Being Happy  The (El muerto y ser feliz)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 160, new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 847, "925183155-6", 2944, 10, "And the Ship Sails On (E la nave va)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 161, new DateTime(1916, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38756, "472122358-7", 279, 65, "Hansel & Gretel" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 162, new DateTime(1983, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14292, "597570278-X", 993, 46, "8 Heads in a Duffel Bag" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 163, new DateTime(1996, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9862, "509608885-5", 273, 73, "I Smile Back" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 164, new DateTime(1917, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 38682, "903679742-X", 592, 43, "Leviathan" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 165, new DateTime(1928, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 34383, "957805050-X", 1992, 67, "Shepard & Dark" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 166, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15980, "933554978-9", 2331, 51, "Distant Voices  Still Lives" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 167, new DateTime(1962, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22168, "794034061-1", 917, 3, "Southern District (Zona Sur)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 168, new DateTime(1910, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 41254, "247032943-4", 2448, 51, "Mahabharata  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 169, new DateTime(1927, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34807, "075652437-7", 1673, 66, "Cats & Dogs" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 170, new DateTime(1962, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22261, "735093612-5", 105, 65, "Captive (Cautiva) " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 171, new DateTime(1940, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30281, "012717805-8", 1196, 57, "Housemaid  The (Hanyo)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 172, new DateTime(1944, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28720, "856708566-7", 1683, 79, "The Adventure of Faustus Bidgood" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 173, new DateTime(1944, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28855, "931231709-1", 2782, 39, "Kitty" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 174, new DateTime(1991, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 11584, "847012691-1", 1861, 96, "Four Eyes and Six-Guns" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 175, new DateTime(1939, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 30676, "951367826-1", 2397, 100, "Lord of Tears" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 176, new DateTime(2009, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5029, "970399223-4", 2352, 76, "Jaws: The Revenge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 177, new DateTime(2014, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3270, "467666534-2", 923, 82, "Double Suicide (Shinjû: Ten no amijima)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 178, new DateTime(1955, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 24812, "102066491-6", 2139, 62, "Imagine: John Lennon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 179, new DateTime(2009, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4952, "389321482-8", 721, 95, "Major Barbara" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 180, new DateTime(1934, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 32348, "694736802-2", 2124, 68, "What Happened  Miss Simone?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 181, new DateTime(1905, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 43112, "208740163-2", 1426, 47, "Bamboozled" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 182, new DateTime(1943, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 29090, "730528529-3", 2240, 88, "Make Mine Music" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 183, new DateTime(1992, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11260, "128247815-X", 1122, 85, "Princess Bride  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 184, new DateTime(1960, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22863, "616078691-1", 395, 77, "Adjustment Bureau  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 185, new DateTime(2013, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3657, "473871627-1", 1095, 19, "Farmer's Daughter  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 186, new DateTime(1926, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 35346, "683427678-5", 2450, 21, "Slave Girls (Prehistoric Women)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 187, new DateTime(1915, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 39393, "134030203-9", 2877, 75, "My Grandfather's People (Dedemin insanlari)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 188, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12776, "859908662-6", 520, 68, "Seance on a Wet Afternoon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 189, new DateTime(1927, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35082, "709424415-0", 1058, 44, "'Salem's Lot" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 190, new DateTime(2004, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6660, "400764123-4", 2486, 57, "Collision Earth" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 191, new DateTime(1962, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 22178, "249443439-4", 2343, 62, "Crocodile Dundee" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 192, new DateTime(2010, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4687, "665366882-7", 2066, 86, "Viper in the Fist" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 193, new DateTime(2001, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7730, "797374165-8", 616, 31, "Casual Sex?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 194, new DateTime(1918, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38333, "019995826-2", 1358, 25, "Little Girl Who Lives Down the Lane  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 195, new DateTime(2012, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3677, "495826460-4", 1107, 72, "Move (3 Zimmer/Küche/Bad)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 196, new DateTime(1970, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19157, "569794275-3", 2934, 93, "Perfume" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 197, new DateTime(1952, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25645, "349071994-8", 173, 52, "Where the Red Fern Grows" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 198, new DateTime(2013, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3366, "999621522-9", 1442, 95, "Felon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 199, new DateTime(1966, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20545, "695120408-X", 1009, 11, "Forbidden City Cop (Dai lap mat tam 008)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 200, new DateTime(1964, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21544, "863122982-2", 2431, 9, "Grandmaster  The (Yi dai zong shi)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 201, new DateTime(1958, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23664, "449406127-1", 1993, 29, "Shadow Kill" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 202, new DateTime(2007, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5636, "241376015-6", 2142, 93, "Sherlock Holmes: Dressed to Kill" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 203, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 355, "203868317-4", 1481, 6, "Act of Killing  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 204, new DateTime(1986, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13419, "013509428-3", 2217, 56, "Dorado  El" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 205, new DateTime(1916, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 38921, "652024355-8", 557, 54, "Show Boat" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 206, new DateTime(1932, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 33232, "478993690-2", 2415, 62, "Delicate Balance  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 207, new DateTime(1975, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17288, "686803244-7", 2787, 38, "Clone (Womb)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 208, new DateTime(1939, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30667, "820473036-5", 2941, 7, "Rocket  The (a.k.a. Maurice Richard)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 209, new DateTime(1986, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13519, "225346094-X", 1235, 31, "Jewtopia" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 210, new DateTime(1961, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 22325, "877598361-3", 876, 66, "Andy Hardy Meets Debutante" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 211, new DateTime(1912, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40254, "342592921-6", 1196, 76, "16 Years of Alcohol" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 212, new DateTime(1961, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22474, "003556258-7", 774, 79, "Folks!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 213, new DateTime(2007, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5544, "702744018-0", 1596, 61, "Commando" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 214, new DateTime(1967, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20235, "271233841-3", 871, 29, "You Will Be My Son (Tu seras mon fils)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 215, new DateTime(1997, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9406, "681285608-8", 1420, 86, "Vampires" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 216, new DateTime(1906, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 42630, "738848266-0", 2256, 6, "Ninth Gate  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 217, new DateTime(1951, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26022, "395861223-7", 536, 64, "Bad Day on the Block" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 218, new DateTime(2000, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8256, "777934258-1", 764, 74, "Net  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 219, new DateTime(1907, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42134, "671050414-X", 276, 87, "Lake Mungo" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 220, new DateTime(2002, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7594, "915990332-5", 2614, 49, "Solino" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 221, new DateTime(1915, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 39292, "465417790-6", 2420, 72, "The Referees" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 222, new DateTime(1937, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31363, "973583347-6", 2825, 59, "Wild Tales" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 223, new DateTime(1904, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 43486, "141280550-3", 1590, 24, "Nixon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 224, new DateTime(1935, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31904, "621677777-7", 1328, 74, "Miracle on 34th Street" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 225, new DateTime(1942, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29528, "981206037-5", 2875, 37, "Santa Claus Has Blue Eyes (Le père Noël a les yeux bleus)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 226, new DateTime(1970, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19241, "595020473-5", 2900, 36, "Saturday Night" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 227, new DateTime(1909, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 41416, "498961788-6", 1099, 58, "Medea" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 228, new DateTime(1969, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19466, "057841544-5", 505, 16, "Memories (Memorîzu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 229, new DateTime(1924, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 36040, "621742322-7", 1391, 36, "Trumpet of the Swan  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 230, new DateTime(1950, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26454, "491642155-8", 1390, 4, "Pretty Baby" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 231, new DateTime(1933, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32729, "968403783-X", 2969, 62, "Just Buried" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 232, new DateTime(1961, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22500, "302371751-6", 1645, 57, "Tevye" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 233, new DateTime(1987, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12899, "199613503-1", 1295, 27, "Star Is Born  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 234, new DateTime(1914, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 39496, "413456620-7", 949, 29, "Art of the Steal  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 235, new DateTime(1958, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 23470, "033043946-4", 1522, 52, "An Alligator Named Daisy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 236, new DateTime(1911, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40832, "515735110-0", 1360, 93, "Killing of a Chinese Bookie  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 237, new DateTime(1983, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14371, "339622292-X", 663, 15, "American  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 238, new DateTime(1945, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28154, "795926831-2", 2431, 35, "Ernest Film Festival  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 239, new DateTime(1984, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13972, "137348890-5", 2360, 76, "Crossing the Bridge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 240, new DateTime(1999, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8762, "324949516-6", 1053, 50, "Lady Sings the Blues" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 241, new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9840, "145285033-X", 2438, 13, "Hills Have Eyes II  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 242, new DateTime(2008, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5377, "843571248-6", 486, 18, "Jack Strong" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 243, new DateTime(2004, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6877, "403484468-X", 2850, 46, "Ten Seconds to Hell" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 244, new DateTime(1925, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 35516, "184066735-4", 1214, 31, "Batman & Mr. Freeze: Subzero" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 245, new DateTime(1907, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 42265, "977890719-6", 652, 41, "Sexual Life of the Belgians  The (Vie sexuelle des Belges 1950-1978  La)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 246, new DateTime(1977, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16509, "843814854-9", 225, 10, "Public Enemies" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 247, new DateTime(2010, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4467, "571177003-9", 1889, 96, "Mysterious Lady  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 248, new DateTime(1962, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 21953, "635108955-7", 1982, 91, "Tomorrow  When the War Began" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 249, new DateTime(1995, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10128, "061668498-3", 1389, 42, "Sunrise: A Song of Two Humans" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 250, new DateTime(1990, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11772, "308309740-9", 650, 43, "Dr. Gillespie's New Assistant" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 251, new DateTime(1908, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 41710, "354276479-5", 678, 69, "Lost Weekend  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 252, new DateTime(1927, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 35000, "247437764-6", 340, 32, "The Pirates of Blood River" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 253, new DateTime(2003, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7131, "695064915-0", 1694, 70, "1981" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 254, new DateTime(1972, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18298, "019917577-2", 684, 70, "Jupiter's Darling" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 255, new DateTime(1920, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 37356, "838621928-9", 1065, 77, "Sorority House Massacre II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 256, new DateTime(2006, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6028, "614999968-8", 1311, 81, "Tiger from Tjampa  The (Harimau Tjampa)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 257, new DateTime(1960, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22833, "913773860-7", 988, 93, "Den sommeren jeg fylte 15" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 258, new DateTime(1943, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29216, "792137913-3", 1174, 58, "Everyday People" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 259, new DateTime(2007, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5823, "061949434-4", 158, 75, "Bye Bye Monkey (Ciao maschio)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 260, new DateTime(2016, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2532, "218583830-X", 2127, 23, "Congress  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 261, new DateTime(1969, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19530, "544445997-3", 575, 85, "Ed" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 262, new DateTime(1980, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15711, "950665054-3", 769, 83, "Heir to an Execution" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 263, new DateTime(1902, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 44019, "004031451-0", 381, 33, "Knight of Cups" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 264, new DateTime(1945, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 28329, "615232182-4", 446, 65, "God Is Brazilian (Deus É Brasileiro)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 265, new DateTime(2002, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7447, "406739934-0", 2609, 54, "Mi Amigo Hugo" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 266, new DateTime(2008, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5262, "325196943-9", 1985, 78, "Love Is a Woman (Death Is a Woman)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 267, new DateTime(1927, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 35075, "597921840-8", 1228, 73, "Last Metro  The (Dernier métro  Le)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 268, new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8941, "450395148-3", 1776, 72, "Box  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 269, new DateTime(2008, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5364, "531594177-9", 1711, 66, "Euphoria (Eyforiya)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 270, new DateTime(1924, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 36055, "202932257-1", 1531, 87, "Star Trek Into Darkness" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 271, new DateTime(1952, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25903, "452211364-1", 1147, 39, "Wings (Krylya)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 272, new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10121, "799421866-0", 2443, 88, "Stolen Face" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 273, new DateTime(1985, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 13766, "058445693-X", 1138, 31, "Open Road  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 274, new DateTime(2002, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7484, "423093964-7", 66, 19, "Meat the Truth" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 275, new DateTime(1940, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30260, "389159051-2", 707, 69, "Soccer Days" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 276, new DateTime(1983, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14519, "154821854-5", 1911, 93, "The Mayor of Casterbridge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 277, new DateTime(1928, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 34484, "393685455-6", 1538, 17, "Orlando" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 278, new DateTime(1951, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26030, "719351418-0", 1880, 54, "Happy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 279, new DateTime(2014, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3001, "055962324-0", 1496, 91, "Hills Have Eyes  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 280, new DateTime(1902, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44189, "747447108-6", 206, 11, "2:22" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 281, new DateTime(1917, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38388, "405366700-3", 1389, 34, "Disco Godfather" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 282, new DateTime(1935, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32001, "880445331-1", 663, 35, "Space Odyssey: Voyage to the Planets" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 283, new DateTime(1948, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 27375, "996597845-X", 1211, 26, "St. Trinian's" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 284, new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2662, "261718820-5", 2352, 82, "Bread  Love and Dreams (Pane  amore e fantasia)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 285, new DateTime(1977, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16504, "518884004-9", 571, 73, "For Ever Mozart" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 286, new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8618, "857060935-3", 674, 8, "Simpsons: The Longest Daycare  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 287, new DateTime(1901, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 44345, "033732572-3", 962, 24, "Army Brats (Schatjes!)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 288, new DateTime(1941, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29783, "857106544-6", 2824, 27, "14 Blades (Jin yi wei)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 289, new DateTime(1978, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16139, "151660530-6", 67, 58, "Brotherhood  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 290, new DateTime(1917, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38388, "832630191-4", 1926, 88, "Identity Thief" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 291, new DateTime(1900, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44724, "314522057-8", 492, 91, "Double Tide" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 292, new DateTime(1919, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37887, "978936089-4", 1028, 98, "Star Trek IV: The Voyage Home" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 293, new DateTime(1976, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17176, "999986955-6", 1823, 96, "Murphy's Romance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 294, new DateTime(1935, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 32096, "710879698-8", 1140, 55, "Bent" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 295, new DateTime(1932, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 33215, "689024082-0", 651, 43, "Broken Circle Breakdown  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 296, new DateTime(1993, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10931, "639341637-8", 811, 64, "Exit to Hell" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 297, new DateTime(1914, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39695, "285467917-2", 1534, 6, "Hell's Kitchen" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 298, new DateTime(1952, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25824, "725837201-6", 2810, 33, "Dragonworld" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 299, new DateTime(1953, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25239, "447395723-3", 336, 15, "Boxcar Bertha" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 300, new DateTime(1933, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 32605, "746369583-2", 1158, 42, "Producers  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 301, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, "990776889-8", 289, 37, "Devil's Playground  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 302, new DateTime(1999, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8571, "520580782-2", 2723, 43, "An American Tail: The Treasure of Manhattan Island" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 303, new DateTime(1919, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 37935, "446544058-8", 1533, 49, "Tender Is the Night" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 304, new DateTime(1971, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18917, "769848107-7", 1850, 19, "Super Mario Bros." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 305, new DateTime(2008, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5349, "063837734-X", 499, 72, "Gold Rush  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 306, new DateTime(1924, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36093, "960252914-8", 2191, 29, "Once Upon a Crime..." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 307, new DateTime(2003, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7146, "654410229-6", 1087, 40, "Pier  The (Jetée  La)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 308, new DateTime(2014, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3097, "559707894-1", 467, 18, "Blind Side  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 309, new DateTime(1910, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40937, "151550123-X", 1810, 96, "Hardcover" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 310, new DateTime(1952, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25789, "820661736-1", 643, 71, "Money for Nothing" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 311, new DateTime(1972, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18515, "786750712-4", 523, 64, "Voices from the List" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 312, new DateTime(2001, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7911, "014915805-X", 1840, 6, "Sky Fighters (Les Chevaliers Du Ciel)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 313, new DateTime(1963, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21604, "590275253-1", 42, 84, "I as in Icarus (I... comme Icare)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 314, new DateTime(1972, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18546, "901813861-4", 1747, 72, "Texasville" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 315, new DateTime(1913, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 39984, "571457289-0", 286, 33, "Music Box  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 316, new DateTime(1940, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30196, "109885850-6", 2385, 28, "Blithe Spirit" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 317, new DateTime(1922, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36609, "208093769-3", 732, 74, "Blue Max  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 318, new DateTime(1913, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 39947, "444759468-4", 1901, 76, "Five Angles on Murder" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 319, new DateTime(1923, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36453, "195812117-7", 24, 57, "Transylmania" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 320, new DateTime(1971, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18954, "801265182-3", 981, 31, "Sharktopus vs. Pteracuda" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 321, new DateTime(2003, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6970, "139681068-4", 2886, 14, "Pirates of the Caribbean: The Curse of the Black Pearl" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 322, new DateTime(1971, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18867, "099191186-5", 22, 43, "Hans (Kukkulan kuningas) " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 323, new DateTime(2017, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2106, "558938758-2", 1604, 93, "Holiday Inn" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 324, new DateTime(1918, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38087, "253638086-6", 337, 92, "Iron Eagle II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 325, new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 574, "470248192-4", 1643, 49, "Space Is The Place" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 326, new DateTime(1980, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15470, "970513609-2", 167, 67, "Chronicles (Crónicas)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 327, new DateTime(1932, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33139, "460439169-6", 670, 37, "Gen 13 (a.k.a. Gen13: The Animated Movie)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 328, new DateTime(1994, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10555, "985721307-3", 708, 96, "Hit and Runway" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 329, new DateTime(1916, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38975, "071476500-7", 1245, 11, "Silmido" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 330, new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8995, "184521005-0", 173, 18, "8MM" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 331, new DateTime(1916, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 38990, "420477572-1", 945, 15, "Fire in Castilla (Tactilvision from the Moor of the Fright)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 332, new DateTime(1924, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36111, "362034946-0", 1766, 87, "Adventures of Food Boy  The (aka High School Superhero)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 333, new DateTime(2006, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6057, "948355535-3", 2727, 62, "Summer Wars (Samâ wôzu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 334, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1403, "250787087-7", 2506, 8, "Wrong Turn 5: Bloodlines" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 335, new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2109, "543782468-8", 2684, 4, "Bad Boy Bubby" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 336, new DateTime(1903, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 43577, "086177673-9", 1952, 38, "Nymph" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 337, new DateTime(1949, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26942, "545225495-1", 2859, 21, "Dead Men Don't Wear Plaid" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 338, new DateTime(1902, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 43883, "045465640-8", 2661, 47, "Fear" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 339, new DateTime(1982, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14961, "427253400-9", 1325, 92, "Beach  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 340, new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8388, "011844037-3", 1523, 21, "Forrest Gump" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 341, new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5693, "704313075-1", 1702, 3, "Rififi (Du rififi chez les hommes)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 342, new DateTime(1976, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17181, "411582484-0", 1608, 44, "Paranormal Activity: The Marked Ones" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 343, new DateTime(1948, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27231, "787639217-2", 1301, 31, "Rasputin" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 344, new DateTime(1983, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14372, "898597013-5", 2285, 46, "Royal Flash" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 345, new DateTime(1907, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42090, "366580884-7", 823, 34, "Cockpit" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 346, new DateTime(1922, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 36744, "005938214-7", 557, 35, "The Interview" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 347, new DateTime(1960, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22710, "362588585-9", 2165, 93, "Tarnished Angels  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 348, new DateTime(1926, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 35275, "336019186-2", 1717, 13, "Assassination of Richard Nixon  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 349, new DateTime(1940, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30113, "151942132-X", 1178, 84, "Philadelphia Experiment II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 350, new DateTime(1940, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30274, "352433549-7", 752, 29, "Flu" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 351, new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8068, "437930889-8", 623, 28, "Hotel" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 352, new DateTime(2006, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6066, "419262898-8", 690, 5, "Annie Hall" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 353, new DateTime(1912, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 40432, "850947903-8", 953, 22, "Merchant of Venice  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 354, new DateTime(1974, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 17897, "466048391-6", 1843, 62, "Hellboy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 355, new DateTime(2001, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8021, "824490852-1", 935, 58, "Little Miss Sunshine" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 356, new DateTime(1919, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 37656, "282499384-7", 2002, 37, "Amnèsia" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 357, new DateTime(1950, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26576, "469738420-2", 1139, 30, "Alive and Ticking (Ein Tick anders)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 358, new DateTime(1907, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 42198, "869260357-0", 2117, 48, "Prizzi's Honor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 359, new DateTime(1992, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11240, "431586600-8", 132, 64, "Wedding Party  The (Die Bluthochzeit)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 360, new DateTime(1955, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 24645, "550890168-X", 1942, 2, "They Shoot Horses  Don't They?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 361, new DateTime(1909, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 41322, "748876139-1", 2883, 45, "Enthusiasm (Entuziazm: Simfoniya Donbassa)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 362, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19727, "142218748-9", 2554, 59, "Hunted  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 363, new DateTime(1978, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16435, "331745028-2", 2745, 62, "She" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 364, new DateTime(2006, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6036, "954397051-3", 1076, 8, "Klitschko" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 365, new DateTime(1937, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 31087, "425084741-1", 1442, 15, "Happy New Year (La Bonne Année)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 366, new DateTime(2000, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8331, "777704517-2", 1886, 99, "Ewoks: The Battle for Endor" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 367, new DateTime(1908, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 41819, "119591921-2", 294, 65, "Cat's-Paw  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 368, new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9227, "492844968-1", 807, 1, "Road  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 369, new DateTime(2011, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4243, "562664012-6", 2698, 64, "Gifted Hands: The Ben Carson Story" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 370, new DateTime(1994, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10344, "539214432-2", 1648, 5, "Our Blushing Brides" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 371, new DateTime(1984, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14092, "777880488-3", 2937, 18, "Gangs of Wasseypur" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 372, new DateTime(1913, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40087, "299552233-4", 2087, 24, "Shrek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 373, new DateTime(1902, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 43898, "888924731-2", 1620, 8, "I Can't Think Straight" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 374, new DateTime(1948, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 27166, "296060627-2", 737, 36, "Judex" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 375, new DateTime(1969, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19726, "525804147-6", 1879, 59, "Good Year  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 376, new DateTime(2007, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5594, "783632954-2", 2534, 41, "Life as a House" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 377, new DateTime(1966, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20654, "038858002-X", 1699, 29, "Rosso" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 378, new DateTime(1930, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 33878, "903140448-9", 2902, 21, "Ghost of Frankenstein  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 379, new DateTime(1977, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16617, "596921321-7", 726, 52, "Last Letter  The (La dernière lettre)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 380, new DateTime(1944, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28847, "075552745-3", 2173, 82, "Goodbye Solo" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 381, new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1064, "433157482-2", 1675, 35, "St. Elmo's Fire" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 382, new DateTime(1919, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 37892, "629685563-X", 439, 37, "Slipping-Down Life  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 383, new DateTime(1919, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 37689, "346770644-4", 284, 42, "Bird" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 384, new DateTime(1979, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15916, "984315406-1", 467, 50, "Year One" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 385, new DateTime(2001, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7761, "499642138-X", 1084, 20, "Mexican  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 386, new DateTime(1941, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29870, "214074373-3", 135, 33, "Diaries of Vaslav Nijinsky  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 387, new DateTime(1924, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35845, "104970057-0", 334, 8, "Zen Noir" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 388, new DateTime(1934, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32183, "922761946-1", 774, 93, "Advance to the Rear" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 389, new DateTime(1971, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 18880, "300788120-X", 2077, 23, "Full Moon in Blue Water" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 390, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1197, "057086053-9", 1817, 19, "Stepfather II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 391, new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3001, "196222594-1", 1559, 23, "Salvador (Puig Antich)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 392, new DateTime(1914, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 39618, "890761462-8", 926, 19, "At Home by Myself... with You" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 393, new DateTime(1950, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 26343, "276080937-4", 1194, 68, "But Not for Me" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 394, new DateTime(1967, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 20329, "104539994-9", 1203, 13, "Enter the Void" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 395, new DateTime(1969, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 19551, "010294334-6", 803, 63, "Like Dandelion Dust" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 396, new DateTime(2018, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1590, "282061619-4", 651, 4, "Event Horizon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 397, new DateTime(1983, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14365, "761785069-7", 2056, 62, "Come and See (Idi i smotri)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 398, new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7691, "647692596-2", 651, 77, "Ravenous" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 399, new DateTime(1942, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 29503, "242633900-4", 1035, 9, "Dancing at the Blue Iguana" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 400, new DateTime(1975, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 17192, "732976485-X", 435, 3, "All Superheros Must Die" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 401, new DateTime(1997, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9408, "089827327-7", 2625, 77, "Ring  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 402, new DateTime(1953, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25363, "841652701-6", 284, 30, "Slaughterhouse" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 403, new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 17735, "005166019-9", 2998, 14, "Story of Three Loves  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 404, new DateTime(1947, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 27561, "489575244-5", 2596, 63, "Hammer  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 405, new DateTime(2017, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1859, "652104002-2", 416, 54, "The Inspector" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 406, new DateTime(1911, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40897, "515910427-5", 1011, 21, "Substitute  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 407, new DateTime(1933, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 32870, "970609908-5", 1982, 67, "Guinevere" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 408, new DateTime(1903, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 43503, "933560077-6", 2290, 78, "Karlsson Brothers (Bröderna Karlsson)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 409, new DateTime(1919, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 37678, "664787942-0", 1638, 30, "Macheads" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 410, new DateTime(1946, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27795, "899639325-8", 326, 56, "Watermelon Woman  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 411, new DateTime(1956, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 24191, "347741362-8", 1376, 44, "Phil Spector" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 412, new DateTime(1954, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 25193, "369202052-X", 1884, 75, "Big Steal  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 413, new DateTime(1979, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 16005, "134500740-X", 518, 55, "ABCs of Death  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 414, new DateTime(1912, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 40416, "647565144-3", 2904, 100, "Blue Like Jazz" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 415, new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15414, "063516944-4", 707, 77, "Northeast" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 416, new DateTime(1969, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19701, "670648382-6", 2236, 3, "Rasputin" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 417, new DateTime(1941, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 29833, "998785144-4", 2241, 79, "Jungle Fighters" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 418, new DateTime(2009, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5002, "590513508-8", 2452, 25, "Invitation to Happiness" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 419, new DateTime(1922, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 36789, "328642086-7", 1107, 37, "Raisin in the Sun  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 420, new DateTime(1941, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29741, "250637104-4", 1934, 88, "Don't Torture a Duckling (Non si sevizia un paperino)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 421, new DateTime(1913, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40077, "456418917-4", 2801, 66, "Psycho Beach Party" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 422, new DateTime(2001, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7786, "816279978-8", 445, 35, "Bad Boys" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 423, new DateTime(2001, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7989, "078057280-7", 1154, 37, "Whose Life Is It Anyway?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 424, new DateTime(1938, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30726, "570065088-6", 1379, 20, "Deathmaker  The (Totmacher  Der)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 425, new DateTime(1964, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21512, "624177071-3", 1458, 69, "Rain People  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 426, new DateTime(1964, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 21555, "412865636-4", 1784, 47, "Saving Otter 501" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 427, new DateTime(1997, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9170, "514036902-8", 60, 83, "Longtime Companion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 428, new DateTime(1984, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13924, "611545940-0", 1510, 10, "White Diamond  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 429, new DateTime(1939, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30589, "713017564-8", 2694, 86, "Who Is Harry Nilsson (And Why Is Everybody Talkin' About Him?)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 430, new DateTime(1971, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 18863, "416640007-X", 1963, 9, "Man in the Iron Mask  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 431, new DateTime(1970, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19087, "507903468-8", 1260, 80, "The Killing Jar" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 432, new DateTime(1948, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 27318, "665065306-3", 853, 94, "Alligator" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 433, new DateTime(1977, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 16625, "853082804-6", 1706, 18, "Pusher" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 434, new DateTime(1906, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42534, "902000165-5", 2458, 29, "Mr. Brooks" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 435, new DateTime(1989, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12165, "985669631-3", 1201, 30, "Grace Unplugged" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 436, new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10960, "469223621-3", 1381, 2, "Execution of P  The (Kinatay)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 437, new DateTime(1907, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42120, "214645187-4", 1735, 2, "Naked Weapon (Chek law dak gung)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 438, new DateTime(1924, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 35972, "374013550-6", 395, 24, "Animal House" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 439, new DateTime(1916, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 38799, "409592277-X", 2682, 9, "My Amityville Horror" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 440, new DateTime(2006, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5953, "030349464-6", 428, 91, "The Hellions" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 441, new DateTime(1986, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13399, "882361204-7", 1598, 4, "Tibet: Cry of the Snow Lion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 442, new DateTime(1961, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 22370, "742062198-5", 305, 53, "Punk Syndrome  The (Kovasikajuttu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 443, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 440, "364051961-2", 1529, 38, "Lisa" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 444, new DateTime(1902, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 44209, "865315847-2", 548, 36, "Shootist  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 445, new DateTime(1955, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 24521, "267122413-3", 1605, 43, "Blade II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 446, new DateTime(1974, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17692, "116217913-9", 2125, 29, "Pervert's Guide to Ideology  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 447, new DateTime(1923, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 36320, "047828017-3", 2695, 31, "Die Fischerin" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 448, new DateTime(1968, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19895, "570754997-8", 1876, 35, "Year of the Jellyfish (L'année des méduses)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 449, new DateTime(1925, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35473, "671807541-8", 2533, 17, "Fist of Jesus" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 450, new DateTime(1950, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26635, "932367853-8", 492, 74, "Beyond Tomorrow (Beyond Christmas)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 451, new DateTime(2009, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4985, "676279354-1", 2901, 54, "Calamari Union" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 452, new DateTime(1924, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 35886, "530876907-9", 1847, 31, "Texas Chainsaw 3D" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 453, new DateTime(1909, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 41398, "719809083-4", 2028, 50, "Pieta" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 454, new DateTime(1994, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10562, "779094175-5", 2224, 82, "Big Bad Mama II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 455, new DateTime(1926, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35372, "301539255-7", 115, 26, "Fay Grim" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 456, new DateTime(2001, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7697, "915257653-1", 1316, 85, "Un vampiro para dos" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 457, new DateTime(1959, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 23273, "837908672-4", 2881, 41, "Two Weeks in September" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 458, new DateTime(2007, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5736, "723424403-4", 594, 60, "Star Wars: Episode III - Revenge of the Sith" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 459, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "108116122-1", 2644, 76, "Bears" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 460, new DateTime(1937, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 31115, "535084992-1", 1492, 58, "Lost World  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 461, new DateTime(2012, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3680, "887854940-1", 735, 27, "Otis" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 462, new DateTime(1911, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40700, "659571185-0", 2992, 91, "Iron Man" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 463, new DateTime(2013, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3429, "576488560-4", 2056, 79, "Missile to the Moon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 464, new DateTime(1980, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15437, "944791284-2", 488, 54, "Marius" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 465, new DateTime(1931, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 33569, "668641127-2", 2486, 48, "Spring Forward" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 466, new DateTime(1920, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37370, "824586608-3", 1238, 11, "Patriot  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 467, new DateTime(1999, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8508, "485745262-6", 934, 59, "Katt Williams: Priceless: Afterlife" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 468, new DateTime(1931, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 33510, "744720414-5", 1050, 78, "Heart of Midnight" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 469, new DateTime(1962, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22290, "359146914-9", 2060, 32, "Killing Us Softly 4: Advertising's Image of Women" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 470, new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10389, "100482560-9", 2422, 47, "Army of Darkness" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 471, new DateTime(2012, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3741, "327589347-5", 2695, 86, "Living Proof" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 472, new DateTime(1983, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14556, "681322521-9", 2207, 46, "Rocky V" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 473, new DateTime(1993, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10978, "524538961-4", 2193, 71, "First Daughter" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 474, new DateTime(2001, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8053, "409386086-6", 1726, 63, "Mary" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 475, new DateTime(1995, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9963, "486702576-3", 2224, 34, "Dying Breed" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 476, new DateTime(1932, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 33033, "906598764-9", 1166, 34, "Young Detective Dee: Rise of the Sea Dragon (Di Renjie: Shen du long wang)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 477, new DateTime(1973, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17974, "384385305-3", 2410, 70, "Doctor  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 478, new DateTime(2016, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2548, "083370317-X", 1366, 44, "Mad Masters  The (Les maîtres fous)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 479, new DateTime(1949, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 27014, "340271374-8", 2564, 59, "Brother (Brat)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 480, new DateTime(1963, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 21822, "227461881-X", 920, 13, "Way Ahead  The (a.k.a. The Immortal Battalion)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 481, new DateTime(1925, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 35711, "456808697-3", 2362, 47, "Krays  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 482, new DateTime(1914, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 39801, "880466706-0", 1534, 20, "Cougars  Inc." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 483, new DateTime(1960, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 22882, "351737546-2", 359, 22, "The 11 Commandments" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 484, new DateTime(1933, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 32689, "003370257-8", 830, 4, "American Ninja 5" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 485, new DateTime(1928, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 34433, "094363556-X", 2712, 57, "Sins of My Father" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 486, new DateTime(1949, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26991, "333627472-9", 2374, 52, "Murder!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 487, new DateTime(1976, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 17154, "113803835-0", 994, 100, "Stop Making Sense" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 488, new DateTime(1966, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20661, "118854628-7", 1481, 61, "Hunter  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 489, new DateTime(1995, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10044, "799942188-X", 549, 10, "Tokyo Trial (Tokyo saiban)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 490, new DateTime(2015, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2870, "693417154-3", 1555, 85, "Holy Innocents  The (Santos inocentes  Los)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 491, new DateTime(1982, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14772, "806363853-0", 307, 63, "Union Square" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 492, new DateTime(1945, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 28343, "421648592-8", 2375, 44, "Till Human Voices Wake Us" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 493, new DateTime(1993, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10977, "031535973-0", 820, 17, "House II: The Second Story" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 494, new DateTime(1970, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19230, "423863350-4", 439, 56, "Faith School Menace?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 495, new DateTime(1904, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43423, "650347842-9", 1663, 40, "Boy Meets Girl" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 496, new DateTime(1955, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24814, "091660064-5", 2814, 36, "Wool Cap  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 497, new DateTime(1914, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 39732, "026965729-0", 303, 78, "From Paris with Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 498, new DateTime(2011, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4361, "873449182-1", 2365, 8, "Brainscan" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 499, new DateTime(1929, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34146, "751473416-3", 2684, 35, "Mark Shoots First" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 500, new DateTime(1996, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9815, "716881948-8", 223, 89, "Citizen Toxie: The Toxic Avenger IV" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 501, new DateTime(1931, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 33370, "568021200-5", 1791, 89, "Peggy Sue Got Married" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 502, new DateTime(1995, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9963, "773257395-1", 2681, 86, "Birds  the Bees and the Italians  The (Signore & signori)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 503, new DateTime(1952, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25839, "495401756-4", 139, 68, "Rocky III" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 504, new DateTime(1972, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 18286, "238854319-3", 1299, 13, "Football Factory  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 505, new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1953, "413665024-8", 224, 48, "Fires on the Plain (Nobi)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 506, new DateTime(1936, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31495, "031396136-0", 2079, 36, "Fighting Seabees  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 507, new DateTime(1917, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 38411, "305911337-8", 504, 66, "Bulletproof Monk" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 508, new DateTime(1982, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14823, "481304485-9", 1709, 72, "Ichi the Killer (Koroshiya 1)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 509, new DateTime(1904, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 43480, "536509347-X", 2459, 76, "Man with the Screaming Brain" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 510, new DateTime(1982, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14803, "730083869-3", 2210, 36, "Teen Spirit" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 511, new DateTime(1958, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23687, "870653034-6", 2883, 96, "Lost Boundaries" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 512, new DateTime(1902, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 44126, "930461500-3", 487, 30, "Popeye" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 513, new DateTime(1940, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30171, "456908243-2", 414, 82, "Patrick" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 514, new DateTime(1922, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 36555, "104814319-8", 1653, 40, "Remember Me" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 515, new DateTime(1953, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25422, "338970070-6", 2837, 47, "Love Meetings (Comizi d'amore)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 516, new DateTime(1931, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33358, "302464990-5", 2684, 30, "Henry" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 517, new DateTime(1976, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16961, "009360292-8", 2547, 6, "L.627" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 518, new DateTime(1912, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40491, "343134863-7", 2725, 80, "Me tulemme taas" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 519, new DateTime(1977, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16549, "599855439-6", 2672, 99, "Let It Be" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 520, new DateTime(2016, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2354, "739628009-5", 1693, 87, "Knot  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 521, new DateTime(1982, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14679, "388585133-4", 142, 43, "Of Mice and Men" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 522, new DateTime(1934, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 32470, "564541654-6", 2688, 16, "I Was Born  But... (a.k.a. Children of Tokyo) (Otona no miru ehon - Umarete wa mita keredo)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 523, new DateTime(1963, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21607, "087444420-9", 2133, 16, "Affluenza" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 524, new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10141, "692421134-8", 1602, 99, "Every Day" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 525, new DateTime(1976, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16912, "705933352-5", 52, 16, "Paperhouse" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 526, new DateTime(1917, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 38617, "050306395-9", 681, 24, "Lords of Flatbush  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 527, new DateTime(1917, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 38427, "749792379-X", 214, 56, "Jekyll & Hyde" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 528, new DateTime(1942, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 29283, "255259141-8", 1720, 33, "Rain" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 529, new DateTime(1926, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35251, "250701180-7", 85, 86, "Something Wild" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 530, new DateTime(2013, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3549, "500307235-X", 442, 66, "Singing Detective  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 531, new DateTime(1936, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31679, "802682234-X", 2410, 87, "13 Beloved (13 game sayawng)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 532, new DateTime(1920, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 37303, "391642173-5", 862, 10, "Black Coffee" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 533, new DateTime(1986, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 13473, "979532819-0", 1538, 43, "Gold Diggers of 1935" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 534, new DateTime(1937, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31159, "349835079-X", 1216, 23, "Taxi!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 535, new DateTime(1911, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40681, "600947949-5", 1129, 75, "Guns of Fort Petticoat  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 536, new DateTime(1954, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25139, "587238706-7", 2013, 36, "Coldblooded" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 537, new DateTime(2013, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3468, "252262224-2", 906, 18, "BloodRayne: The Third Reich" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 538, new DateTime(1929, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 34119, "979454955-X", 1433, 75, "Rigor Mortis (Geung si)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 539, new DateTime(1977, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16576, "444909627-4", 881, 77, "Nanny  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 540, new DateTime(1951, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25996, "926738861-4", 2708, 76, "Easy Money 2 (Snabba cash II)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 541, new DateTime(1986, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13464, "224083542-7", 1296, 65, "Jackass 3.5" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 542, new DateTime(1949, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26760, "585288807-9", 2294, 90, "Born in Flames" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 543, new DateTime(1922, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36908, "995316157-7", 1138, 50, "Deer Hunter  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 544, new DateTime(1937, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 31185, "892221883-5", 1369, 50, "Living in Emergency: Stories of Doctors Without Borders" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 545, new DateTime(1967, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20186, "011141396-6", 530, 90, "Fiddle-de-dee" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 546, new DateTime(1936, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 31627, "067918329-9", 2397, 48, "Wedding Trough (Vase de noces)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 547, new DateTime(1981, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15055, "264912495-4", 2343, 67, "Luther" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 548, new DateTime(1936, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 31646, "171130122-1", 981, 98, "Double  Double  Toil and Trouble" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 549, new DateTime(2006, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6123, "897991080-0", 2140, 68, "Bright Future (Akarui mirai)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 550, new DateTime(1971, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18653, "127318634-6", 2418, 86, "Inequality for All" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 551, new DateTime(2016, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2425, "750784013-1", 310, 21, "Brother" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 552, new DateTime(1923, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 36187, "477146392-1", 2715, 94, "Dirty Harry" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 553, new DateTime(1980, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15482, "704319150-5", 530, 86, "And Life Goes On (a.k.a. Life and Nothing More) (Zendegi va digar hich)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 554, new DateTime(2017, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2098, "958665354-4", 1809, 57, "Blood Ties" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 555, new DateTime(1971, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18717, "111135173-2", 492, 66, "Osmosis Jones" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 556, new DateTime(1992, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11026, "749846863-8", 2051, 27, "Brass Monkey" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 557, new DateTime(1910, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 41137, "406960068-X", 432, 67, "Mark of Zorro  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 558, new DateTime(1967, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20386, "621849487-X", 916, 72, "Paheli" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 559, new DateTime(1944, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 28724, "104248231-4", 2977, 95, "Great Muppet Caper  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 560, new DateTime(1934, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 32317, "211763838-4", 476, 76, "George Carlin: Life Is Worth Losing" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 561, new DateTime(1952, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25658, "240369716-8", 1657, 98, "Somebody to Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 562, new DateTime(1916, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38907, "580906761-1", 2751, 29, "Revenant  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 563, new DateTime(1903, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 43589, "868691329-6", 481, 100, "Le printemps  l'automne et l'amour" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 564, new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5863, "605080959-3", 129, 11, "Electra Glide in Blue" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 565, new DateTime(1994, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10601, "826689382-9", 456, 98, "Monty Python's Life of Brian" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 566, new DateTime(1948, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27107, "939695781-X", 2152, 95, "Desert Bloom" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 567, new DateTime(1924, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 35910, "412534757-3", 2569, 30, "Smilin' Through" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 568, new DateTime(1917, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 38576, "222003136-5", 112, 63, "Kill Theory" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 569, new DateTime(1977, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16478, "202168377-X", 1143, 81, "Rambo: First Blood Part II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 570, new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "164113235-3", 1437, 10, "Stray Dog (Nora inu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 571, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 860, "814573297-2", 253, 85, "End of America  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 572, new DateTime(1969, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19679, "730709435-5", 2094, 56, "Fiorile" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 573, new DateTime(1916, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39016, "907602162-7", 84, 66, "Paying the Price: Killing the Children of Iraq" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 574, new DateTime(1986, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13432, "924281169-6", 2254, 23, "Christmas on Mars" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 575, new DateTime(1928, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 34383, "488862040-7", 1253, 95, "Straightheads (Closure)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 576, new DateTime(1994, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10379, "555406868-5", 1683, 45, "Urban Ghost Story" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 577, new DateTime(1913, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39842, "626243074-1", 1768, 1, "Chase a Crooked Shadow" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 578, new DateTime(1908, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42012, "677226940-3", 2073, 9, "Bucket of Blood  A (Dark Secrets) (Death Artist  The)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 579, new DateTime(1943, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 28938, "781131933-0", 1018, 70, "Every Which Way But Loose" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 580, new DateTime(2005, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6251, "005658859-3", 1011, 19, "Growing Pains" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 581, new DateTime(1900, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44609, "838639016-6", 2959, 70, "David et Madame Hansen" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 582, new DateTime(1941, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29644, "498806263-5", 1820, 71, "Child Is Waiting  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 583, new DateTime(1912, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 40355, "429451569-4", 1712, 29, "Union Pacific" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 584, new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2027, "608194593-6", 2603, 21, "Children of Men" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 585, new DateTime(1907, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 42289, "657936238-3", 2313, 72, "The Paris Express" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 586, new DateTime(1933, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 32867, "998234189-8", 337, 16, "X from Outer Space  The (Uchû daikaijû Girara)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 587, new DateTime(2010, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4746, "856306595-5", 360, 98, "Prophecy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 588, new DateTime(1907, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 42164, "904067804-9", 2442, 11, "Montenegro" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 589, new DateTime(1928, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 34534, "914274754-6", 2236, 54, "Marva Collins Story  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 590, new DateTime(1955, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 24639, "204409556-4", 350, 58, "Starship Troopers 2: Hero of the Federation" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 591, new DateTime(2014, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3035, "557289340-4", 2005, 80, "Killer Condom (Kondom des Grauens)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 592, new DateTime(1956, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 24371, "009974329-9", 2854, 92, "24 Hour Woman  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 593, new DateTime(1964, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21314, "221773053-3", 212, 98, "Muhammad Ali's Greatest Fight" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 594, new DateTime(1965, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 21190, "025856398-2", 933, 66, "Legally Blonde 2: Red  White & Blonde" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 595, new DateTime(1920, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37602, "354668186-X", 2477, 82, "Magic Sword  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 596, new DateTime(2011, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4278, "970643009-1", 886, 69, "Dead Genesis" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 597, new DateTime(2016, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2363, "088261187-9", 86, 30, "Trek Nation" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 598, new DateTime(1976, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17057, "142038855-X", 591, 58, "Million Dollar Legs" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 599, new DateTime(1983, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14305, "688054396-0", 1585, 59, "The Haunting of Helena" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 600, new DateTime(1902, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 44079, "731764481-1", 1204, 24, "Helen" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 601, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 903, "802858414-4", 211, 31, "Return of the Pink Panther  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 602, new DateTime(1906, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42652, "814381809-8", 2568, 88, "All About the Benjamins" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 603, new DateTime(1967, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20335, "943125112-4", 1392, 74, "Coup de grâce (Der Fangschuß)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 604, new DateTime(1946, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27992, "286811949-2", 2314, 37, "Decameron  The (Decameron  Il)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 605, new DateTime(2013, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3618, "345728253-6", 1104, 65, "16 Blocks" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 606, new DateTime(1948, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27246, "292106619-X", 208, 63, "Lost Weekend  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 607, new DateTime(1923, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36367, "284326341-7", 2407, 86, "Alligator Eyes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 608, new DateTime(1953, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25272, "351331102-8", 2236, 48, "The Squeeze" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 609, new DateTime(1906, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 42438, "838364654-2", 1743, 47, "Age of Stupid  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 610, new DateTime(2004, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6927, "660839829-8", 693, 42, "Bravo Two Zero " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 611, new DateTime(1976, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17044, "855580561-9", 2168, 51, "Resurrect Dead: The Mystery of the Toynbee Tiles" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 612, new DateTime(2010, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4748, "822408208-3", 2323, 32, "Adios Carmen" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 613, new DateTime(1995, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000, "727759561-0", 2925, 97, "Myn Bala: Warriors of the Steppe" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 614, new DateTime(1936, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31681, "756654847-6", 1357, 29, "Post Grad" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 615, new DateTime(1923, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36495, "758447266-4", 2196, 48, "Death of Mr. Lazarescu  The (Moartea domnului Lazarescu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 616, new DateTime(1955, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24648, "551525818-5", 1570, 72, "Miracle of Marcelino  The (Marcelino pan y vino)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 617, new DateTime(1944, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28804, "496847346-X", 2638, 15, "Sweeney Todd" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 618, new DateTime(1943, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 29032, "197955582-6", 2501, 43, "Hamoun" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 619, new DateTime(1935, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 31825, "059680656-6", 2614, 95, "Great Debaters  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 620, new DateTime(1932, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33043, "368276180-2", 755, 86, "On Her Majesty's Secret Service" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 621, new DateTime(1997, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9308, "271787685-5", 1976, 19, "Like Mike" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 622, new DateTime(1916, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 39058, "482364979-6", 382, 23, "Teddy Bear (10 timer til Paradis)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 623, new DateTime(1981, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15218, "777711294-5", 2991, 59, "Abbott and Costello in the Foreign Legion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 624, new DateTime(2000, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8322, "804588292-1", 2420, 50, "Closet  The (Placard  Le)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 625, new DateTime(1941, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 29940, "495087045-9", 42, 66, "Pirates Who Don't Do Anything: A VeggieTales Movie  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 626, new DateTime(1921, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 37271, "946477236-0", 1451, 8, "Love Crazy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 627, new DateTime(1963, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21706, "052308863-9", 2728, 89, "Nanny McPhee" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 628, new DateTime(1958, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23632, "855775871-5", 2848, 22, "Witch Who Came from the Sea  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 629, new DateTime(2014, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3167, "070732514-5", 1748, 34, "Son of the White Mare" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 630, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 181, "558605258-X", 1087, 69, "Supercross" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 631, new DateTime(1982, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14728, "810562676-4", 1397, 9, "Safe Sex" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 632, new DateTime(2009, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4790, "057027257-2", 836, 25, "Jesus Camp" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 633, new DateTime(1971, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 18946, "645759126-4", 1107, 59, "D.E.B.S." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 634, new DateTime(1927, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35018, "059289653-6", 2639, 43, "You May Not Kiss the Bride" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 635, new DateTime(1968, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20022, "656858323-5", 2662, 29, "V/H/S: Viral" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 636, new DateTime(1926, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35169, "774617720-4", 1979, 35, "Finian's Rainbow" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 637, new DateTime(1990, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11730, "237825010-X", 2897, 96, "Spy Kids: All the Time in the World in 4D" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 638, new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8406, "401518831-4", 996, 81, "Dance of Reality  The (Danza de la realidad  La)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 639, new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4583, "643049432-2", 324, 34, "Eureka" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 640, new DateTime(1982, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14979, "546451931-9", 1889, 40, "Stranger Among Us  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 641, new DateTime(1928, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34437, "209718326-3", 1732, 7, "Why Not? (Eijanaika)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 642, new DateTime(1968, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19883, "532722341-8", 793, 43, "Out of the Ashes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 643, new DateTime(2000, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8336, "336171306-4", 165, 34, "No Man's Land" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 644, new DateTime(1949, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27000, "788550753-X", 1084, 88, "Woman on Top" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 645, new DateTime(2010, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4539, "374917501-2", 2384, 45, "Tooth Fairy 2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 646, new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6793, "152800213-X", 1023, 31, "Kiki's Delivery Service (Majo no takkyûbin)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 647, new DateTime(1918, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38054, "178266622-2", 1135, 90, "The Last Gladiators" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 648, new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15414, "352106476-X", 210, 11, "Good Mother  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 649, new DateTime(1957, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 23830, "153131723-5", 2330, 6, "Wrong Move  The (Falsche Bewegung)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 650, new DateTime(1914, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 39476, "588753930-5", 101, 21, "High Test Girls" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 651, new DateTime(2011, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4089, "292838473-1", 1357, 24, "Bonsái" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 652, new DateTime(1903, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 43809, "619055539-X", 1469, 27, "Lad: A Dog" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 653, new DateTime(1937, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 31369, "693216061-7", 1335, 83, "Amazing Journey: The Story of The Who" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 654, new DateTime(1946, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27962, "037370952-8", 1499, 75, "Millennium Actress (Sennen joyû)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 655, new DateTime(1957, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 23960, "620785513-2", 642, 29, "Between Two Worlds" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 656, new DateTime(1958, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 23735, "761787626-2", 2449, 68, "Air Bud" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 657, new DateTime(1938, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30765, "221037307-7", 583, 95, "Candles on Bay Street " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 658, new DateTime(1908, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 41841, "059448911-3", 1104, 92, "If I Had a Million" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 659, new DateTime(1976, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17002, "130671261-0", 51, 6, "Monty Python's The Meaning of Life" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 660, new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33261, "853146735-7", 2238, 48, "Lord of Tears" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 661, new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7846, "782334908-6", 961, 88, "Grace Lee Project  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 662, new DateTime(2018, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1774, "196892732-8", 469, 2, "What Have I Done to Deserve This? (¿Qué he hecho yo para merecer esto!!)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 663, new DateTime(1981, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15243, "721681572-6", 243, 67, "Three-Step Dance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 664, new DateTime(1921, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 37223, "850591305-1", 616, 9, "Buddy Boy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 665, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "208892461-2", 2874, 67, "Introducing Dorothy Dandridge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 666, new DateTime(1976, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17086, "484897821-1", 2806, 78, "Teheran 43: Spy Ring (a.k.a. Assassination Attempt) (Tegeran-43)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 667, new DateTime(1957, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23885, "765008030-7", 2085, 100, "Last Summer in the Hamptons" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 668, new DateTime(1995, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9969, "154830292-9", 929, 61, "Lupin III: The Castle Of Cagliostro (Rupan sansei: Kariosutoro no shiro)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 669, new DateTime(1973, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18116, "666605190-4", 1395, 36, "Hunky Dory" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 670, new DateTime(1942, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 29462, "791239865-1", 94, 97, "Ethel" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 671, new DateTime(1921, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 37250, "134585520-6", 635, 31, "Bikini Beach" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 672, new DateTime(1915, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39178, "245870543-X", 1835, 33, "Woman Who Drinks  The (La femme qui boit)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 673, new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7898, "612856255-8", 1810, 31, "Apple Dumpling Gang  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 674, new DateTime(1949, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26767, "058275163-2", 795, 11, "The Brides of Fu Manchu" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 675, new DateTime(1963, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21649, "209460697-X", 1174, 6, "Seed" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 676, new DateTime(1952, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 25849, "338020342-4", 2661, 31, "Dead Man's Walk" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 677, new DateTime(1956, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 24232, "397265841-9", 644, 98, "Breathing Room" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 678, new DateTime(1907, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 42209, "147258091-5", 1005, 65, "Seize the Day" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 679, new DateTime(1968, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19792, "701476833-6", 2012, 38, "Deathstalker II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 680, new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18112, "990327424-6", 1560, 33, "Caine Mutiny Court-Martial  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 681, new DateTime(1903, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 43606, "522042417-3", 1233, 6, "Little Lord Fauntleroy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 682, new DateTime(1983, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14578, "636715372-1", 969, 46, "Back to the Future Part III" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 683, new DateTime(1909, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 41483, "313230318-6", 1483, 28, "Mangler  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 684, new DateTime(2000, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8280, "409234235-7", 907, 79, "Backstairs (Hintertreppe)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 685, new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13806, "886936691-X", 2508, 54, "Uncovered" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 686, new DateTime(1968, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19749, "686975766-6", 2369, 66, "Skyjacked" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 687, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1390, "597858724-8", 1450, 92, "Out for a Kill" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 688, new DateTime(1992, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11126, "808469564-9", 1867, 39, "Timerider: The Adventure of Lyle Swann" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 689, new DateTime(1994, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 10277, "229599020-3", 460, 1, "Death of Mr. Lazarescu  The (Moartea domnului Lazarescu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 690, new DateTime(1986, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13386, "450252725-4", 1975, 8, "Damned the Day I Met You" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 691, new DateTime(1904, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 43317, "331973345-1", 700, 94, "When Jews Were Funny" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 692, new DateTime(1900, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 44734, "223594108-7", 1505, 61, "Severed Arm  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 693, new DateTime(1946, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28110, "705680908-1", 1322, 16, "Nine Ways to Approach Helsinki (Yhdeksän tapaa lähestyä Helsinkiä)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 694, new DateTime(1924, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35965, "682050654-6", 1517, 11, "Hiding Cot (Piilopirtti)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 695, new DateTime(1940, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 29990, "358161598-3", 123, 91, "Time Traveler's Wife  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 696, new DateTime(1982, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14638, "188844470-3", 145, 23, "Other Dream Team  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 697, new DateTime(1980, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15653, "227258404-7", 140, 68, "Blink" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 698, new DateTime(1918, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 38132, "950843945-9", 2043, 43, "American Outlaws" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 699, new DateTime(1992, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11290, "067801240-7", 459, 80, "Castle of Cloads  The (Pilvilinna)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 700, new DateTime(2013, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3377, "634715964-3", 1424, 70, "Recount" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 701, new DateTime(2012, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3818, "682868375-7", 699, 43, "Seed" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 702, new DateTime(2009, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4851, "455542109-4", 1896, 53, "Great Passage  The (Fune wo amu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 703, new DateTime(1952, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25634, "478100782-1", 1008, 90, "Went the Day Well?" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 704, new DateTime(2001, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7796, "090593156-4", 2561, 28, "Boys Life" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 705, new DateTime(1923, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 36384, "475524566-4", 841, 13, "Deadline" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 706, new DateTime(2004, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6772, "524874398-2", 2113, 95, "Querelle" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 707, new DateTime(1969, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19579, "029742686-9", 2573, 23, "Trapped Ashes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 708, new DateTime(2005, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6472, "547989140-5", 91, 87, "Lucky Lady" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 709, new DateTime(1903, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43737, "524523299-5", 2520, 19, "Flodder in Amerika!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 710, new DateTime(1926, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35098, "282582235-3", 651, 88, "Island of Lost Souls" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 711, new DateTime(1912, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40549, "166204841-6", 2988, 62, "Clean Slate" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 712, new DateTime(1994, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10381, "688406384-X", 1563, 31, "Night Ambush (Ill Met by Moonlight)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 713, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 932, "469832676-1", 880, 8, "Heimat - A Chronicle of Germany (Heimat - Eine deutsche Chronik)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 714, new DateTime(1970, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 19281, "199411419-3", 1194, 20, "Gangsters" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 715, new DateTime(1937, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31363, "874251921-7", 1458, 97, "Princess Mononoke (Mononoke-hime)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 716, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1599, "201189933-8", 2387, 89, "Simpsons: The Longest Daycare  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 717, new DateTime(1949, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 26853, "264378907-5", 2018, 31, "Simpsons Movie  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 718, new DateTime(1964, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21316, "744774785-8", 694, 82, "Commander Hamilton (Hamilton)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 719, new DateTime(1933, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32739, "222574759-8", 2240, 73, "Roman" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 720, new DateTime(1902, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 43933, "381541863-1", 52, 66, "Elevator " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 721, new DateTime(1959, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 23099, "128315275-4", 1106, 51, "Bury My Heart at Wounded Knee" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 722, new DateTime(2015, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2859, "614584482-5", 1749, 51, "Green Ray  The (Rayon vert  Le)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 723, new DateTime(1961, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22475, "457092876-5", 2031, 77, "Ice Castles" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 724, new DateTime(1986, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13434, "814239293-3", 2137, 35, "Don't Torture a Duckling (Non si sevizia un paperino)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 725, new DateTime(1951, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26155, "329044524-0", 2416, 61, "Deadly Trap  The (La maison sous les arbres)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 726, new DateTime(1944, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 28624, "641885769-0", 2781, 34, "Madonna: Truth or Dare" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 727, new DateTime(1946, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27869, "619627005-2", 184, 57, "Double Dynamite" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 728, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14894, "386624951-9", 2392, 50, "Live Nude Girls Unite!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 729, new DateTime(1943, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29173, "326659460-6", 2060, 12, "God's Pocket" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 730, new DateTime(1929, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34274, "259084724-6", 1961, 71, "Housekeeper  The (femme de ménage  Une)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 731, new DateTime(1970, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19311, "202388938-3", 927, 12, "All Cheerleaders Die" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 732, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21697, "499719352-6", 1879, 67, "Gun the Man Down" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 733, new DateTime(1994, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10442, "897740329-4", 1787, 14, "Short Sharp Shock (Kurz und schmerzlos) " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 734, new DateTime(1934, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 32295, "008881477-7", 1141, 28, "Dragon Ball: Mystical Adventure (Doragon bôru: Makafushigi dai bôken)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 735, new DateTime(1923, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 36540, "002846128-2", 2803, 45, "John Q" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 736, new DateTime(1959, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23108, "335343696-0", 1524, 84, "Jeepers Creepers" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 737, new DateTime(1977, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16631, "542426019-5", 1466, 51, "Big Bad Wolves" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 738, new DateTime(1952, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25721, "280389127-1", 201, 41, "Love Is a Many-Splendored Thing" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 739, new DateTime(1987, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 12965, "151153853-8", 2888, 40, "House IV" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 740, new DateTime(1976, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16945, "073177131-1", 701, 17, "OSS 117: Cairo  Nest of Spies (OSS 117: Le Caire nid d'espions)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 741, new DateTime(1967, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20232, "884454119-X", 2691, 68, "Heartbeeps" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 742, new DateTime(1907, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 42052, "996522345-9", 307, 45, "Call Northside 777" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 743, new DateTime(2006, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6157, "683848556-7", 1295, 12, "Breaking Wind" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 744, new DateTime(1923, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36214, "718608686-1", 1006, 3, "Blood Diamond" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 745, new DateTime(1999, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8653, "980294682-6", 2198, 69, "Heli" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 746, new DateTime(1909, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 41317, "061598774-5", 2952, 86, "Millionaire for Christy  A (Golden Goose) (No Room for the Groom)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 747, new DateTime(1913, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39995, "477654644-2", 1647, 59, "Nothing's All Bad" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 748, new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12261, "189504336-0", 221, 34, "3 Blind Mice" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 749, new DateTime(1937, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 31426, "213800671-9", 686, 25, "There Goes My Baby" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 750, new DateTime(1905, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 43090, "549284859-3", 2983, 35, "Full Monty  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 751, new DateTime(1948, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 27304, "588315595-2", 235, 55, "Prize Winner of Defiance Ohio  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 752, new DateTime(1900, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 44597, "443450545-9", 1343, 50, "Society" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 753, new DateTime(1907, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 42186, "344811417-0", 1147, 43, "Othello" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 754, new DateTime(1924, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 36096, "625659062-7", 2635, 35, "Milky Way  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 755, new DateTime(2001, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7857, "073624659-2", 1234, 69, "Mummy's Ghost  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 756, new DateTime(1949, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27007, "250780523-4", 389, 33, "Fading Gigolo" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 757, new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15043, "181027951-8", 562, 84, "Death of a Dynasty" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 758, new DateTime(1958, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23532, "277476567-6", 340, 48, "Fantastic Mr. Fox" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 759, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1592, "056558409-X", 463, 7, "She's So Lovely" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 760, new DateTime(1928, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 34719, "438410478-2", 244, 79, "23 Paces to Baker Street" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 761, new DateTime(1912, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 40480, "000515695-5", 2890, 47, "40 Pounds of Trouble" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 762, new DateTime(1956, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24328, "952851088-4", 384, 80, "Officer's Ward (chambre des officiers  La)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 763, new DateTime(2016, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2236, "020525417-9", 2957, 7, "Midnight in Paris" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 764, new DateTime(1982, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14677, "248931007-0", 2723, 39, "Fire Birds" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 765, new DateTime(1934, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 32269, "680826114-8", 2233, 9, "In Enemy Hands" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 766, new DateTime(1933, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32738, "320280768-4", 1316, 14, "The Plague of the Zombies" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 767, new DateTime(1985, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13540, "229280026-8", 2087, 33, "White Dwarf  The (Valkoinen kääpiö)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 768, new DateTime(2006, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5885, "921219889-9", 1626, 92, "Letting Go of God" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 769, new DateTime(1993, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10788, "223061986-1", 1812, 47, "World Is Not Enough  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 770, new DateTime(1905, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 43077, "225518023-5", 1955, 94, "Big Shot's Funeral (Da Wan)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 771, new DateTime(1963, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 21814, "410055480-X", 1501, 23, "Open Season" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 772, new DateTime(1970, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 19067, "303574128-X", 1950, 1, "Boys Life 4: Four Play" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 773, new DateTime(1972, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18358, "290176799-0", 677, 66, "Min and Bill" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 774, new DateTime(1990, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11799, "258970476-3", 2937, 82, "Back to the Secret Garden" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 775, new DateTime(1970, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 19034, "756728994-6", 1010, 61, "Georgy Girl" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 776, new DateTime(1979, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 15743, "355812862-1", 2561, 36, "I Am Not a Hipster" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 777, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1044, "869816300-9", 948, 63, "Twilight of the Golds  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 778, new DateTime(1922, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 36765, "659173597-6", 187, 40, "Civil Brand" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 779, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 666, "172003260-2", 2808, 79, "Three Stooges in Orbit  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 780, new DateTime(1964, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21390, "470838021-6", 1441, 88, "Slumber Party Massacre  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 781, new DateTime(1945, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 28492, "657258235-3", 900, 90, "Changeling" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 782, new DateTime(1959, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23367, "405045143-3", 1364, 47, "Kill Me Later" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 783, new DateTime(1979, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15892, "625099171-9", 342, 86, "Memento Mori (Yeogo goedam II)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 784, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1477, "263797983-6", 750, 48, "Kimjongilia" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 785, new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9042, "558548903-8", 1067, 23, "Charley Varrick" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 786, new DateTime(1912, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40334, "218734190-9", 2067, 4, "Four more years (Fyra år till)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 787, new DateTime(1961, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22386, "661406239-5", 1897, 53, "December 7th" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 788, new DateTime(2000, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8257, "354855098-3", 2823, 92, "Breed  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 789, new DateTime(1921, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 37272, "491121545-3", 313, 17, "Nobody Will Speak of Us When We're Dead (Nadie hablará de nosotras cuando hayamos muerto)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 790, new DateTime(1983, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14456, "952448354-8", 1274, 81, "Poseidon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 791, new DateTime(1983, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14399, "155989287-0", 1058, 79, "Boys of St. Vincent  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 792, new DateTime(1980, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15573, "793786322-6", 1765, 76, "Bats" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 793, new DateTime(2016, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2448, "246170169-5", 2432, 59, "Brighton Rock" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 794, new DateTime(1938, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 31058, "533435724-6", 1196, 12, "Desert Hearts" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 795, new DateTime(1908, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 41972, "096464826-1", 1668, 4, "Legally Blondes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 796, new DateTime(1953, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25276, "932951482-0", 2903, 90, "Songs From the Second Floor (Sånger från andra våningen)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 797, new DateTime(2014, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3100, "341500787-1", 2575, 49, "Populaire" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 798, new DateTime(1900, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 44684, "722234978-2", 2548, 34, "Better Than Chocolate" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 799, new DateTime(1982, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14913, "729465490-5", 104, 87, "Martin & Orloff" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 800, new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 423, "689887686-4", 2648, 51, "Power (Jew Süss)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 801, new DateTime(1967, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20266, "165353336-6", 2526, 63, "Elite Squad (Tropa de Elite)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 802, new DateTime(2017, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1881, "581802038-X", 2299, 40, "Asoka (Ashoka the Great)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 803, new DateTime(2015, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2640, "663511297-9", 735, 44, "Divorce" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 804, new DateTime(2008, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5367, "659041613-3", 1340, 50, "Schizopolis" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 805, new DateTime(1947, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 27417, "725008696-0", 152, 50, "Rebirth of Mothra" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 806, new DateTime(1979, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16088, "137817333-3", 1697, 6, "Spanglish" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 807, new DateTime(1966, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20777, "661281399-7", 471, 18, "Socialism (Film socialisme)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 808, new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4740, "261249707-2", 2453, 98, "Man Who Could Work Miracles  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 809, new DateTime(1926, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 35448, "849513762-3", 122, 31, "Ghost Rider" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 810, new DateTime(1917, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38528, "796010235-X", 2765, 93, "Harold & Kumar Escape from Guantanamo Bay" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 811, new DateTime(1965, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21162, "176919944-6", 1798, 57, "Young Lieutenant  The (Le petit lieutenant)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 812, new DateTime(1922, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 36803, "792576331-0", 2150, 45, "Pride and Glory" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 813, new DateTime(1972, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18546, "031246304-9", 1262, 36, "I Wake Up Screaming" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 814, new DateTime(1946, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28116, "189047837-7", 1063, 59, "Art of Flight  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 815, new DateTime(1901, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44311, "644859051-X", 2332, 5, "Black Cauldron  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 816, new DateTime(1934, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 32451, "875697410-8", 2576, 43, "Scattered Clouds (Midaregumo)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 817, new DateTime(1992, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11236, "484811519-1", 2876, 25, "Jude the Obscure" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 818, new DateTime(1967, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20214, "410991984-3", 2375, 30, "Rated X" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 819, new DateTime(2006, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6215, "678297390-1", 11, 65, "Deep  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 820, new DateTime(1987, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13020, "274266487-4", 317, 12, "Willow Creek" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 821, new DateTime(1995, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10107, "226470796-8", 2305, 92, "Balkan Spy (Balkanski spijun)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 822, new DateTime(2000, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8238, "967730842-4", 82, 48, "Kung Fu Panda" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 823, new DateTime(2002, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7668, "591099737-8", 283, 32, "Above Us Only Sky" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 824, new DateTime(1985, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13637, "075010259-4", 2404, 82, "Island in the Sun" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 825, new DateTime(1984, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13950, "896188110-8", 1244, 38, "Common Threads: Stories from the Quilt" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 826, new DateTime(1922, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36891, "617538506-3", 1098, 57, "Madhouse" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 827, new DateTime(1983, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14575, "384215923-4", 1224, 11, "Some Girl(s)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 828, new DateTime(1954, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25089, "815593266-4", 1999, 17, "Moog" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 829, new DateTime(2005, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6481, "253663522-8", 1172, 60, "Man of the Year" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 830, new DateTime(1904, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 43441, "314945615-0", 450, 73, "Descent  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 831, new DateTime(1914, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39686, "474073929-1", 977, 46, "Four Shades of Brown (Fyra nyanser av brunt)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 832, new DateTime(1927, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 34788, "894133467-5", 1446, 85, "Page Eight" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 833, new DateTime(2002, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7437, "033562024-8", 2648, 46, "Uptown Saturday Night" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 834, new DateTime(1932, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 33138, "955711251-4", 419, 65, "Jo Pour Jonathan" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 835, new DateTime(1991, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11354, "008176310-7", 1960, 85, "Manchurian Candidate  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 836, new DateTime(1911, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40590, "280844984-4", 1426, 20, "Roaring Twenties  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 837, new DateTime(1992, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11019, "558701202-6", 1129, 18, "Brother Bear" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 838, new DateTime(1987, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12870, "483507707-5", 922, 12, "Stone Left Unturned  A (Kovat miehet)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 839, new DateTime(2015, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2782, "710446388-7", 243, 25, "Railway Children  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 840, new DateTime(1929, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 34272, "774215734-9", 1373, 9, "Promise of the Flesh (Yukcheui yaksok)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 841, new DateTime(1975, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17459, "837857774-0", 2866, 67, "Heat" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 842, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14287, "124229022-2", 471, 33, "Mon Oncle (My Uncle)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 843, new DateTime(2003, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7198, "224070872-7", 1130, 78, "Bedford Incident  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 844, new DateTime(1904, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 43163, "056912257-0", 1153, 4, "George and the Dragon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 845, new DateTime(1937, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31110, "311254356-4", 1459, 92, "Silences of the Palace  The (Saimt el Qusur)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 846, new DateTime(1923, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 36378, "270389518-6", 1822, 92, "Winning Streak" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 847, new DateTime(1954, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25077, "721661949-8", 638, 77, "My Super Ex-Girlfriend" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 848, new DateTime(1931, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33409, "711537912-2", 1842, 4, "Macheads" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 849, new DateTime(1901, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 44468, "454217761-0", 1101, 40, "Whirlygirl" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 850, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, "125637661-2", 929, 5, "Immature  The (Immaturi)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 851, new DateTime(2012, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3734, "705100002-0", 1249, 99, "Business as Usual" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 852, new DateTime(2008, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5436, "787759378-3", 2216, 85, "Full Moon High" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 853, new DateTime(1931, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 33604, "076411651-7", 2805, 39, "Favorite Deadly Sins" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 854, new DateTime(1902, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 44204, "385814263-8", 2853, 84, "Fitzgerald Family Christmas  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 855, new DateTime(1942, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 29530, "663801692-X", 2838, 32, "Hijack That Went South  The (Kaappari)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 856, new DateTime(1922, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36556, "158473203-2", 980, 58, "Dylan Dog: Dead of Night" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 857, new DateTime(1978, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16149, "117929462-9", 802, 17, "Parkland" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 858, new DateTime(1960, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22747, "900481077-3", 342, 90, "Nativity!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 859, new DateTime(1966, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 20665, "945321031-5", 2596, 44, "I Think I Love My Wife" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 860, new DateTime(2015, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2770, "381908547-5", 1278, 18, "Patrik Age 1.5 (Patrik 1 5)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 861, new DateTime(1966, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 20730, "297697622-8", 1744, 50, "Reconstruction" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 862, new DateTime(1999, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8661, "061959258-3", 2184, 81, "Intruder  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 863, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "260280921-7", 781, 52, "Beyond Silence (Jenseits der Stille)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 864, new DateTime(2015, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2943, "482678972-6", 1451, 43, "Trucker" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 865, new DateTime(1939, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30407, "904013674-2", 271, 10, "Hannah Free" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 866, new DateTime(1944, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 28669, "458351133-7", 2555, 66, "The Miracle of Our Lady of Fatima" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 867, new DateTime(1940, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30242, "930918746-8", 1395, 99, "At the Circus" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 868, new DateTime(1989, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 12138, "327438670-7", 622, 66, "Human Condition II  The (Ningen no joken II)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 869, new DateTime(1977, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16641, "773004011-5", 2775, 6, "Paper Birds (Pájaros de papel)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 870, new DateTime(1982, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14714, "230218630-3", 2334, 28, "Tribe  The (Plemya)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 871, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3416, "308744961-X", 1214, 89, "Holiday" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 872, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9246, "125720325-8", 371, 13, "One A.M." });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 873, new DateTime(1946, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 28025, "847873792-8", 2809, 19, "Dragon Ball: The Path to Power (Doragon bôru: Saikyô e no michi)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 874, new DateTime(1944, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28809, "951228827-3", 478, 76, "Christmas Carol  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 875, new DateTime(1966, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20730, "302385781-4", 2399, 71, "Better Tomorrow III: Love and Death in Saigon  A" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 876, new DateTime(1912, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 40284, "248087288-2", 2956, 55, "Lodger  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 877, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1114, "230906210-3", 2183, 24, "Infidel  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 878, new DateTime(1939, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30466, "132261724-4", 2668, 69, "Abandoned  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 879, new DateTime(1903, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 43845, "776433410-3", 2695, 54, "Carmina and Amen (Carmina y amén)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 880, new DateTime(1994, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10597, "301687170-X", 846, 23, "Wild Orchid" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 881, new DateTime(1936, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 31754, "818762211-3", 2922, 40, "Hard to Hold" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 882, new DateTime(1982, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 14800, "902589563-8", 1766, 20, "Amityville 1992: It's About Time" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 883, new DateTime(1906, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 42518, "505940487-0", 713, 9, "At First Sight" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 884, new DateTime(1992, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11204, "562715429-2", 1806, 17, "Common Thread  A (a.k.a. Sequins) (Brodeuses)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 885, new DateTime(1903, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 43835, "842864208-7", 1149, 60, "Abraham's Valley (Vale Abraão)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 886, new DateTime(1964, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21248, "502366670-0", 2238, 83, "Putzel" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 887, new DateTime(1921, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 37185, "948192538-2", 1560, 20, "Monday" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 888, new DateTime(1969, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19695, "685877104-2", 2279, 22, "In Praise of Older Women" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 889, new DateTime(2006, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6064, "685525083-1", 2688, 30, "Motocrossed" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 890, new DateTime(1902, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 43894, "941330695-8", 771, 38, "Come Back to Me" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 891, new DateTime(1943, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 29060, "472229508-5", 800, 41, "Stepfather II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 892, new DateTime(1991, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11454, "706755690-2", 300, 58, "Where Sleeping Dogs Lie" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 893, new DateTime(2007, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5681, "141027282-6", 1656, 40, "Starsuckers" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 894, new DateTime(1984, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14185, "458439984-0", 965, 66, "Lucky 7" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 895, new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18651, "675115227-2", 2391, 80, "Broadway Melody of 1938" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 896, new DateTime(1912, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 40461, "768663143-5", 2157, 28, "Wheeler Dealers  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 897, new DateTime(2011, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4078, "303627553-3", 2356, 26, "Dr. Jekyll and Mr. Hyde" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 898, new DateTime(2010, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4695, "450968681-1", 1098, 57, "Attack of the Killer Tomatoes!" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 899, new DateTime(1962, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22067, "851439370-7", 1423, 91, "To Be Twenty" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 900, new DateTime(1924, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36086, "050661291-0", 1299, 14, "Roommate  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 901, new DateTime(1940, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 30185, "478361005-3", 2006, 47, "Introduction to Physics  An" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 902, new DateTime(1935, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31984, "976197264-X", 1725, 97, "Emma" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 903, new DateTime(1969, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19430, "300936313-3", 462, 56, "Little Engine That Could  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 904, new DateTime(1959, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23278, "789557880-4", 1039, 50, "Dead Snow (Død snø)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 905, new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3011, "941470393-4", 87, 82, "Sun  The (Solntse)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 906, new DateTime(1979, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16080, "147480375-X", 2152, 24, "Fighting Elegy (Kenka erejii)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 907, new DateTime(1962, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22128, "240985073-1", 2856, 44, "The Fox and the Hound 2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 908, new DateTime(1963, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21666, "535432291-X", 683, 48, "Square Dance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 909, new DateTime(1945, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28422, "161352760-8", 456, 82, "Meet Monica Velour" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 910, new DateTime(1928, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 34681, "022203224-3", 2816, 69, "The Kiss of Her Flesh" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 911, new DateTime(1979, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15977, "938708076-5", 157, 71, "Palm Beach Story  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 912, new DateTime(1992, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10989, "542322344-X", 1416, 52, "Unconscious (Inconscientes)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 913, new DateTime(1947, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 27585, "409722089-6", 520, 8, "Play" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 914, new DateTime(1939, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30699, "450989939-4", 719, 59, "Chronic Town" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 915, new DateTime(1980, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15462, "010882952-9", 424, 17, "Zero 2" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 916, new DateTime(1952, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25665, "287639150-3", 1897, 79, "Slumber Party '57" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 917, new DateTime(1949, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 26814, "009209371-X", 773, 20, "Doomwatch" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 918, new DateTime(1961, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 22653, "989335754-3", 1310, 1, "Holy Innocents  The (Santos inocentes  Los)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 919, new DateTime(1940, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30177, "715980435-X", 2309, 65, "Mystery Science Theater 3000: The Movie" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 920, new DateTime(1905, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 42776, "005056882-5", 2802, 71, "Goal! III" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 921, new DateTime(1917, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 38384, "085459833-2", 443, 23, "Prowler  The (a.k.a. Rosemary's Killer) (a.k.a. The Graduation)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 922, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1319, "714528702-1", 1876, 87, "Key of Life (Kagi-dorobô no mesoddo)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 923, new DateTime(1917, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 38630, "196041941-2", 1782, 15, "Cassandra Crossing  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 924, new DateTime(1952, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25897, "802208254-6", 1942, 2, "Officer Down" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 925, new DateTime(1998, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8820, "814016470-4", 2257, 36, "For the Birds" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 926, new DateTime(1996, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9720, "237355018-0", 2907, 51, "Seven Psychopaths" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 927, new DateTime(1928, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34631, "290497045-2", 2634, 75, "Cell Count" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 928, new DateTime(1918, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 38037, "512038485-4", 847, 26, "Secret Society" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 929, new DateTime(1994, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10605, "561686839-6", 1886, 67, "El Dorado" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 930, new DateTime(2009, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4967, "133525557-5", 1018, 46, "Satyricon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 931, new DateTime(2000, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8292, "472482204-X", 1267, 60, "Manufactured Landscapes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 932, new DateTime(1916, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 38920, "892920887-8", 2516, 51, "Bird of Paradise" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 933, new DateTime(1977, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16708, "973406583-1", 1827, 62, "Purge (Puhdistus)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 934, new DateTime(1987, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12927, "953259868-5", 2386, 83, "Screwed in Tallinn (Torsk på Tallinn - En liten film om ensamhet)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 935, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13902, "343775933-7", 1310, 98, "Romance of Astrea and Celadon  The (Les amours d'Astrée et de Céladon)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 936, new DateTime(1972, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18362, "958125763-2", 1601, 66, "Árido Movie" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 937, new DateTime(1984, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14010, "995104239-2", 2044, 68, "Road to Ruin  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 938, new DateTime(1938, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30998, "403994289-2", 2570, 44, "Deux mondes  Les" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 939, new DateTime(1939, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 30545, "782871683-4", 902, 77, "Lady and the Reaper  The (Dama y la muerte  La)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 940, new DateTime(1968, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20036, "584002753-7", 1382, 100, "Before and After" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 941, new DateTime(1924, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35919, "998916224-7", 739, 65, "Guinevere" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 942, new DateTime(1932, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 32910, "086310400-2", 2448, 35, "The Sweet Ride" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 943, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 577, "028714744-4", 2973, 7, "Tom Sawyer" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 944, new DateTime(1955, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 24537, "025495223-2", 510, 23, "At Long Last Love" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 945, new DateTime(2009, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5119, "488790915-2", 793, 98, "Dead & Buried" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 946, new DateTime(1933, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 32668, "249482621-7", 2450, 69, "CJ7 (Cheung Gong 7 hou)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 947, new DateTime(1959, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23245, "565274665-3", 1191, 79, "Gentlemen" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 948, new DateTime(1926, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35230, "096108959-8", 530, 43, "Days and Clouds (Giorni e nuvole)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 949, new DateTime(2016, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2434, "546794106-2", 1651, 15, "Whistle Blower  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 950, new DateTime(1924, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 35873, "696305737-0", 1386, 26, "Yellow Earth (Huang tu di)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 951, new DateTime(2007, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5708, "408897726-2", 2575, 25, "Brothers in Trouble" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 952, new DateTime(1956, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 24280, "439534159-4", 2443, 26, "Big Bad Mama II" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 953, new DateTime(1922, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 36738, "133851977-8", 2951, 23, "As I Lay Dying" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 954, new DateTime(2004, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6933, "216700367-6", 1531, 65, "Last Passenger" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 955, new DateTime(1905, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 42802, "108976740-4", 664, 15, "To End All Wars" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 956, new DateTime(1993, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10694, "226406457-9", 342, 13, "Diary of a Wimpy Kid" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 957, new DateTime(1988, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12587, "089838438-9", 1313, 96, "Death to Smoochy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 958, new DateTime(1992, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11345, "717747866-3", 1292, 1, "Incendies" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 959, new DateTime(1934, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 32332, "926107939-3", 2238, 84, "Bourne Legacy  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 960, new DateTime(1901, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 44378, "357006537-5", 2836, 91, "X-Men: The Last Stand" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 961, new DateTime(1999, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8596, "174230808-2", 1461, 21, "Bruce Almighty" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 962, new DateTime(1917, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 38706, "687092176-8", 2765, 77, "We Can Be Heroes" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 963, new DateTime(1972, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 18462, "447530661-2", 517, 15, "Mutant Action (Acción Mutante)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 964, new DateTime(1951, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26207, "548457461-7", 933, 5, "Second Jungle Book: Mowgli & Baloo  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 965, new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27900, "348915924-1", 1361, 8, "Black Dahlia  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 966, new DateTime(1900, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 44835, "335263413-0", 48, 61, "I Am Love (Io sono l'amore)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 967, new DateTime(1979, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16081, "156702515-3", 454, 51, "Silence  The (Sokout)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 968, new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8869, "687504260-6", 69, 71, "Rainmaker  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 969, new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1915, "490451041-0", 1945, 90, "Loaded" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 970, new DateTime(1991, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11526, "765750184-7", 219, 72, "Return to Never Land" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 971, new DateTime(2001, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7836, "441380418-X", 504, 20, "White Cliffs of Dover  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 972, new DateTime(1930, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 33667, "166097552-2", 812, 37, "Alphabet" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 973, new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16731, "059147640-1", 383, 40, "Restraint" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 974, new DateTime(2008, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5208, "039616594-X", 1180, 72, "Killing Room  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 975, new DateTime(2005, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6501, "185173573-9", 2680, 89, "Bridesmaids" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 976, new DateTime(1945, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28255, "756902919-4", 2356, 23, "Jude the Obscure" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 977, new DateTime(1955, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24850, "168729839-4", 1755, 30, "Fist of Fury (Chinese Connection  The) (Jing wu men)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 978, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1271, "648746054-0", 2204, 67, "City Streets" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 979, new DateTime(2002, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7536, "562485317-3", 482, 58, "96 Minutes " });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 980, new DateTime(1944, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28523, "357974304-X", 2978, 17, "Snake and Crane Arts of Shaolin (She hao ba bu)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 981, new DateTime(2005, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6343, "236009939-6", 1055, 22, "Court-Martial of Billy Mitchell  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 982, new DateTime(1940, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 30245, "605352876-5", 2847, 8, "Ladies of Leisure" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 983, new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12261, "259142236-2", 143, 12, "Achilles and the Tortoise (Akiresu to kame)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 984, new DateTime(1978, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16246, "418249464-4", 2196, 11, "So Long Letty" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 985, new DateTime(1993, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10955, "138526758-5", 561, 87, "Wallace & Gromit: The Wrong Trousers" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 986, new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12159, "859104102-X", 1979, 90, "Unknown Soldier  The (Tuntematon sotilas)" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 987, new DateTime(1925, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35470, "547634117-X", 242, 46, "War Dance" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 988, new DateTime(1992, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11225, "065596266-2", 707, 60, "Confiance règne  La" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 989, new DateTime(1931, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33390, "290248563-8", 2451, 17, "Judith of Bethulia" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 990, new DateTime(1908, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 41848, "245455986-2", 1881, 70, "London River" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 991, new DateTime(1906, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 42666, "032978469-2", 1435, 61, "Maniacts" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 992, new DateTime(1949, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 26702, "101034915-5", 1701, 16, "Reunion" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 993, new DateTime(1992, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11162, "742102540-5", 1231, 46, "GhostWatcher" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 994, new DateTime(2004, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6929, "591160897-9", 2617, 20, "Contact High" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 995, new DateTime(1958, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 23697, "123406370-0", 2555, 38, "The Invisible Boy" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 996, new DateTime(1914, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 39494, "555868880-7", 1685, 68, "Romance in Manhattan" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 997, new DateTime(1909, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41530, "061812071-8", 889, 71, "Best Years of Our Lives  The" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 998, new DateTime(1908, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 41929, "642032305-3", 1458, 93, "Out On A Limb" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 999, new DateTime(1990, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12068, "640609726-2", 99, 41, "Forever  Darling" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "DatePublished", "DaysOld", "Isbn", "NumPages", "PublisherId", "Title" },
                values: new object[] { 1000, new DateTime(1996, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9595, "484628907-9", 1277, 74, "Kaspar Hauser" });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1, 15, 660, 8647.263f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3, 42, 316, 42003.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 5, 91, 536, 46467.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 7, 47, 338, 56783.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 9, 65, 434, 32417.988f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 11, 40, 799, 35044.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 13, 90, 624, 35479.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 15, 33, 14, 80775.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 17, 28, 694, 64690.613f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 19, 94, 715, 68147.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 21, 42, 801, 26741.111f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 23, 57, 836, 53183.355f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 25, 23, 871, 29424.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 27, 36, 676, 69586.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 29, 96, 834, 76440.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 31, 68, 681, 59544.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 33, 38, 431, 34451.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 35, 93, 813, 64691.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 37, 50, 895, 5632.9106f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 39, 26, 842, 75359.73f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 41, 72, 91, 62056.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 43, 12, 478, 17726.756f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 45, 10, 624, 22414.186f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 47, 76, 589, 3846.8196f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 49, 37, 773, 68120.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 51, 49, 880, 54929.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 53, 83, 786, 43253.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 55, 83, 382, 53395.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 57, 54, 555, 11558.333f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 59, 19, 43, 27610.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 61, 63, 508, 25336.209f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 63, 51, 862, 60152.137f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 65, 14, 324, 39620.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 67, 4, 827, 8879.798f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 69, 21, 964, 20616.412f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 71, 21, 35, 64823.797f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 73, 17, 850, 41316.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 75, 91, 210, 78747.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 77, 33, 97, 46835.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 79, 40, 763, 74998.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 81, 2, 75, 42360.324f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 83, 92, 971, 36704.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 85, 9, 53, 31550.438f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 87, 70, 181, 32942.66f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 89, 71, 334, 50721.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 91, 62, 642, 17203.428f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 93, 51, 194, 6692.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 95, 93, 980, 62027.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 97, 6, 166, 48584.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 99, 62, 77, 25093.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 101, 40, 262, 7598.843f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 103, 21, 54, 35881.797f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 105, 83, 523, 50623.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 107, 46, 907, 38576.676f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 109, 39, 358, 89388.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 111, 99, 25, 65591.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 113, 33, 598, 55836.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 115, 6, 555, 16828.768f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 117, 97, 417, 52647.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 119, 80, 233, 79683.51f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 121, 37, 504, 43033.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 123, 52, 508, 11388.069f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 125, 9, 513, 44103.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 127, 40, 413, 28577.525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 129, 20, 862, 86192.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 131, 41, 858, 41000.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 133, 25, 845, 54992.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 135, 70, 622, 70041.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 137, 95, 528, 281.58923f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 139, 71, 678, 33023.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 141, 75, 713, 27728.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 143, 68, 879, 46312.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 145, 85, 562, 46908.395f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 147, 86, 517, 50857.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 149, 63, 314, 8127.3296f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 151, 66, 645, 31049.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 153, 83, 789, 7420.0547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 155, 9, 602, 34.68053f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 157, 38, 19, 7472.3237f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 159, 41, 661, 89770.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 161, 52, 629, 12646.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 163, 30, 661, 70968.08f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 165, 66, 740, 69536.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 167, 55, 763, 59028.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 169, 77, 125, 11590.396f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 171, 48, 357, 71517.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 173, 63, 494, 51980.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 175, 7, 34, 40838.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 177, 5, 643, 41541.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 179, 81, 200, 46012.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 181, 40, 594, 2731.6223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 183, 18, 315, 31681.773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 185, 19, 591, 33804.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 187, 76, 683, 29590.828f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 189, 3, 870, 3233.498f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 191, 46, 878, 31102.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 193, 87, 705, 26225.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 195, 43, 849, 79772.375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 197, 25, 85, 18765.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 199, 16, 393, 28256.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 201, 22, 773, 19643.582f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 203, 12, 378, 52339.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 205, 94, 485, 11423.739f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 207, 94, 989, 18097.764f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 209, 81, 455, 10530.565f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 211, 74, 731, 46126.645f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 213, 92, 256, 6288.5366f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 215, 18, 76, 30282.436f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 217, 98, 586, 38101.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 219, 1, 462, 5945.7837f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 221, 62, 357, 22654.209f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 223, 61, 486, 34850.176f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 225, 72, 485, 13183.179f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 227, 47, 751, 30796.287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 229, 29, 786, 55339.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 231, 57, 90, 53222.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 233, 2, 647, 38875.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 235, 49, 338, 76636.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 237, 17, 167, 51968.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 239, 36, 536, 34083.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 241, 10, 151, 31649.822f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 243, 97, 420, 66839.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 245, 34, 470, 53335.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 247, 25, 10, 74204.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 249, 9, 648, 68157.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 251, 62, 281, 12616.847f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 253, 67, 608, 28910.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 255, 39, 299, 23860.062f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 257, 23, 449, 70477.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 259, 63, 990, 22988.389f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 261, 28, 665, 85952.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 263, 52, 647, 75203.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 265, 97, 867, 3797.1514f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 267, 65, 32, 20334.656f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 269, 97, 450, 31345.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 271, 59, 874, 82911.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 273, 24, 646, 83595.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 275, 61, 336, 25261.871f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 277, 23, 653, 8007.9844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 279, 11, 744, 16723.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 281, 76, 437, 35884.523f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 283, 67, 509, 23015.521f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 285, 14, 358, 74928.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 287, 95, 64, 56036.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 289, 66, 229, 61772.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 291, 77, 814, 43494.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 293, 86, 970, 45815.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 295, 81, 936, 54000.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 297, 26, 671, 78838.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 299, 87, 320, 8686.378f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 301, 24, 799, 2734.8652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 303, 27, 154, 17807.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 305, 82, 190, 54591.344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 307, 8, 350, 60952.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 309, 1, 749, 37915.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 311, 55, 993, 25845.166f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 313, 59, 587, 80028.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 315, 19, 395, 84755.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 317, 22, 210, 43529.613f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 319, 98, 17, 19532.568f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 321, 89, 906, 24383.836f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 323, 13, 22, 76360f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 325, 46, 372, 49316.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 327, 77, 499, 77964.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 329, 71, 449, 75919.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 331, 34, 108, 49449.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 333, 1, 903, 56974.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 335, 54, 436, 32574.475f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 337, 96, 370, 5795.462f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 339, 66, 620, 56332.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 341, 42, 311, 73686.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 343, 33, 231, 64969.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 345, 37, 410, 84248.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 347, 47, 161, 64418.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 349, 74, 623, 7428.6724f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 351, 64, 651, 12977.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 353, 60, 140, 85458.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 355, 40, 768, 60584.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 357, 20, 500, 42694.727f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 359, 57, 663, 60031.062f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 361, 55, 580, 6720.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 363, 80, 935, 50082.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 365, 21, 167, 88239.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 367, 46, 698, 11138.806f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 369, 68, 589, 30500.139f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 371, 71, 787, 45806.297f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 373, 31, 653, 2181.287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 375, 9, 73, 62649.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 377, 50, 508, 82733.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 379, 14, 689, 29186.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 381, 44, 967, 9699.201f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 383, 24, 458, 13352.992f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 385, 73, 650, 51125.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 387, 7, 37, 45455.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 389, 3, 783, 42657.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 391, 20, 841, 12509.662f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 393, 85, 257, 27969.57f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 395, 96, 636, 66412.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 397, 87, 281, 55364.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 399, 55, 770, 8023.6807f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 401, 16, 448, 27438.283f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 403, 57, 100, 47250.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 405, 6, 116, 36184.965f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 407, 18, 402, 14739.487f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 409, 39, 865, 35563.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 411, 37, 525, 75399.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 413, 88, 645, 23436.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 415, 72, 836, 71003.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 417, 61, 249, 60856.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 419, 90, 861, 22095.777f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 421, 22, 230, 8353.428f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 423, 16, 238, 38527.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 425, 95, 688, 38334.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 427, 20, 736, 1688.1235f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 429, 49, 917, 22319.027f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 431, 78, 326, 18883.438f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 433, 66, 473, 8222.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 435, 3, 78, 72287.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 437, 38, 675, 9747.673f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 439, 13, 131, 75950.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 441, 10, 295, 69893.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 443, 44, 159, 42011.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 445, 39, 497, 7800.6753f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 447, 27, 653, 46505.094f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 449, 13, 365, 73954.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 451, 16, 710, 2232.7834f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 453, 52, 658, 7555.5054f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 455, 51, 871, 62926.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 457, 37, 389, 75165.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 459, 81, 549, 11562.827f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 461, 35, 871, 9679.709f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 463, 68, 44, 43738.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 465, 19, 23, 63636.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 467, 1, 86, 74848.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 469, 40, 348, 25357.283f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 471, 41, 316, 5277.323f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 473, 67, 30, 21656.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 475, 19, 399, 63688.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 477, 56, 307, 46940.254f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 479, 15, 167, 6145.115f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 481, 39, 418, 73781.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 483, 64, 738, 42875.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 485, 62, 169, 26709.904f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 487, 72, 205, 74070.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 489, 78, 171, 25819.072f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 491, 97, 659, 62225.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 493, 12, 767, 20571.041f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 495, 46, 363, 12252.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 497, 16, 947, 34814.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 499, 13, 33, 89104.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 501, 37, 531, 57407.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 503, 30, 62, 67202.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 505, 31, 385, 24761.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 507, 79, 916, 3264.8901f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 509, 93, 513, 44128.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 511, 46, 965, 24459.908f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 513, 42, 587, 25116.395f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 515, 18, 993, 74004.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 517, 89, 726, 46138.957f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 519, 94, 8, 18873.059f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 521, 47, 323, 28645.639f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 523, 84, 253, 39792.254f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 525, 69, 472, 83410.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 527, 62, 891, 70124.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 529, 18, 62, 54360.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 531, 95, 939, 40210.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 533, 92, 87, 26168.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 535, 28, 598, 38230.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 537, 3, 79, 46391.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 539, 39, 845, 42857.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 541, 7, 998, 1266.8177f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 543, 80, 917, 83868.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 545, 59, 493, 78437.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 547, 22, 726, 23535.879f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 549, 49, 952, 32259.434f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 551, 80, 30, 24556.637f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 553, 7, 265, 4676.075f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 555, 18, 348, 84438.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 557, 1, 421, 68947.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 559, 17, 682, 66110.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 561, 50, 343, 12328.794f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 563, 4, 710, 3984.624f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 565, 3, 821, 34162.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 567, 18, 430, 64500.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 569, 28, 167, 13842.279f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 571, 42, 728, 58396.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 573, 38, 718, 80400.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 575, 3, 872, 88741.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 577, 1, 990, 48406.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 579, 63, 27, 38258.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 581, 74, 906, 46735.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 583, 22, 799, 71717.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 585, 1, 931, 20277.768f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 587, 68, 650, 35651.312f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 589, 39, 273, 39.645832f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 591, 3, 358, 37691.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 593, 27, 325, 35287.348f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 595, 23, 853, 22437.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 597, 86, 208, 38793.043f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 599, 24, 697, 33244.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 601, 34, 184, 88679.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 603, 32, 680, 6227.714f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 605, 26, 537, 87717.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 607, 61, 622, 34844.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 609, 52, 469, 78652.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 611, 22, 978, 24027.268f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 613, 47, 421, 82090.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 615, 90, 763, 57546.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 617, 59, 158, 16761.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 619, 67, 457, 45437.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 621, 5, 745, 10797.322f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 623, 72, 249, 9618.794f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 625, 30, 862, 71020.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 627, 82, 245, 17522.752f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 629, 7, 878, 36128.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 631, 60, 466, 36323.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 633, 23, 6, 17124.773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 635, 19, 775, 73399.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 637, 47, 770, 33320.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 639, 21, 439, 48470.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 641, 1, 270, 60202.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 643, 5, 981, 64243.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 645, 70, 495, 46114.297f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 647, 63, 781, 54934.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 649, 33, 734, 30588.236f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 651, 58, 82, 78778.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 653, 9, 610, 41861f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 655, 42, 418, 76479.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 657, 57, 676, 55970.926f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 659, 41, 847, 9832.636f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 661, 22, 906, 87325.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 663, 38, 94, 25306.705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 665, 45, 430, 58024.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 667, 75, 393, 7769.075f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 669, 95, 17, 64812.223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 671, 81, 450, 25688.467f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 673, 83, 696, 51069.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 675, 40, 255, 6537.063f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 677, 54, 128, 65670.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 679, 31, 562, 76471.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 681, 11, 180, 49577.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 683, 13, 81, 88113.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 685, 70, 290, 56183.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 687, 64, 344, 81821.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 689, 43, 924, 73108.08f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 691, 91, 33, 58413.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 693, 50, 625, 20325f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 695, 22, 122, 15686.536f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 697, 16, 252, 77415.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 699, 70, 875, 76558.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 701, 13, 535, 46016.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 703, 74, 126, 33652.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 705, 47, 175, 56433.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 707, 40, 97, 39134.594f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 709, 34, 258, 10516.659f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 711, 76, 629, 17435.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 713, 31, 712, 40963.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 715, 8, 581, 75142.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 717, 68, 963, 24705.252f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 719, 50, 167, 19137.041f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 721, 4, 504, 3874.0684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 723, 43, 315, 71144.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 725, 40, 277, 81396.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 727, 6, 566, 2282.6323f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 729, 12, 288, 28311.447f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 731, 89, 287, 86172.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 733, 50, 186, 70313.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 735, 4, 344, 66044.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 737, 38, 340, 66418.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 739, 75, 578, 59656.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 741, 47, 663, 53972.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 743, 98, 678, 79814.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 745, 33, 864, 74196.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 747, 83, 573, 88258.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 749, 9, 401, 23954.137f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 751, 43, 996, 2314.8135f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 753, 22, 735, 75737.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 755, 12, 155, 39942.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 757, 15, 752, 42344.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 759, 9, 592, 17061.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 761, 12, 615, 52431.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 763, 76, 970, 36180.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 765, 49, 818, 26139.455f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 767, 14, 727, 50674.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 769, 61, 117, 68783.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 771, 59, 588, 78947.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 773, 50, 939, 10859.886f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 775, 71, 987, 47188.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 777, 88, 122, 75895.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 779, 64, 421, 72453.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 781, 6, 507, 55264.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 783, 95, 868, 62694.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 785, 59, 983, 19228.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 787, 59, 457, 7865.087f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 789, 26, 170, 66592.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 791, 11, 19, 43315.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 793, 34, 763, 86716.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 795, 30, 835, 7880.4663f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 797, 8, 287, 52222.582f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 799, 90, 689, 514.9511f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 801, 93, 110, 26702.535f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 803, 30, 904, 56616.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 805, 69, 934, 46851.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 807, 77, 286, 30040.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 809, 60, 233, 56958.004f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 811, 7, 123, 47872.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 813, 20, 338, 21592.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 815, 43, 90, 22876.982f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 817, 21, 30, 73338.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 819, 40, 189, 19500.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 821, 59, 284, 18035.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 823, 4, 526, 19326.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 825, 18, 805, 53070.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 827, 28, 267, 39254.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 829, 54, 366, 37751.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 831, 49, 210, 72877.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 833, 11, 297, 19506.459f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 835, 30, 689, 2114.8323f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 837, 70, 559, 45114.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 839, 78, 282, 50119.754f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 841, 44, 667, 45397.73f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 843, 33, 546, 60797.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 845, 10, 870, 18027.605f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 847, 68, 699, 88339.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 849, 67, 1, 7141.0557f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 851, 30, 945, 29157.617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 853, 16, 97, 89805.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 855, 15, 176, 4986.5337f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 857, 64, 996, 65354.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 859, 83, 496, 14164.891f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 861, 44, 284, 4120.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 863, 57, 58, 65474.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 865, 3, 838, 78461.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 867, 85, 269, 23431.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 869, 2, 812, 12466.575f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 871, 92, 978, 58899.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 873, 85, 439, 29504.744f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 875, 5, 465, 28975.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 877, 28, 604, 19412.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 879, 5, 733, 49238.508f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 881, 30, 930, 68685.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 883, 6, 71, 2354.005f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 885, 40, 175, 37556.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 887, 20, 795, 19432.299f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 889, 98, 163, 8414.588f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 891, 83, 988, 10284.861f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 893, 62, 771, 39344.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 895, 86, 469, 21740.564f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 897, 75, 89, 77778f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 899, 65, 742, 4842.253f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 901, 9, 434, 68276.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 903, 28, 737, 88593.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 905, 80, 832, 66706.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 907, 45, 503, 42803.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 909, 90, 546, 29132.463f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 911, 43, 215, 27001.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 913, 30, 726, 77094.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 915, 73, 33, 30776.062f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 917, 76, 35, 84591.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 919, 46, 639, 20557.781f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 921, 58, 726, 31325.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 923, 29, 418, 5230.439f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 925, 65, 411, 59084.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 927, 79, 386, 40533.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 929, 87, 78, 44270.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 931, 19, 68, 77611.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 933, 21, 993, 89562.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 935, 4, 277, 20200.973f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 937, 39, 43, 51404.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 939, 42, 660, 34008.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 941, 27, 508, 10766.1455f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 943, 4, 817, 67429.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 945, 33, 530, 82226.836f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 947, 67, 954, 9718.1455f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 949, 23, 528, 70448.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 951, 74, 400, 39604.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 953, 20, 716, 3237.1924f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 955, 83, 168, 67757.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 957, 8, 825, 13532.471f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 959, 95, 628, 60179.51f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 961, 78, 631, 59168.254f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 963, 5, 22, 85130.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 965, 41, 430, 26884.191f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 967, 70, 887, 63545.08f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 969, 13, 452, 30625.904f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 971, 73, 841, 61046.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 973, 9, 278, 47283.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 975, 9, 661, 75929.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 977, 85, 176, 38389.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 979, 24, 5, 6617.9863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 981, 41, 222, 21739.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 983, 20, 339, 74972.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 985, 4, 239, 84569.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 987, 94, 414, 19903.068f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 989, 68, 650, 86048.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 991, 99, 792, 68872.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 993, 40, 684, 52269.324f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 995, 68, 505, 74997.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 997, 84, 346, 86773.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 999, 85, 132, 33671.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1001, 42, 894, 19986.137f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1003, 3, 126, 63590.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1005, 37, 772, 60635.957f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1007, 49, 342, 43316.73f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1009, 13, 622, 3164.6602f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1011, 47, 797, 51908.348f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1013, 4, 442, 72133.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1015, 6, 631, 2806.5942f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1017, 28, 908, 85046.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1019, 2, 670, 30393.512f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1021, 51, 235, 89737.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1023, 21, 625, 83597.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1025, 2, 286, 36465.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1027, 55, 830, 78299.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1029, 7, 666, 83242.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1031, 24, 541, 44598.383f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1033, 38, 766, 67781.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1035, 15, 393, 62701.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1037, 66, 738, 42022.688f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1039, 63, 12, 5651.525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1041, 85, 920, 2155.154f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1043, 14, 344, 39667.383f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1045, 30, 712, 64045.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1047, 37, 643, 37912.207f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1049, 30, 934, 54988.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1051, 41, 122, 6949.6533f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1053, 83, 358, 26262.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1055, 92, 121, 27760.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1057, 69, 859, 9532.246f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1059, 93, 63, 36262.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1061, 5, 540, 7741.623f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1063, 6, 706, 37273.754f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1065, 82, 977, 76423.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1067, 7, 332, 57998.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1069, 88, 343, 19863.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1071, 32, 613, 60392.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1073, 41, 803, 29514.986f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1075, 29, 370, 16353.518f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1077, 36, 919, 86171.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1079, 89, 650, 42549.773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1081, 89, 745, 58648.523f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1083, 71, 982, 67651.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1085, 87, 60, 34541.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1087, 67, 464, 43598.832f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1089, 97, 509, 85962.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1091, 2, 737, 13785.335f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1093, 15, 877, 18206.277f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1095, 27, 503, 21903.635f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1097, 70, 468, 21504.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1099, 18, 204, 5190.6016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1101, 38, 358, 54852.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1103, 45, 650, 17278.678f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1105, 57, 539, 23635.66f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1107, 24, 470, 54327.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1109, 74, 405, 24749.377f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1111, 74, 150, 40773.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1113, 28, 90, 22560.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1115, 52, 405, 55781.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1117, 51, 776, 64077.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1119, 53, 572, 36927.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1121, 95, 502, 47970.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1123, 5, 883, 46444.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1125, 48, 746, 55521.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1127, 97, 65, 77795.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1129, 60, 137, 40397.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1131, 92, 740, 52654.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1133, 77, 573, 21677.596f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1135, 22, 838, 29341.666f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1137, 62, 293, 66094.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1139, 78, 740, 14904.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1141, 25, 394, 5685.4233f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1143, 36, 910, 22898.775f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1145, 11, 56, 84128.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1147, 91, 73, 66568.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1149, 57, 4, 31764.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1151, 58, 114, 15034.167f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1153, 49, 278, 81268.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1155, 36, 23, 13527.087f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1157, 79, 878, 52763.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1159, 94, 672, 54095.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1161, 16, 275, 13870.155f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1163, 30, 958, 42712.316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1165, 54, 243, 55377.344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1167, 21, 12, 77150.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1169, 5, 32, 4824.9937f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1171, 56, 885, 43086.312f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1173, 82, 964, 50595.773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1175, 62, 752, 24326.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1177, 41, 647, 60346.387f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1179, 28, 385, 65689.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1181, 52, 776, 14857.962f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1183, 37, 222, 40425.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1185, 49, 694, 59178.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1187, 50, 952, 1178.6604f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1189, 12, 395, 17835.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1191, 16, 873, 80748.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1193, 63, 388, 49496.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1195, 30, 283, 65191.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1197, 51, 144, 89003.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1199, 59, 563, 28013.834f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1201, 26, 79, 57986.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1203, 53, 754, 23461.352f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1205, 63, 795, 57264.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1207, 86, 538, 62046.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1209, 44, 169, 81456.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1211, 30, 330, 56274.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1213, 48, 411, 26260.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1215, 66, 28, 2407.3938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1217, 99, 972, 22265.193f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1219, 53, 953, 24072.178f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1221, 50, 368, 61521.79f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1223, 6, 482, 51584.473f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1225, 97, 886, 52403.434f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1227, 11, 39, 54958.613f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1229, 19, 965, 83240.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1231, 64, 491, 31724.201f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1233, 38, 259, 41981.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1235, 56, 236, 26742.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1237, 80, 679, 81048.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1239, 85, 349, 30598.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1241, 91, 79, 49088.105f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1243, 1, 585, 10768.298f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1245, 78, 148, 49502.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1247, 89, 769, 13297.966f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1249, 72, 570, 79225.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1251, 80, 550, 8582.858f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1253, 47, 821, 5230.793f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1255, 60, 468, 73362.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1257, 5, 680, 33584.562f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1259, 45, 639, 63997.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1261, 52, 264, 40391.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1263, 76, 740, 70730.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1265, 94, 998, 16715.717f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1267, 34, 993, 62963.758f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1269, 37, 795, 47165.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1271, 32, 191, 21710.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1273, 89, 82, 64904.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1275, 8, 981, 36436.344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1277, 45, 295, 2923.9817f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1279, 9, 905, 54313.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1281, 11, 193, 27079.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1283, 99, 448, 49141.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1285, 51, 998, 73675.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1287, 95, 608, 10321.418f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1289, 83, 479, 37510.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1291, 65, 909, 4940.931f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1293, 43, 59, 7208.5464f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1295, 84, 978, 15562.356f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1297, 1, 497, 63725.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1299, 55, 846, 9175.711f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1301, 96, 911, 25858.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1303, 47, 642, 22005.705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1305, 3, 460, 28689.996f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1307, 47, 963, 26042.994f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1309, 12, 458, 89061.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1311, 83, 538, 86791.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1313, 38, 477, 72663.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1315, 47, 298, 9369.866f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1317, 43, 559, 66363.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1319, 15, 38, 41277.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1321, 86, 593, 68133.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1323, 92, 631, 3827.6062f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1325, 79, 811, 3986.5632f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1327, 41, 237, 22086.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1329, 28, 884, 28780.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1331, 91, 919, 24954.129f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1333, 84, 826, 55213.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1335, 33, 856, 18571.064f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1337, 14, 333, 86566.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1339, 4, 862, 13339.779f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1341, 3, 837, 34565.812f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1343, 83, 934, 3932.5344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1345, 31, 573, 32158.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1347, 44, 321, 59913.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1349, 6, 105, 14455.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1351, 92, 566, 28280.074f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1353, 5, 756, 6947.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1355, 51, 258, 31486.457f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1357, 14, 637, 23069.693f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1359, 43, 966, 82664.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1361, 79, 515, 79298.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1363, 1, 242, 7178.4707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1365, 77, 949, 48186.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1367, 40, 398, 30317.518f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1369, 84, 905, 15865.7705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1371, 30, 968, 74330.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1373, 52, 459, 79692.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1375, 51, 381, 1226.5084f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1377, 39, 726, 36118.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1379, 96, 902, 63803.227f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1381, 73, 65, 82830.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1383, 42, 776, 56719.473f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1385, 38, 936, 41428.383f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1387, 18, 639, 37192.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1389, 37, 436, 47357.355f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1391, 44, 323, 40556.918f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1393, 22, 936, 16554.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1395, 73, 421, 35916.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1397, 60, 485, 79774.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1399, 77, 306, 88001.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1401, 37, 626, 89214.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1403, 31, 360, 64003.223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1405, 33, 540, 14556.158f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1407, 46, 819, 1560.138f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1409, 75, 340, 33923.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1411, 60, 202, 87410.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1413, 87, 105, 26648.738f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1415, 27, 537, 73769.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1417, 97, 651, 82563.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1419, 62, 283, 44666.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1421, 89, 861, 46800.105f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1423, 89, 634, 24997.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1425, 30, 589, 55440.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1427, 52, 458, 35535.676f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1429, 63, 438, 30341.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1431, 94, 614, 8485.908f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1433, 29, 890, 84667.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1435, 80, 262, 65508.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1437, 48, 750, 60326.027f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1439, 15, 244, 72091.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1441, 96, 78, 6581.6353f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1443, 14, 503, 46964.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1445, 29, 776, 89631.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1447, 95, 208, 69849.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1449, 47, 709, 8823.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1451, 66, 696, 19043.762f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1453, 81, 390, 21879.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1455, 48, 401, 24681.184f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1457, 74, 179, 47813.285f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1459, 77, 855, 22626.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1461, 80, 63, 81089.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1463, 28, 100, 57648.883f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1465, 17, 184, 69491.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1467, 47, 740, 76681.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1469, 13, 148, 33635.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1471, 45, 303, 55979.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1473, 8, 668, 45983.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1475, 81, 767, 34506.676f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1477, 36, 62, 84601.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1479, 53, 371, 4648.7603f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1481, 77, 237, 60258.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1483, 28, 650, 8046.315f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1485, 72, 794, 25703.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1487, 72, 721, 64299.316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1489, 6, 987, 50676.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1491, 51, 126, 32619.814f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1493, 78, 249, 23379.143f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1495, 41, 831, 52519.188f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1497, 4, 726, 26952.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1499, 73, 440, 18309.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1501, 25, 927, 15668.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1503, 81, 766, 54758.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1505, 41, 351, 71535.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1507, 55, 265, 86492.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1509, 33, 283, 11881.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1511, 93, 928, 6625.411f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1513, 44, 500, 32607.736f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1515, 77, 107, 70914.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1517, 21, 962, 19099.248f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1519, 98, 108, 31336.975f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1521, 90, 651, 25479.373f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1523, 48, 400, 55941.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1525, 86, 73, 28255.248f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1527, 29, 555, 46653.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1529, 38, 561, 15490.109f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1531, 59, 218, 52181.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1533, 44, 169, 64672.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1535, 27, 628, 81739.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1537, 21, 765, 43428.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1539, 37, 430, 49927.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1541, 52, 423, 20730.836f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1543, 55, 396, 75734.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1545, 92, 286, 21601.535f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1547, 87, 609, 32823.246f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1549, 45, 305, 21345.094f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1551, 11, 268, 59766.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1553, 44, 393, 60798.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1555, 23, 870, 33210.387f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1557, 13, 861, 28755.018f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1559, 44, 512, 67703.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1561, 47, 273, 37579.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1563, 61, 984, 58847.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1565, 61, 443, 10221.418f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1567, 39, 468, 68549.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1569, 87, 296, 86969.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1571, 74, 397, 65095.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1573, 37, 463, 74616.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1575, 26, 30, 9880.917f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1577, 41, 399, 58834.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1579, 71, 502, 8160.6216f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1581, 55, 268, 16486.637f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1583, 88, 71, 84497.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1585, 46, 659, 15875.405f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1587, 32, 649, 43219.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1589, 91, 690, 19747.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1591, 43, 764, 50405.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1593, 89, 225, 46971.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1595, 94, 46, 25599.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1597, 94, 816, 49703.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1599, 26, 952, 6890.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1601, 77, 245, 5103.366f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1603, 78, 421, 72296.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1605, 83, 479, 30312.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1607, 62, 769, 41543.527f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1609, 56, 257, 47599.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1611, 53, 22, 74365.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1613, 41, 854, 73942.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1615, 97, 344, 8322.807f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1617, 65, 461, 5842.2456f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1619, 55, 70, 67052.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1621, 74, 13, 16714.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1623, 27, 785, 25829.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1625, 10, 390, 81447.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1627, 79, 280, 66768.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1629, 88, 723, 56688.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1631, 14, 960, 9072.888f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1633, 20, 133, 28122.297f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1635, 25, 959, 23865.166f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1637, 83, 957, 10485.397f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1639, 90, 34, 43327.773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1641, 38, 518, 60355.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1643, 18, 264, 58826.617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1645, 98, 319, 17378.857f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1647, 77, 404, 85297.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1649, 92, 871, 7695.138f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1651, 13, 135, 57065.57f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1653, 68, 654, 49077.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1655, 45, 75, 63641.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1657, 89, 304, 43050.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1659, 73, 750, 42425.027f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1661, 93, 308, 7439.529f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1663, 91, 887, 14777.706f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1665, 74, 361, 67365.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1667, 67, 931, 68957.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1669, 20, 2, 18540.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1671, 15, 891, 57099.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1673, 70, 187, 47259.598f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1675, 31, 508, 56145.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1677, 24, 933, 49077.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1679, 6, 607, 44825.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1681, 23, 806, 43373.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1683, 29, 485, 5099.503f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1685, 65, 49, 65726.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1687, 73, 801, 58844.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1689, 37, 572, 58865.645f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1691, 6, 788, 260.79617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1693, 71, 343, 37737.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1695, 1, 879, 43646.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1697, 34, 155, 85929.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1699, 6, 94, 17385.617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1701, 97, 710, 28.782457f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1703, 95, 252, 65967.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1705, 78, 754, 49518f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1707, 79, 18, 52741.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1709, 75, 696, 58190.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1711, 78, 957, 24219.287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1713, 76, 877, 45675.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1715, 65, 987, 40893.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1717, 1, 462, 50720.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1719, 13, 865, 65954.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1721, 78, 786, 19290.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1723, 43, 80, 18431.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1725, 52, 649, 40072.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1727, 28, 244, 77612.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1729, 82, 585, 72309.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1731, 30, 831, 70225.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1733, 90, 853, 38453.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1735, 39, 595, 25578.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1737, 68, 51, 64292.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1739, 61, 896, 48538.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1741, 58, 709, 965.9079f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1743, 1, 232, 53049.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1745, 61, 93, 42784.617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1747, 42, 571, 76404.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1749, 18, 536, 48698.812f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1751, 23, 625, 72021.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1753, 34, 152, 69064.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1755, 84, 383, 50694.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1757, 4, 352, 19287.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1759, 18, 332, 63480.996f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1761, 12, 124, 37729.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1763, 6, 543, 52672.715f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1765, 30, 214, 49496.355f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1767, 99, 838, 41845.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1769, 73, 869, 67210.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1771, 66, 918, 24122.986f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1773, 87, 635, 81204.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1775, 3, 512, 72395.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1777, 69, 52, 88424.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1779, 89, 521, 60964.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1781, 33, 490, 1038.0204f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1783, 61, 839, 41720.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1785, 66, 157, 78475.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1787, 63, 424, 36824.957f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1789, 3, 58, 33694.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1791, 86, 227, 56850.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1793, 87, 545, 48724.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1795, 9, 647, 84331.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1797, 24, 237, 15711.528f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1799, 91, 830, 16262.903f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1801, 4, 964, 50254.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1803, 44, 192, 85426.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1805, 45, 694, 10537.495f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1807, 46, 684, 49070.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1809, 36, 691, 3300.7751f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1811, 77, 877, 42299.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1813, 8, 493, 3174.1086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1815, 32, 48, 63249.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1817, 50, 511, 87401.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1819, 95, 729, 25451.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1821, 94, 339, 75391.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1823, 6, 400, 35692.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1825, 94, 148, 75495.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1827, 61, 773, 72627.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1829, 85, 175, 68227.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1831, 14, 672, 32907.777f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1833, 99, 976, 46946.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1835, 83, 66, 87768.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1837, 59, 894, 86285.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1839, 23, 671, 60794.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1841, 52, 344, 39184.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1843, 36, 11, 31561.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1845, 91, 635, 27082.643f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1847, 56, 446, 24898.957f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1849, 43, 324, 86780.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1851, 24, 880, 66764.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1853, 9, 458, 72113.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1855, 42, 357, 19598.791f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1857, 5, 328, 89.89674f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1859, 83, 813, 72840.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1861, 38, 271, 19357.191f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1863, 86, 609, 40277.637f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1865, 77, 975, 52597.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1867, 96, 659, 23901.674f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1869, 44, 185, 18962.719f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1871, 23, 647, 48117.78f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1873, 63, 481, 81174.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1875, 51, 525, 60107.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1877, 26, 896, 24914.998f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1879, 32, 500, 8111.3794f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1881, 16, 764, 34481.223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1883, 9, 445, 43318.312f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1885, 47, 599, 33953.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1887, 65, 777, 45650.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1889, 17, 229, 50978.523f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1891, 68, 529, 11401.881f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1893, 69, 312, 69989.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1895, 43, 985, 15902.399f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1897, 64, 467, 28467.527f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1899, 90, 153, 61239.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1901, 92, 141, 73504.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1903, 98, 505, 48961.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1905, 27, 389, 88607.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1907, 27, 247, 79998.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1909, 77, 506, 6690.3647f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1911, 74, 458, 47756.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1913, 31, 337, 17640.314f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1915, 93, 421, 56035.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1917, 4, 698, 51182.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1919, 48, 986, 79231.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1921, 29, 841, 44832.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1923, 74, 565, 6504.019f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1925, 20, 614, 42444.832f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1927, 19, 670, 3109.499f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1929, 46, 735, 23790.201f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1931, 14, 528, 2309.183f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1933, 53, 776, 83751.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1935, 20, 594, 46188.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1937, 40, 83, 6527.3926f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1939, 5, 904, 83715.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1941, 83, 336, 58756.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1943, 67, 876, 62107.375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1945, 89, 145, 2389.924f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1947, 56, 420, 49124.793f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1949, 36, 810, 84256.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1951, 81, 439, 13446.803f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1953, 60, 216, 11885.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1955, 70, 708, 63817.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1957, 67, 75, 43465.344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1959, 10, 633, 17040.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1961, 71, 867, 58650.348f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1963, 70, 330, 33355.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1965, 4, 674, 7830.643f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1967, 27, 516, 85143.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1969, 27, 336, 13965.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1971, 83, 201, 85372.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1973, 35, 777, 74065.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1975, 78, 430, 22007.514f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1977, 78, 641, 35456.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1979, 44, 110, 73715.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1981, 71, 830, 44843.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1983, 32, 420, 9196.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1985, 38, 151, 37532.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1987, 50, 540, 42270.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1989, 48, 820, 6582.8706f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1991, 23, 657, 86553.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1993, 8, 195, 51806.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1995, 27, 620, 35147.004f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1997, 53, 539, 52345.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 1999, 60, 569, 7260.741f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2001, 72, 459, 57453.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2003, 73, 445, 76105.66f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2005, 41, 979, 24550.193f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2007, 84, 463, 78733.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2009, 52, 526, 55743.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2011, 68, 696, 66856.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2013, 9, 902, 53525.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2015, 59, 156, 87581.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2017, 52, 153, 41441.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2019, 6, 500, 49952.523f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2021, 64, 930, 81892.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2023, 87, 418, 49522.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2025, 3, 344, 53156.742f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2027, 84, 24, 74442.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2029, 49, 855, 4961.4937f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2031, 15, 653, 65805.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2033, 86, 946, 47668.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2035, 31, 112, 14139.136f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2037, 38, 299, 35207.387f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2039, 80, 32, 62385.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2041, 44, 896, 58941.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2043, 5, 408, 70258.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2045, 70, 229, 72891.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2047, 42, 411, 76277.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2049, 73, 753, 40506.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2051, 13, 9, 83362.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2053, 38, 82, 46344.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2055, 35, 648, 9371.771f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2057, 72, 203, 13013.045f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2059, 51, 169, 30757.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2061, 67, 886, 1763.3525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2063, 99, 977, 53701.613f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2065, 46, 85, 51975.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2067, 86, 361, 58337.812f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2069, 84, 39, 22012.533f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2071, 83, 865, 81830.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2073, 23, 659, 71898.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2075, 36, 361, 64635.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2077, 59, 305, 67296.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2079, 42, 557, 75558.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2081, 80, 654, 16087.9375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2083, 75, 389, 10230.274f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2085, 97, 707, 40450.742f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2087, 25, 334, 33813.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2089, 45, 261, 63394.207f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2091, 55, 522, 13620.689f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2093, 67, 604, 33181.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2095, 30, 885, 29704.568f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2097, 86, 100, 28554.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2099, 12, 808, 68337.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2101, 69, 858, 36022.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2103, 67, 357, 60864.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2105, 25, 529, 14978.271f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2107, 37, 676, 32505.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2109, 76, 67, 44474.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2111, 53, 653, 42119.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2113, 10, 950, 38859.258f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2115, 49, 673, 20234.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2117, 6, 484, 83028.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2119, 67, 199, 43135.902f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2121, 6, 300, 50697.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2123, 72, 11, 66064.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2125, 94, 526, 25420.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2127, 7, 953, 50267.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2129, 19, 549, 87176.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2131, 18, 551, 4400.5107f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2133, 64, 937, 21031.127f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2135, 18, 858, 47822.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2137, 48, 508, 45097.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2139, 49, 987, 50461.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2141, 34, 65, 80843.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2143, 7, 277, 15817.9375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2145, 58, 739, 24803.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2147, 72, 564, 28957.283f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2149, 26, 64, 34013.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2151, 9, 914, 55411.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2153, 67, 360, 64238.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2155, 85, 615, 64576.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2157, 73, 787, 47098.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2159, 79, 599, 23922.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2161, 4, 101, 29015.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2163, 53, 614, 2117.2214f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2165, 70, 267, 64245.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2167, 16, 388, 65401.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2169, 48, 813, 88625.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2171, 36, 879, 4914.318f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2173, 74, 154, 85356.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2175, 19, 134, 44396.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2177, 28, 349, 48008.152f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2179, 99, 347, 70240.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2181, 61, 212, 74654.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2183, 21, 242, 16544.049f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2185, 67, 33, 20821.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2187, 95, 363, 85671.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2189, 75, 269, 31013.455f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2191, 94, 494, 34986.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2193, 73, 675, 67859.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2195, 26, 321, 75015.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2197, 42, 398, 84224.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2199, 76, 11, 5028.006f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2201, 34, 281, 65842.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2203, 79, 514, 55217.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2205, 6, 465, 17625.215f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2207, 87, 703, 69513.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2209, 12, 484, 8161.4697f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2211, 70, 508, 18401.215f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2213, 34, 502, 43163.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2215, 85, 652, 87079.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2217, 76, 375, 46601.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2219, 6, 395, 42986.227f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2221, 49, 672, 30721.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2223, 89, 288, 31471.885f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2225, 1, 260, 51744.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2227, 29, 558, 24183.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2229, 35, 343, 32626.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2231, 51, 649, 75179.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2233, 89, 9, 59765.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2235, 74, 106, 20352.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2237, 8, 765, 60103.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2239, 22, 21, 650.3478f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2241, 3, 885, 51193.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2243, 16, 564, 19549.672f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2245, 60, 946, 16347.233f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2247, 11, 972, 48806.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2249, 15, 6, 79850.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2251, 89, 858, 69246.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2253, 12, 907, 63358.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2255, 9, 345, 33098.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2257, 48, 656, 2700.2124f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2259, 10, 837, 79951.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2261, 92, 741, 16262.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2263, 84, 540, 43230.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2265, 99, 8, 5485.1914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2267, 25, 957, 16176.041f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2269, 53, 192, 72794.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2271, 75, 717, 78136.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2273, 11, 24, 5848.7124f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2275, 16, 902, 12080.849f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2277, 33, 240, 33280.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2279, 6, 109, 66081.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2281, 45, 410, 50698.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2283, 19, 323, 59212.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2285, 77, 79, 24520.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2287, 96, 586, 79221.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2289, 14, 772, 72714.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2291, 78, 206, 49749.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2293, 24, 950, 55617.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2295, 31, 226, 72119.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2297, 90, 855, 19413.848f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2299, 78, 479, 45394.508f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2301, 60, 644, 34760.375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2303, 74, 878, 45986.227f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2305, 57, 109, 26424.494f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2307, 49, 743, 39489.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2309, 52, 52, 79797.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2311, 30, 412, 6161.179f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2313, 64, 38, 65783.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2315, 6, 134, 9405.216f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2317, 6, 10, 71465.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2319, 19, 455, 55595.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2321, 19, 796, 59193.832f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2323, 28, 624, 89346.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2325, 74, 99, 77704.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2327, 78, 119, 30947.553f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2329, 93, 162, 65889.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2331, 38, 243, 18272.848f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2333, 36, 308, 84238.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2335, 20, 871, 43514.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2337, 77, 364, 89114.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2339, 20, 124, 23963.693f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2341, 3, 584, 83103.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2343, 45, 426, 52522.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2345, 53, 347, 82401.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2347, 30, 161, 7913.988f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2349, 38, 219, 18757.506f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2351, 11, 125, 56907.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2353, 15, 491, 17455.701f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2355, 97, 856, 43410.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2357, 32, 349, 70659.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2359, 12, 460, 21316.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2361, 81, 487, 71205.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2363, 23, 590, 16162.671f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2365, 7, 664, 5399.0566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2367, 18, 361, 15827.8955f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2369, 91, 667, 5258.579f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2371, 37, 808, 69826.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2373, 93, 465, 29813.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2375, 47, 328, 89366.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2377, 96, 199, 63729.457f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2379, 74, 415, 28078.916f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2381, 39, 744, 80657.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2383, 49, 326, 73337.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2385, 47, 684, 87759.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2387, 29, 394, 30967.418f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2389, 16, 961, 89860.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2391, 18, 596, 82024.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2393, 53, 331, 66481.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2395, 47, 526, 5313.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2397, 25, 149, 66702.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2399, 74, 566, 15123.972f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2401, 72, 284, 10077.256f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2403, 40, 262, 21203.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2405, 47, 828, 82923.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2407, 81, 848, 9452.8545f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2409, 21, 249, 80084.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2411, 17, 678, 34480.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2413, 22, 150, 51095.926f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2415, 52, 744, 23253.143f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2417, 24, 754, 35605.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2419, 28, 338, 53055.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2421, 36, 944, 3058.1167f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2423, 33, 536, 23555.217f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2425, 52, 575, 58924.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2427, 92, 993, 11579.206f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2429, 92, 169, 68112.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2431, 57, 545, 9995.851f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2433, 64, 132, 32406.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2435, 67, 809, 83447.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2437, 38, 61, 55154.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2439, 78, 164, 7695.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2441, 87, 377, 27291.668f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2443, 32, 650, 24756.898f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2445, 91, 390, 74637.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2447, 88, 196, 22135.531f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2449, 68, 714, 8126.642f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2451, 73, 278, 70804.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2453, 71, 676, 55859.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2455, 48, 105, 34405.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2457, 58, 732, 40207.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2459, 7, 645, 83647.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2461, 7, 828, 13206.7705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2463, 22, 891, 40611.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2465, 1, 682, 76512.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2467, 54, 106, 13679.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2469, 32, 639, 7465.5923f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2471, 11, 350, 8152.6064f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2473, 45, 983, 15855.632f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2475, 6, 233, 54151.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2477, 78, 299, 20771.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2479, 35, 249, 58820.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2481, 32, 822, 3869.0774f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2483, 6, 516, 16072.933f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2485, 27, 806, 37755.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2487, 4, 673, 58761.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2489, 98, 234, 79093.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2491, 76, 785, 1062.0798f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2493, 40, 635, 18400.076f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2495, 74, 639, 71423.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2497, 61, 621, 27849.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2499, 88, 37, 58624.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2501, 61, 522, 45663.527f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2503, 82, 578, 51567.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2505, 54, 765, 56023.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2507, 20, 558, 37256.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2509, 57, 976, 11370.044f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2511, 37, 385, 58762.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2513, 30, 763, 26725.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2515, 14, 557, 75085.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2517, 32, 180, 55987.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2519, 59, 124, 68220.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2521, 95, 575, 65966.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2523, 55, 141, 75969.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2525, 14, 65, 35774.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2527, 13, 410, 550.3078f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2529, 47, 449, 38662.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2531, 66, 875, 40316.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2533, 62, 687, 17411.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2535, 18, 774, 31999.838f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2537, 6, 996, 56031.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2539, 18, 201, 49312.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2541, 16, 465, 67033.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2543, 38, 369, 13678.946f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2545, 75, 673, 39537.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2547, 5, 361, 26834.357f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2549, 4, 553, 19334.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2551, 6, 326, 3308.8726f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2553, 37, 964, 21545.521f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2555, 82, 339, 16933.277f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2557, 98, 100, 8424.736f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2559, 5, 740, 75828.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2561, 51, 318, 38494.562f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2563, 6, 92, 89510.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2565, 71, 258, 12816.158f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2567, 37, 193, 47970.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2569, 74, 471, 29118.236f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2571, 30, 303, 41442.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2573, 44, 7, 8599.409f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2575, 2, 627, 1510.4482f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2577, 65, 460, 6530.972f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2579, 21, 313, 31128.033f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2581, 97, 559, 14479.615f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2583, 8, 531, 77618.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2585, 19, 428, 3056.7705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2587, 26, 924, 3700.271f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2589, 26, 602, 19868.541f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2591, 95, 421, 43296.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2593, 14, 434, 57707.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2595, 87, 604, 67544.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2597, 49, 929, 37752.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2599, 94, 366, 62311.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2601, 40, 323, 6955.969f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2603, 28, 781, 39207.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2605, 76, 5, 36446.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2607, 99, 202, 41657.926f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2609, 44, 428, 14168.382f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2611, 81, 135, 2432.4336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2613, 62, 48, 82084.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2615, 14, 9, 33834.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2617, 38, 173, 80609.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2619, 15, 743, 18517.754f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2621, 15, 162, 31027.928f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2623, 13, 925, 28478.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2625, 91, 666, 14483.976f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2627, 75, 230, 5267.1807f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2629, 69, 932, 48226.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2631, 2, 540, 66732.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2633, 18, 577, 87347.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2635, 24, 938, 32664.361f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2637, 62, 577, 84406.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2639, 37, 364, 54381.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2641, 2, 572, 22218.783f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2643, 45, 885, 24987.969f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2645, 54, 335, 19643.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2647, 93, 612, 51831.152f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2649, 93, 1000, 79310.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2651, 78, 138, 62196.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2653, 98, 937, 40537.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2655, 77, 74, 84381.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2657, 40, 153, 69240.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2659, 75, 442, 36468.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2661, 63, 951, 58302.848f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2663, 54, 155, 22778.912f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2665, 25, 779, 34659.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2667, 86, 209, 13428.076f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2669, 53, 252, 89655.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2671, 97, 142, 53613.758f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2673, 14, 963, 40934.777f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2675, 45, 773, 14811.303f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2677, 44, 437, 35748.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2679, 61, 717, 89152.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2681, 63, 344, 35541.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2683, 13, 523, 46730.637f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2685, 20, 177, 11704.135f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2687, 18, 420, 44881.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2689, 61, 1000, 35246.348f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2691, 47, 695, 23163.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2693, 89, 88, 28668.873f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2695, 57, 481, 10145.499f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2697, 5, 158, 10096.006f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2699, 92, 337, 45700.688f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2701, 5, 957, 12254.606f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2703, 78, 153, 12946.054f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2705, 98, 302, 10406.997f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2707, 87, 98, 33999.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2709, 78, 250, 45045.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2711, 51, 791, 84371.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2713, 12, 976, 79202.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2715, 39, 324, 78886.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2717, 71, 875, 49571.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2719, 57, 882, 64509.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2721, 26, 458, 54575.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2723, 83, 831, 10453.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2725, 53, 72, 1582.3718f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2727, 39, 482, 63772.992f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2729, 83, 265, 25476.377f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2731, 94, 426, 45241.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2733, 94, 982, 72860.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2735, 15, 392, 45026.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2737, 97, 124, 52438.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2739, 12, 344, 66572.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2741, 89, 833, 68715.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2743, 56, 138, 12243.063f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2745, 57, 430, 24083.932f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2747, 83, 334, 36316.992f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2749, 20, 991, 19279.674f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2751, 51, 97, 18966.525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2753, 14, 600, 7606.5664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2755, 72, 809, 66660.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2757, 40, 356, 82555.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2759, 20, 886, 36476.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2761, 6, 240, 41676.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2763, 72, 797, 64538.754f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2765, 4, 499, 2464.8342f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2767, 3, 98, 23728.705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2769, 46, 661, 27369.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2771, 92, 122, 33575.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2773, 90, 269, 22149.121f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2775, 78, 974, 18847.455f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2777, 38, 918, 6124.431f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2779, 36, 228, 83089.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2781, 43, 490, 72864.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2783, 16, 707, 59021.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2785, 49, 380, 40914.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2787, 3, 29, 26457.287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2789, 48, 975, 35610.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2791, 75, 164, 80776.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2793, 15, 241, 89625.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2795, 52, 406, 37285.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2797, 69, 866, 56452.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2799, 23, 498, 83439.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2801, 71, 421, 34764.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2803, 8, 425, 7791.9663f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2805, 98, 397, 70729.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2807, 23, 907, 5049.5156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2809, 63, 110, 30092.166f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2811, 96, 384, 10870.587f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2813, 17, 136, 20720.615f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2815, 59, 28, 43737.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2817, 22, 90, 3565.1592f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2819, 64, 32, 59545.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2821, 49, 875, 1571.0618f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2823, 68, 498, 12643.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2825, 20, 302, 23841.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2827, 7, 966, 82910.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2829, 82, 138, 21604.137f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2831, 14, 987, 32527.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2833, 6, 727, 62883.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2835, 52, 362, 36162.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2837, 17, 688, 56691.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2839, 75, 419, 50301.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2841, 9, 922, 76977.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2843, 77, 192, 14237.548f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2845, 98, 93, 84276.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2847, 79, 80, 37176.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2849, 5, 704, 29786.457f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2851, 5, 162, 54865.277f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2853, 57, 306, 79593.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2855, 50, 994, 4482.397f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2857, 39, 540, 66979.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2859, 20, 296, 37533.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2861, 37, 65, 16384.525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2863, 50, 355, 10611.177f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2865, 34, 466, 72370.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2867, 97, 144, 68163.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2869, 83, 267, 32196.072f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2871, 19, 690, 86139.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2873, 94, 276, 29199.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2875, 40, 818, 14619.226f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2877, 61, 515, 30403.252f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2879, 11, 529, 57081.453f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2881, 41, 906, 83577.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2883, 85, 222, 66391.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2885, 62, 692, 51868.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2887, 37, 575, 70121.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2889, 17, 889, 21276.045f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2891, 57, 935, 4233.737f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2893, 45, 186, 76153.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2895, 93, 172, 5262.398f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2897, 97, 358, 637.0025f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2899, 18, 136, 56710.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2901, 53, 925, 22484.672f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2903, 84, 829, 80422.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2905, 99, 424, 87292.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2907, 85, 803, 52768.848f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2909, 44, 827, 38564.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2911, 10, 133, 43551.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2913, 15, 66, 40189.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2915, 96, 851, 87469.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2917, 58, 784, 19290.352f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2919, 74, 418, 52872.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2921, 37, 188, 58245.426f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2923, 12, 99, 17742.852f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2925, 52, 515, 17239.754f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2927, 52, 108, 61406.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2929, 81, 435, 17761.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2931, 55, 219, 71316.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2933, 9, 943, 64239.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2935, 51, 609, 6376.2075f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2937, 28, 459, 64787.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2939, 12, 8, 11446.8955f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2941, 61, 51, 29498.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2943, 69, 765, 35260.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2945, 4, 395, 2727.896f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2947, 57, 573, 56192.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2949, 74, 799, 20552.045f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2951, 69, 112, 372.144f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2953, 87, 137, 89248.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2955, 90, 224, 24783.148f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2957, 50, 35, 1951.5831f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2959, 93, 74, 45586.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2961, 47, 456, 43855.094f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2963, 32, 167, 80397.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2965, 97, 136, 54077.848f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2967, 80, 150, 77655.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2969, 63, 826, 35736.758f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2971, 1, 134, 40365.332f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2973, 12, 265, 71500.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2975, 76, 960, 5163.7026f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2977, 14, 96, 88278.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2979, 16, 763, 64444.562f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2981, 39, 246, 10299.568f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2983, 83, 767, 79809.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2985, 37, 939, 85689.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2987, 61, 84, 22622.328f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2989, 91, 759, 62687.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2991, 85, 17, 41624.996f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2993, 97, 49, 39833.02f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2995, 83, 590, 54393.473f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2997, 91, 296, 82922.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 2999, 40, 706, 67409.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3001, 99, 935, 41258.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3003, 70, 680, 31924.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3005, 36, 621, 77483.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3007, 90, 769, 5298.4287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3009, 31, 389, 48948.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3011, 18, 135, 61622.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3013, 27, 886, 45264.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3015, 2, 862, 83479.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3017, 59, 977, 63562.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3019, 97, 729, 59424.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3021, 4, 404, 30871.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3023, 91, 800, 42124.824f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3025, 85, 956, 30752.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3027, 91, 895, 46008.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3029, 89, 2, 12198.005f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3031, 10, 747, 70607.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3033, 9, 831, 59086.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3035, 60, 239, 89717.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3037, 93, 213, 69322.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3039, 50, 117, 14131.577f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3041, 50, 210, 14608.291f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3043, 6, 879, 26747.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3045, 88, 8, 40037.094f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3047, 5, 797, 2005.3306f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3049, 44, 159, 83399.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3051, 91, 407, 56776.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3053, 5, 872, 72098.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3055, 73, 987, 20744.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3057, 61, 121, 24504.037f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3059, 4, 173, 36.8996f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3061, 7, 225, 50771.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3063, 38, 431, 28729.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3065, 11, 72, 26264.768f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3067, 3, 575, 71663.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3069, 85, 88, 15716.716f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3071, 60, 788, 26810.396f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3073, 87, 22, 15154.578f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3075, 29, 414, 24717.814f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3077, 97, 443, 86852.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3079, 90, 242, 69749.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3081, 93, 247, 50224.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3083, 78, 269, 18254.059f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3085, 82, 669, 23305.037f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3087, 15, 815, 88579.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3089, 70, 249, 76878.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3091, 99, 583, 27689.152f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3093, 5, 229, 20131.648f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3095, 64, 339, 74265.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3097, 43, 110, 50354.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3099, 19, 715, 82483.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3101, 27, 41, 21755.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3103, 69, 746, 36170.297f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3105, 70, 573, 82817.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3107, 11, 720, 2585.4272f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3109, 85, 297, 18783.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3111, 17, 878, 59778.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3113, 15, 916, 87391.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3115, 10, 754, 32204.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3117, 39, 967, 55176.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3119, 69, 540, 88030.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3121, 94, 373, 42420.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3123, 24, 116, 48319.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3125, 88, 167, 15962.347f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3127, 32, 975, 80454.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3129, 97, 779, 17587.656f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3131, 25, 115, 55834.797f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3133, 24, 651, 53187.004f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3135, 15, 911, 61228f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3137, 88, 965, 88595.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3139, 47, 467, 59201.348f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3141, 2, 962, 39145.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3143, 88, 549, 71468.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3145, 11, 77, 17132.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3147, 22, 45, 1406.5868f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3149, 33, 677, 2907.8552f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3151, 23, 527, 51958.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3153, 33, 784, 83506.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3155, 32, 427, 72014.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3157, 46, 505, 77261.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3159, 93, 829, 71005.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3161, 97, 218, 36626.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3163, 33, 537, 22689.963f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3165, 12, 744, 56495.57f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3167, 62, 594, 82807.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3169, 91, 978, 83728.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3171, 95, 494, 2830.2844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3173, 37, 874, 85318.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3175, 32, 681, 69401.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3177, 50, 393, 80775.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3179, 70, 265, 71253.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3181, 59, 939, 87998.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3183, 75, 272, 2886.4219f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3185, 43, 167, 63433.027f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3187, 60, 560, 1102.433f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3189, 40, 261, 88052.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3191, 57, 11, 11365.015f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3193, 51, 41, 32755.584f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3195, 70, 293, 45116.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3197, 60, 362, 2644.096f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3199, 78, 647, 85929.25f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3201, 74, 804, 72615.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3203, 19, 448, 56853.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3205, 22, 368, 49550.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3207, 25, 397, 23297.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3209, 44, 30, 23683.996f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3211, 9, 661, 55391.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3213, 78, 465, 72467.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3215, 76, 615, 27404.307f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3217, 38, 307, 5740.8765f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3219, 67, 354, 26536.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3221, 31, 638, 72729.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3223, 51, 429, 38297.324f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3225, 96, 343, 23670.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3227, 92, 559, 27341.531f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3229, 47, 884, 67469.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3231, 13, 333, 12357.519f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3233, 73, 546, 80249f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3235, 99, 69, 28253.523f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3237, 49, 860, 59894.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3239, 86, 544, 78836.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3241, 69, 795, 77435.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3243, 50, 303, 74174.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3245, 20, 181, 75958.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3247, 19, 316, 43775.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3249, 40, 133, 51867.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3251, 23, 476, 77597.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3253, 59, 555, 70980.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3255, 69, 865, 85911.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3257, 56, 213, 63825.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3259, 29, 576, 40649.918f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3261, 12, 669, 48540.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3263, 42, 893, 28563.057f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3265, 4, 544, 12613.302f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3267, 51, 980, 7139.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3269, 97, 364, 81957.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3271, 86, 382, 81608.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3273, 59, 1000, 42077.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3275, 40, 214, 46382.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3277, 9, 369, 18145.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3279, 17, 47, 62957.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3281, 4, 165, 40110.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3283, 77, 31, 69344.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3285, 78, 255, 777.9115f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3287, 34, 614, 36640.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3289, 47, 719, 82358.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3291, 87, 493, 18846.885f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3293, 8, 943, 80860.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3295, 79, 357, 74701.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3297, 41, 580, 76160.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3299, 59, 861, 36318.473f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3301, 75, 707, 65347.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3303, 21, 509, 1954.7534f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3305, 66, 902, 13648.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3307, 50, 428, 23101.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3309, 95, 594, 23130.215f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3311, 59, 238, 43814.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3313, 53, 906, 6374.6826f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3315, 61, 55, 33663.105f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3317, 63, 914, 19334.393f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3319, 65, 423, 82173.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3321, 76, 740, 29323.043f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3323, 81, 322, 65698.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3325, 18, 897, 49888.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3327, 33, 836, 1265.2668f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3329, 76, 284, 38842.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3331, 68, 672, 86903.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3333, 76, 841, 37461.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3335, 51, 489, 55961.035f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3337, 95, 731, 63169.594f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3339, 46, 720, 70209.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3341, 32, 625, 71386.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3343, 83, 920, 54938.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3345, 61, 115, 33921.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3347, 90, 357, 75080.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3349, 7, 660, 89872.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3351, 13, 536, 38037.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3353, 1, 126, 83565.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3355, 66, 114, 57913.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3357, 22, 951, 70185.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3359, 51, 207, 47560.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3361, 25, 388, 55962.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3363, 40, 686, 16673.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3365, 51, 931, 7339.2773f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3367, 56, 90, 32417.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3369, 52, 957, 20897.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3371, 96, 624, 88532.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3373, 91, 76, 25345.604f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3375, 33, 346, 64062.316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3377, 90, 838, 5092.7036f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3379, 77, 417, 56363.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3381, 39, 228, 3484.817f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3383, 45, 255, 35082.66f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3385, 96, 914, 16786.422f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3387, 92, 9, 34361.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3389, 89, 260, 72599.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3391, 9, 970, 84962.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3393, 98, 26, 40430.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3395, 43, 56, 13581.972f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3397, 99, 165, 17780.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3399, 46, 717, 22673.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3401, 62, 865, 76592.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3403, 73, 466, 47285.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3405, 88, 493, 2771.9763f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3407, 47, 993, 17110.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3409, 66, 392, 40195.062f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3411, 18, 864, 63839.344f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3413, 77, 355, 89876.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3415, 57, 786, 73903.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3417, 41, 977, 79596.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3419, 96, 44, 54919.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3421, 77, 135, 25619.049f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3423, 22, 486, 20605.648f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3425, 1, 338, 70839.08f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3427, 47, 587, 58088.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3429, 36, 38, 51991.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3431, 55, 781, 74214.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3433, 20, 449, 58050.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3435, 75, 575, 48452.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3437, 2, 582, 15944.919f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3439, 38, 723, 11006.303f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3441, 2, 557, 64641.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3443, 3, 138, 16545.121f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3445, 77, 645, 59274.246f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3447, 44, 868, 76711.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3449, 36, 29, 36581.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3451, 78, 191, 83967.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3453, 59, 466, 31578.725f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3455, 74, 590, 32458.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3457, 66, 7, 59073.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3459, 86, 256, 12357.087f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3461, 5, 886, 14277.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3463, 56, 294, 74807.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3465, 64, 520, 41864.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3467, 78, 852, 27768.219f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3469, 61, 974, 39756.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3471, 87, 560, 18386.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3473, 89, 440, 56898.363f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3475, 7, 475, 68112.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3477, 82, 197, 51733.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3479, 29, 142, 16185.257f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3481, 56, 263, 56318.867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3483, 32, 802, 5624.4316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3485, 45, 829, 620.88745f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3487, 88, 869, 6341.0044f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3489, 50, 101, 46671.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3491, 25, 491, 18934.709f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3493, 25, 901, 13208.667f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3495, 29, 582, 71672.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3497, 6, 78, 83127.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3499, 74, 163, 43099.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3501, 25, 685, 58396.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3503, 72, 156, 29593.549f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3505, 8, 460, 40922.582f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3507, 38, 278, 37420.176f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3509, 44, 564, 74680.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3511, 18, 391, 24017.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3513, 31, 509, 7257.061f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3515, 11, 380, 37294.637f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3517, 8, 889, 4063.0146f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3519, 89, 345, 78445.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3521, 91, 555, 69048.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3523, 12, 862, 49805.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3525, 74, 940, 17737.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3527, 53, 93, 43178.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3529, 72, 594, 82342.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3531, 93, 712, 54659.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3533, 78, 948, 42412.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3535, 28, 40, 42238.383f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3537, 98, 230, 18033.287f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3539, 71, 950, 13208.252f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3541, 18, 40, 24051.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3543, 12, 167, 40499.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3545, 52, 845, 57567.676f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3547, 46, 561, 19407.143f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3549, 97, 379, 68954.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3551, 5, 96, 76324.695f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3553, 20, 747, 65076.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3555, 84, 13, 87994.4f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3557, 29, 7, 67632.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3559, 22, 853, 11232.861f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3561, 85, 393, 51465.797f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3563, 60, 291, 12886.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3565, 49, 345, 60999.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3567, 67, 972, 83626.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3569, 47, 808, 42591.926f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3571, 55, 452, 34037.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3573, 89, 111, 33733.246f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3575, 95, 118, 35989.254f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3577, 77, 54, 36455.008f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3579, 78, 859, 28671.352f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3581, 55, 746, 14567.394f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3583, 4, 841, 78003.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3585, 39, 336, 10649.391f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3587, 11, 356, 79586.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3589, 69, 779, 83979.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3591, 70, 176, 31161.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3593, 42, 75, 42096.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3595, 39, 66, 28092.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3597, 56, 229, 84974.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3599, 98, 449, 18486.627f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3601, 44, 728, 64791.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3603, 41, 305, 58561.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3605, 98, 328, 50698.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3607, 78, 637, 16609.355f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3609, 27, 914, 2795.7292f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3611, 24, 116, 54301.79f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3613, 26, 598, 56789.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3615, 52, 330, 16344.204f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3617, 44, 566, 53866.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3619, 67, 437, 17037.494f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3621, 74, 506, 67806.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3623, 9, 963, 63697.594f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3625, 32, 362, 9083.971f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3627, 72, 833, 52006.547f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3629, 59, 872, 10381.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3631, 10, 156, 56316.953f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3633, 86, 855, 35939.145f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3635, 49, 352, 1433.8506f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3637, 62, 939, 64811.25f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3639, 5, 667, 87058.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3641, 86, 385, 87731.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3643, 87, 968, 17563.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3645, 63, 52, 8450.804f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3647, 84, 197, 6764.638f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3649, 42, 48, 88731.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3651, 51, 601, 27763.703f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3653, 76, 290, 7153.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3655, 5, 255, 20380.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3657, 85, 225, 59489.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3659, 47, 397, 19157.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3661, 99, 288, 30448.979f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3663, 90, 161, 31244.783f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3665, 44, 713, 2075.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3667, 83, 635, 19987.031f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3669, 17, 731, 17745.885f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3671, 58, 245, 40989.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3673, 83, 57, 89209.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3675, 64, 228, 817.86017f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3677, 12, 385, 8326.272f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3679, 49, 707, 18289.732f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3681, 95, 582, 86543.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3683, 89, 961, 23978.303f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3685, 24, 258, 14878.534f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3687, 21, 964, 59790.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3689, 94, 450, 79521.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3691, 82, 298, 74003.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3693, 82, 193, 39077.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3695, 55, 314, 61503.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3697, 94, 402, 80314.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3699, 48, 647, 4080.7283f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3701, 95, 536, 20729.69f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3703, 55, 221, 61039.645f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3705, 18, 285, 82043.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3707, 65, 501, 30309.682f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3709, 20, 882, 20668.033f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3711, 18, 735, 54649.094f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3713, 23, 670, 71380.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3715, 51, 952, 17192.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3717, 21, 543, 9481.723f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3719, 67, 880, 25438.102f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3721, 42, 809, 24121.93f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3723, 10, 834, 12107.649f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3725, 35, 870, 10702.681f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3727, 47, 176, 75046.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3729, 29, 419, 37240.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3731, 7, 447, 42780.223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3733, 68, 105, 25196.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3735, 43, 382, 15097.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3737, 19, 723, 43298.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3739, 24, 980, 24404.537f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3741, 40, 282, 87155.375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3743, 87, 500, 33155.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3745, 67, 476, 1623.7535f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3747, 17, 577, 53592.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3749, 73, 76, 81010.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3751, 65, 621, 22590.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3753, 17, 33, 22421.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3755, 1, 23, 45188.395f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3757, 51, 985, 54369.277f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3759, 35, 619, 7119.3076f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3761, 64, 716, 75302.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3763, 15, 20, 75458.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3765, 24, 820, 82989.85f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3767, 96, 458, 49758.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3769, 78, 339, 21084.514f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3771, 2, 488, 84596.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3773, 96, 612, 26106.514f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3775, 64, 776, 23054.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3777, 65, 614, 59039.676f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3779, 87, 761, 83665.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3781, 7, 659, 43232.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3783, 86, 178, 77645.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3785, 90, 878, 75645.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3787, 72, 67, 89246.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3789, 9, 856, 12806.748f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3791, 71, 458, 88804.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3793, 26, 642, 81366.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3795, 8, 318, 36129.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3797, 98, 35, 42602.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3799, 11, 664, 32873.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3801, 45, 930, 15222.696f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3803, 12, 492, 87342.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3805, 59, 224, 187.77498f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3807, 49, 769, 76162.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3809, 31, 575, 40022.316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3811, 14, 775, 85078.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3813, 21, 487, 33251.92f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3815, 96, 45, 2385.2346f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3817, 22, 975, 3187.7983f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3819, 21, 127, 23427.545f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3821, 35, 358, 79747.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3823, 99, 222, 30489.615f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3825, 73, 825, 77345.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3827, 11, 123, 64754.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3829, 43, 376, 81563.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3831, 31, 497, 80892.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3833, 97, 647, 55210.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3835, 89, 747, 55984.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3837, 83, 659, 58224.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3839, 12, 310, 41236.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3841, 64, 439, 76369.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3843, 74, 673, 38869.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3845, 31, 983, 32901.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3847, 62, 396, 83411.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3849, 93, 700, 57676.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3851, 88, 360, 21411.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3853, 59, 679, 68896.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3855, 29, 584, 82101.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3857, 86, 283, 37261.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3859, 48, 586, 77588.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3861, 61, 81, 78668.55f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3863, 29, 15, 79920.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3865, 9, 657, 27168.146f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3867, 85, 210, 82551.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3869, 53, 862, 24937.545f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3871, 41, 750, 5931.686f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3873, 2, 798, 81467.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3875, 14, 206, 71007.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3877, 78, 2, 81582.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3879, 5, 250, 13122.541f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3881, 49, 556, 65636.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3883, 33, 238, 37118.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3885, 61, 663, 53972.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3887, 64, 471, 45956.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3889, 48, 247, 3258.4749f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3891, 38, 709, 18953.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3893, 68, 893, 32808.38f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3895, 10, 417, 65166.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3897, 31, 967, 19488.879f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3899, 27, 682, 47673.777f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3901, 65, 900, 84802.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3903, 86, 919, 78837.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3905, 23, 707, 5351.665f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3907, 93, 628, 76765.73f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3909, 79, 183, 18569.209f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3911, 21, 224, 33589.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3913, 69, 872, 72932.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3915, 35, 558, 62038.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3917, 96, 223, 73718.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3919, 24, 451, 62804.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3921, 51, 559, 80426.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3923, 23, 286, 34592.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3925, 17, 344, 35475.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3927, 4, 203, 75188.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3929, 22, 221, 34981.438f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3931, 95, 176, 54414.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3933, 35, 713, 66980.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3935, 53, 912, 59495.04f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3937, 3, 889, 64916.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3939, 82, 210, 6515.6294f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3941, 63, 121, 57207.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3943, 56, 333, 44163.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3945, 90, 214, 17105.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3947, 88, 256, 77603.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3949, 67, 334, 670.5514f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3951, 99, 168, 43180.51f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3953, 20, 927, 75978.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3955, 49, 489, 39757.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3957, 1, 467, 2377.3433f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3959, 93, 69, 48361.617f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3961, 52, 452, 87198.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3963, 68, 784, 77809.66f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3965, 9, 751, 19733.912f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3967, 56, 383, 45303.645f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3969, 5, 167, 70401.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3971, 73, 454, 33423.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3973, 80, 336, 47478.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3975, 33, 796, 38023.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3977, 37, 139, 76175.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3979, 18, 312, 54943.176f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3981, 61, 923, 23624.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3983, 14, 649, 37408.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3985, 3, 82, 9778.616f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3987, 33, 248, 55017.5f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3989, 42, 706, 61395.316f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3991, 90, 652, 61094.934f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3993, 6, 920, 66010.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3995, 29, 696, 26349.402f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3997, 28, 960, 81209.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 3999, 72, 263, 74741.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4001, 26, 66, 8618.593f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4003, 21, 71, 65666.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4005, 1, 507, 11285.474f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4007, 12, 520, 85989.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4009, 96, 658, 37583.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4011, 9, 1, 9433.701f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4013, 72, 823, 63881.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4015, 72, 267, 15083.306f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4017, 85, 753, 54447.89f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4019, 77, 108, 60721.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4021, 68, 925, 68617.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4023, 37, 2, 34122.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4025, 34, 909, 73155.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4027, 32, 323, 13098.925f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4029, 81, 568, 3173.5022f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4031, 5, 440, 85911.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4033, 34, 180, 26118.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4035, 38, 541, 43078.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4037, 27, 193, 83188.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4039, 97, 3, 50137.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4041, 51, 791, 74860.14f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4043, 14, 470, 45829.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4045, 56, 815, 25451.012f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4047, 91, 991, 75102.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4049, 88, 627, 38034.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4051, 44, 588, 19535.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4053, 88, 738, 61300.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4055, 62, 382, 34618.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4057, 78, 916, 50571.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4059, 22, 11, 18417.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4061, 36, 391, 37584.582f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4063, 46, 465, 12794.435f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4065, 56, 783, 68060.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4067, 36, 868, 77187.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4069, 81, 597, 77069.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4071, 84, 45, 71569.266f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4073, 56, 363, 46150.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4075, 61, 229, 69686.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4077, 21, 743, 78876.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4079, 32, 867, 76684.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4081, 19, 363, 2885.1313f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4083, 11, 998, 67548.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4085, 38, 185, 63615.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4087, 59, 166, 54816.74f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4089, 81, 224, 13640.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4091, 70, 537, 83993.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4093, 13, 688, 47206.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4095, 65, 327, 54301.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4097, 8, 192, 53849.152f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4099, 34, 924, 7140.677f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4101, 79, 527, 69128.78f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4103, 24, 989, 30824.078f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4105, 49, 1, 74018.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4107, 53, 846, 59679f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4109, 52, 219, 48980.566f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4111, 70, 609, 67542.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4113, 11, 122, 8086.746f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4115, 18, 932, 4711.1147f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4117, 4, 823, 78774.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4119, 61, 616, 66418.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4121, 59, 620, 39498.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4123, 63, 540, 39720.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4125, 73, 402, 70446.125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4127, 6, 348, 13968.04f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4129, 94, 339, 62855.957f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4131, 49, 88, 14218.837f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4133, 12, 437, 24693.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4135, 69, 67, 14938.8125f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4137, 30, 827, 56767.742f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4139, 99, 862, 63598.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4141, 5, 394, 60018.727f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4143, 97, 803, 68607.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4145, 23, 485, 2962.7239f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4147, 89, 332, 16184.439f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4149, 84, 871, 22151.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4151, 74, 460, 49408.59f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4153, 3, 827, 60502.684f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4155, 5, 967, 66307.414f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4157, 14, 307, 46099.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4159, 59, 660, 2890.5728f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4161, 50, 40, 43680.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4163, 39, 304, 50476.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4165, 63, 334, 12511.7705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4167, 81, 25, 75657.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4169, 29, 248, 51475.605f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4171, 4, 159, 31328.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4173, 68, 358, 65734.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4175, 83, 51, 86467.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4177, 41, 311, 77731.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4179, 58, 793, 19751.184f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4181, 51, 496, 46893.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4183, 47, 587, 85490.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4185, 51, 121, 81482.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4187, 17, 497, 31936.209f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4189, 3, 336, 23125.176f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4191, 71, 397, 13455.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4193, 85, 940, 80421.23f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4195, 35, 512, 7096.783f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4197, 80, 187, 60223.75f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4199, 21, 720, 12668.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4201, 13, 468, 66523.33f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4203, 54, 608, 11619.175f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4205, 35, 222, 70098.91f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4207, 4, 774, 81496.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4209, 11, 184, 10559.495f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4211, 56, 340, 17327.283f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4213, 70, 450, 86210.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4215, 75, 574, 69981.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4217, 72, 818, 22697.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4219, 54, 26, 85119.805f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4221, 3, 568, 47189.133f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4223, 39, 442, 76090.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4225, 13, 85, 61041.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4227, 91, 948, 47900.34f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4229, 75, 998, 52250.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4231, 59, 471, 56898.188f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4233, 98, 712, 3868.81f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4235, 78, 969, 3161.373f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4237, 82, 674, 21243.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4239, 11, 387, 73889.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4241, 4, 471, 69192.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4243, 46, 124, 44730.79f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4245, 57, 554, 82457.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4247, 89, 985, 16896.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4249, 82, 222, 40842.2f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4251, 12, 506, 36269.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4253, 27, 638, 54715.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4255, 14, 557, 18808.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4257, 93, 585, 12415.08f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4259, 82, 333, 9372.965f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4261, 84, 721, 28803.518f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4263, 20, 56, 21605.012f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4265, 36, 667, 6527.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4267, 79, 3, 46637.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4269, 32, 897, 2158.2686f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4271, 1, 44, 27791.875f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4273, 91, 8, 76033.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4275, 53, 560, 66860.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4277, 39, 220, 71418.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4279, 39, 166, 46188.426f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4281, 76, 695, 16937.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4283, 40, 32, 74156.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4285, 6, 156, 78121.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4287, 34, 268, 78241.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4289, 33, 103, 50810.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4291, 69, 212, 53524.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4293, 74, 565, 30147.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4295, 86, 818, 44166.836f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4297, 62, 113, 39754.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4299, 15, 658, 73435.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4301, 62, 865, 75839.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4303, 17, 584, 34590.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4305, 2, 983, 40346.105f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4307, 6, 472, 31792.336f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4309, 89, 656, 35826.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4311, 13, 899, 9064.321f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4313, 49, 420, 36145.598f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4315, 12, 123, 62023.184f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4317, 18, 848, 27497.896f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4319, 19, 444, 86740.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4321, 31, 42, 73680.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4323, 36, 140, 18364.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4325, 84, 976, 20926.004f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4327, 28, 457, 59386.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4329, 41, 860, 64782.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4331, 2, 612, 14341.688f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4333, 39, 226, 16012.306f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4335, 61, 136, 41920.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4337, 83, 6, 59774.066f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4339, 48, 324, 43489.812f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4341, 67, 433, 34464.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4343, 51, 390, 88129.12f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4345, 23, 409, 28177.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4347, 31, 277, 798.91705f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4349, 31, 587, 52951.387f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4351, 92, 821, 58269.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4353, 43, 915, 52069.35f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4355, 66, 352, 17822.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4357, 45, 108, 36428.37f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4359, 27, 931, 17791.145f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4361, 62, 169, 55768.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4363, 68, 891, 46903.94f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4365, 35, 837, 64680.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4367, 80, 259, 74824.86f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4369, 77, 112, 73684.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4371, 66, 181, 30934.967f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4373, 67, 238, 21414.297f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4375, 53, 303, 47158.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4377, 55, 163, 63329.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4379, 55, 735, 77182.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4381, 87, 553, 76405.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4383, 53, 404, 47116.32f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4385, 83, 623, 45045.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4387, 15, 740, 35836.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4389, 37, 97, 11173.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4391, 83, 178, 66873.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4393, 51, 547, 33363.383f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4395, 17, 889, 6244.866f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4397, 62, 249, 54581.285f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4399, 32, 106, 85224.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4401, 73, 732, 89308.664f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4403, 43, 103, 24016.3f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4405, 79, 572, 84162.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4407, 9, 294, 87991.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4409, 95, 977, 5107.2515f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4411, 39, 164, 13318.601f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4413, 11, 81, 51018.562f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4415, 88, 825, 9659.642f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4417, 41, 787, 36219.46f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4419, 71, 554, 11464.762f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4421, 30, 265, 81779.09f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4423, 24, 268, 58667.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4425, 51, 281, 71704.77f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4427, 75, 855, 60089.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4429, 90, 426, 87860.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4431, 50, 231, 50489.53f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4433, 75, 677, 26198.271f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4435, 3, 677, 1195.9855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4437, 1, 359, 33892.312f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4439, 38, 208, 27325.273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4441, 1, 796, 7681.2817f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4443, 38, 161, 86413.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4445, 26, 517, 81277.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4447, 99, 542, 55435.777f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4449, 70, 981, 13576.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4451, 98, 42, 58964.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4453, 37, 750, 36123.24f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4455, 33, 8, 42274.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4457, 7, 445, 18006.342f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4459, 72, 473, 47043.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4461, 33, 340, 20883.28f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4463, 50, 330, 49163.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4465, 74, 667, 88224.82f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4467, 77, 139, 23058.494f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4469, 71, 999, 14011.726f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4471, 10, 585, 88187.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4473, 1, 222, 42876.61f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4475, 34, 958, 35957.406f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4477, 62, 521, 76007.9f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4479, 86, 692, 50096.227f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4481, 87, 262, 82466.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4483, 88, 134, 46197.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4485, 13, 31, 3210.1052f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4487, 52, 431, 51411.594f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4489, 11, 478, 84789.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4491, 85, 249, 24493.459f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4493, 63, 86, 7677.495f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4495, 39, 316, 50048.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4497, 95, 77, 61878.156f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4499, 3, 915, 53144.832f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4501, 81, 188, 23333.107f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4503, 8, 652, 15164.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4505, 55, 644, 33030.71f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4507, 21, 98, 80759.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4509, 8, 925, 25823.303f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4511, 20, 755, 32596.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4513, 53, 611, 71882.65f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4515, 10, 342, 4389.6206f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4517, 6, 314, 49516.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4519, 30, 130, 59006.004f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4521, 9, 364, 87125.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4523, 56, 509, 16779.18f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4525, 13, 960, 26131.605f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4527, 50, 975, 78971.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4529, 88, 997, 19043.873f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4531, 47, 190, 42383.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4533, 18, 424, 12803.093f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4535, 4, 181, 83402.15f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4537, 58, 949, 85757.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4539, 31, 35, 24912.043f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4541, 49, 543, 50965.43f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4543, 71, 753, 49727.51f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4545, 11, 22, 85753.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4547, 66, 273, 40987.1f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4549, 49, 609, 70368.945f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4551, 75, 125, 38167.375f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4553, 46, 398, 65296.11f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4555, 4, 119, 50700.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4557, 17, 441, 77720.78f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4559, 43, 947, 34301.246f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4561, 95, 969, 9717.962f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4563, 15, 421, 64593.145f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4565, 23, 267, 30124.203f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4567, 24, 827, 31024.559f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4569, 85, 839, 12484.019f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4571, 10, 180, 23522.918f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4573, 41, 242, 25866.762f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4575, 10, 367, 68297.766f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4577, 43, 423, 71493.41f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4579, 40, 278, 36650.863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4581, 31, 929, 35277.656f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4583, 42, 126, 84728.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4585, 53, 669, 3633.4976f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4587, 49, 81, 70438.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4589, 18, 226, 35946.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4591, 64, 890, 82303.07f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4593, 9, 731, 58710f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4595, 99, 914, 15716.292f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4597, 95, 278, 89673.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4599, 3, 38, 68270.086f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4601, 86, 17, 38586.023f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4603, 90, 679, 36902.84f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4605, 64, 301, 15960.631f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4607, 66, 573, 11951.717f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4609, 39, 12, 31471.967f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4611, 54, 354, 88893.95f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4613, 35, 855, 24989.352f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4615, 73, 726, 37095.793f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4617, 53, 560, 15122.321f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4619, 17, 721, 83859.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4621, 71, 687, 46673.785f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4623, 17, 857, 24170.799f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4625, 40, 628, 36433.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4627, 26, 995, 52808.7f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4629, 57, 90, 16020.784f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4631, 42, 513, 38734.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4633, 74, 415, 7176.2075f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4635, 18, 84, 54627.668f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4637, 90, 71, 7325.098f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4639, 30, 70, 41282.688f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4641, 84, 121, 13125.563f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4643, 4, 458, 33720.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4645, 70, 986, 80425.72f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4647, 22, 224, 34072.055f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4649, 65, 625, 22993.916f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4651, 75, 377, 60081.785f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4653, 44, 369, 84055.73f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4655, 12, 733, 13535.472f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4657, 46, 57, 47917.293f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4659, 20, 144, 71204.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4661, 5, 855, 15301.972f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4663, 38, 404, 83374.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4665, 51, 244, 39838.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4667, 18, 311, 78790.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4669, 96, 126, 88605.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4671, 63, 580, 65421.543f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4673, 97, 858, 15272.244f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4675, 33, 11, 66802.625f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4677, 32, 576, 61246.035f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4679, 88, 523, 45005.938f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4681, 45, 957, 68666.96f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4683, 83, 431, 45277.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4685, 20, 352, 39583.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4687, 65, 768, 18465.049f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4689, 31, 706, 64282.168f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4691, 73, 596, 58022.582f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4693, 46, 781, 78240.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4695, 78, 719, 57756.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4697, 85, 845, 55854.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4699, 12, 714, 13613.793f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4701, 51, 186, 26339.652f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4703, 5, 45, 69727.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4705, 84, 842, 88636.484f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4707, 28, 79, 49728.29f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4709, 66, 501, 14790.663f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4711, 73, 288, 23040.62f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4713, 48, 370, 62786.58f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4715, 82, 474, 16064.31f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4717, 88, 886, 76565.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4719, 78, 982, 16182.823f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4721, 31, 227, 25394.535f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4723, 28, 400, 56603.516f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4725, 8, 919, 68135.06f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4727, 2, 993, 7251.412f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4729, 75, 554, 32610.404f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4731, 26, 436, 22083.936f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4733, 61, 832, 30247.234f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4735, 11, 670, 50334.914f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4737, 67, 651, 9249.687f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4739, 66, 265, 77978.17f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4741, 90, 426, 86000.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4743, 34, 432, 7836.258f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4745, 87, 723, 6083.6807f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4747, 98, 651, 72658.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4749, 84, 793, 44143.758f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4751, 71, 624, 34620.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4753, 99, 836, 61369f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4755, 83, 953, 45155.49f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4757, 33, 149, 5163.5273f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4759, 72, 580, 21225.521f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4761, 94, 52, 32304.352f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4763, 71, 442, 27834.05f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4765, 77, 901, 28096.598f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4767, 72, 254, 3590.126f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4769, 29, 886, 62585.082f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4771, 52, 92, 65014.047f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4773, 45, 254, 41329.887f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4775, 22, 850, 25772.525f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4777, 47, 103, 11771.946f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4779, 64, 720, 79577.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4781, 50, 786, 82762.42f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4783, 86, 186, 77820.984f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4785, 47, 450, 43451.496f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4787, 91, 900, 49177.824f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4789, 50, 259, 18578.559f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4791, 90, 505, 29557.807f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4793, 35, 907, 11071.659f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4795, 24, 353, 52993.223f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4797, 77, 870, 37563.973f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4799, 62, 679, 27007.646f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4801, 35, 5, 64061.734f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4803, 41, 61, 33241.164f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4805, 6, 114, 49514.043f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4807, 20, 925, 31758.018f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4809, 22, 63, 88274.99f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4811, 55, 274, 23025.518f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4813, 94, 963, 60745.47f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4815, 45, 478, 17137.154f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4817, 29, 767, 70622.88f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4819, 22, 393, 53755.195f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4821, 56, 914, 25733.738f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4823, 35, 806, 43103.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4825, 96, 989, 13964.253f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4827, 58, 411, 19627.717f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4829, 1, 207, 65457.535f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4831, 54, 332, 69966.78f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4833, 15, 531, 68315.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4835, 10, 120, 380.36942f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4837, 3, 728, 28604.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4839, 33, 784, 80121.26f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4841, 1, 96, 80370.21f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4843, 54, 569, 61806.508f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4845, 76, 264, 36821.812f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4847, 74, 732, 42909.895f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4849, 16, 995, 29842.03f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4851, 30, 407, 68572.54f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4853, 63, 873, 31249.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4855, 47, 727, 87391.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4857, 30, 811, 64150.64f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4859, 35, 727, 75790.016f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4861, 7, 540, 36022.707f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4863, 35, 184, 82510.6f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4865, 10, 771, 50257.87f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4867, 22, 379, 2450.4883f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4869, 8, 884, 48746.816f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4871, 39, 217, 33428.8f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4873, 36, 585, 43436.01f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4875, 73, 35, 10695.743f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4877, 1, 164, 24981.39f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4879, 69, 695, 83198.44f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4881, 48, 56, 6813.8257f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4883, 5, 464, 64469.16f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4885, 44, 431, 29542.719f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4887, 99, 331, 18274.04f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4889, 72, 841, 40238.105f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4891, 17, 8, 32839.04f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4893, 71, 549, 6112.8867f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4895, 1, 536, 23891.666f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4897, 60, 328, 7744.743f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4899, 14, 396, 71201.56f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4901, 47, 592, 26588.494f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4903, 85, 837, 45318.715f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4905, 59, 453, 19662.977f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4907, 89, 112, 9584.333f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4909, 34, 73, 47086.883f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4911, 49, 9, 69443.68f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4913, 77, 596, 34448.63f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4915, 26, 997, 7282.4863f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4917, 93, 658, 56032.367f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4919, 3, 548, 42628.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4921, 17, 861, 13163.748f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4923, 90, 868, 44239.242f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4925, 2, 724, 60844.97f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4927, 47, 484, 85929.36f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4929, 37, 209, 43483.465f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4931, 81, 272, 317.5255f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4933, 26, 468, 43031.83f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4935, 21, 309, 51951.504f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4937, 65, 764, 52772.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4939, 14, 289, 38535.586f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4941, 9, 273, 23822.22f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4943, 70, 135, 19146.98f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4945, 49, 101, 43427.48f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4947, 20, 186, 15335.534f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4949, 92, 177, 76558.45f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4951, 35, 758, 19695.408f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4953, 53, 866, 56556.76f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4955, 51, 39, 9334.248f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4957, 74, 414, 32621.855f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4959, 77, 969, 4032.443f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4961, 88, 975, 33280.117f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4963, 62, 26, 8423.445f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4965, 35, 265, 43262.13f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4967, 9, 895, 16249.633f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4969, 93, 759, 59147.67f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4971, 69, 412, 9897.296f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4973, 76, 677, 46388.074f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4975, 79, 228, 49226.27f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4977, 98, 46, 40630.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4979, 89, 267, 35406.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4981, 98, 339, 75346.555f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4983, 52, 843, 28928.305f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4985, 12, 398, 19099.113f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4987, 59, 194, 51807.418f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4989, 73, 218, 51758.844f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4991, 7, 665, 49767.52f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4993, 20, 517, 17139.477f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4995, 73, 818, 41130.19f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4997, 7, 22, 34959.906f });

            migrationBuilder.InsertData(
                table: "Wrote",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId", "RoyaltyRate" },
                values: new object[] { 4999, 65, 326, 32294.096f });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Isbn",
                table: "Book",
                column: "Isbn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Wrote_AuthorId_BookId",
                table: "Wrote",
                columns: new[] { "AuthorId", "BookId" });

            migrationBuilder.CreateIndex(
                name: "IX_Wrote_BookId",
                table: "Wrote",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wrote");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
