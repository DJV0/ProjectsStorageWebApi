using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projects.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2019, 8, 25, 18, 48, 6, 62, DateTimeKind.Local).AddTicks(3310), "Denesik - Greenfelder" },
                    { 8, new DateTime(2020, 10, 5, 4, 20, 14, 195, DateTimeKind.Local).AddTicks(3926), "Schiller Group" },
                    { 7, new DateTime(2016, 7, 17, 4, 34, 55, 91, DateTimeKind.Local).AddTicks(7082), "Parisian Group" },
                    { 6, new DateTime(2016, 10, 31, 8, 5, 15, 107, DateTimeKind.Local).AddTicks(6578), "Kutch - Roberts" },
                    { 5, new DateTime(2016, 10, 5, 10, 57, 2, 842, DateTimeKind.Local).AddTicks(7653), "Smitham Group" },
                    { 9, new DateTime(2018, 10, 19, 17, 54, 27, 554, DateTimeKind.Local).AddTicks(9549), "Littel, Turcotte and Muller" },
                    { 3, new DateTime(2018, 8, 28, 11, 18, 46, 416, DateTimeKind.Local).AddTicks(342), "Harris LLC" },
                    { 2, new DateTime(2019, 2, 21, 18, 47, 30, 379, DateTimeKind.Local).AddTicks(7852), "Kassulke LLC" },
                    { 1, new DateTime(2017, 3, 31, 5, 29, 28, 374, DateTimeKind.Local).AddTicks(504), "Durgan Group" },
                    { 4, new DateTime(2019, 4, 3, 12, 58, 33, 17, DateTimeKind.Local).AddTicks(8179), "Mitchell Inc" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 10, new DateTime(2009, 1, 21, 6, 44, 21, 87, DateTimeKind.Local).AddTicks(6712), "Lula_Reilly9@gmail.com", "Lula", "Reilly", new DateTime(2018, 10, 5, 12, 54, 40, 702, DateTimeKind.Local).AddTicks(247), null },
                    { 17, new DateTime(1992, 11, 25, 3, 50, 55, 27, DateTimeKind.Local).AddTicks(8567), "Omar_Cole@hotmail.com", "Omar", "Cole", new DateTime(2019, 7, 3, 14, 26, 16, 665, DateTimeKind.Local).AddTicks(6402), null },
                    { 16, new DateTime(1959, 3, 8, 14, 26, 7, 748, DateTimeKind.Local).AddTicks(1837), "Kathleen12@hotmail.com", "Kathleen", "Carter", new DateTime(2020, 1, 26, 5, 20, 26, 599, DateTimeKind.Local).AddTicks(2257), null },
                    { 15, new DateTime(2002, 3, 12, 1, 18, 9, 833, DateTimeKind.Local).AddTicks(2679), "Dominick.Kling73@hotmail.com", "Dominick", "Kling", new DateTime(2019, 5, 17, 18, 33, 0, 868, DateTimeKind.Local).AddTicks(9932), null },
                    { 14, new DateTime(1994, 1, 10, 7, 13, 23, 603, DateTimeKind.Local).AddTicks(9206), "Agnes_Gottlieb6@hotmail.com", "Agnes", "Gottlieb", new DateTime(2018, 10, 27, 6, 32, 42, 638, DateTimeKind.Local).AddTicks(5244), null },
                    { 13, new DateTime(1962, 1, 1, 6, 47, 11, 108, DateTimeKind.Local).AddTicks(1739), "Bobbie.Mante@hotmail.com", "Bobbie", "Mante", new DateTime(2021, 6, 22, 3, 26, 6, 844, DateTimeKind.Local).AddTicks(6591), null },
                    { 12, new DateTime(1973, 4, 16, 2, 33, 0, 669, DateTimeKind.Local).AddTicks(5329), "Eloise_DuBuque11@gmail.com", "Eloise", "DuBuque", new DateTime(2017, 12, 18, 3, 1, 27, 900, DateTimeKind.Local).AddTicks(4966), null },
                    { 11, new DateTime(1964, 12, 13, 17, 58, 53, 757, DateTimeKind.Local).AddTicks(970), "Emilio_Larson67@hotmail.com", "Emilio", "Larson", new DateTime(2017, 12, 4, 6, 8, 3, 143, DateTimeKind.Local).AddTicks(2358), null },
                    { 9, new DateTime(2016, 1, 2, 21, 44, 53, 683, DateTimeKind.Local).AddTicks(3985), "Jay70@yahoo.com", "Jay", "Haag", new DateTime(2017, 3, 12, 0, 56, 8, 656, DateTimeKind.Local).AddTicks(7705), null },
                    { 4, new DateTime(1965, 5, 26, 22, 27, 15, 225, DateTimeKind.Local).AddTicks(5076), "Elizabeth94@hotmail.com", "Elizabeth", "Koepp", new DateTime(2021, 6, 11, 22, 5, 36, 352, DateTimeKind.Local).AddTicks(3570), null },
                    { 7, new DateTime(2010, 6, 9, 0, 10, 5, 750, DateTimeKind.Local).AddTicks(3463), "Hugh_Nolan95@yahoo.com", "Hugh", "Nolan", new DateTime(2019, 1, 17, 23, 7, 12, 358, DateTimeKind.Local).AddTicks(1276), null },
                    { 6, new DateTime(2000, 2, 22, 7, 35, 15, 981, DateTimeKind.Local).AddTicks(6737), "Geraldine_Mann@gmail.com", "Geraldine", "Mann", new DateTime(2016, 8, 20, 17, 0, 1, 247, DateTimeKind.Local).AddTicks(3422), null },
                    { 5, new DateTime(2010, 12, 6, 0, 48, 7, 284, DateTimeKind.Local).AddTicks(6901), "Sadie15@yahoo.com", "Sadie", "Bernhard", new DateTime(2021, 4, 16, 0, 8, 32, 623, DateTimeKind.Local).AddTicks(9838), null },
                    { 18, new DateTime(1996, 8, 17, 19, 26, 34, 735, DateTimeKind.Local).AddTicks(726), "Hugh.Rippin2@hotmail.com", "Hugh", "Rippin", new DateTime(2018, 5, 8, 20, 21, 41, 918, DateTimeKind.Local).AddTicks(9355), null },
                    { 3, new DateTime(1963, 1, 27, 15, 3, 1, 83, DateTimeKind.Local).AddTicks(1205), "Jennifer37@hotmail.com", "Jennifer", "Haag", new DateTime(2019, 11, 14, 21, 1, 12, 835, DateTimeKind.Local).AddTicks(1980), null },
                    { 2, new DateTime(2005, 3, 7, 4, 42, 11, 466, DateTimeKind.Local).AddTicks(9734), "Erin.Pacocha14@hotmail.com", "Erin", "Pacocha", new DateTime(2020, 8, 14, 9, 1, 52, 692, DateTimeKind.Local).AddTicks(5066), null },
                    { 1, new DateTime(1987, 3, 12, 12, 11, 1, 353, DateTimeKind.Local).AddTicks(6142), "Anne.Collier@hotmail.com", "Anne", "Collier", new DateTime(2020, 4, 24, 6, 13, 17, 101, DateTimeKind.Local).AddTicks(2910), null },
                    { 123, new DateTime(1981, 7, 19, 12, 21, 52, 629, DateTimeKind.Local).AddTicks(1502), "Marcos.Stamm70@hotmail.com", "Marcos", "Stamm", new DateTime(2019, 1, 18, 7, 18, 32, 595, DateTimeKind.Local).AddTicks(2402), null },
                    { 8, new DateTime(1982, 12, 21, 3, 36, 19, 758, DateTimeKind.Local).AddTicks(4357), "Veronica_Cronin@gmail.com", "Veronica", "Cronin", new DateTime(2019, 11, 28, 0, 24, 1, 667, DateTimeKind.Local).AddTicks(1222), null },
                    { 19, new DateTime(1968, 7, 17, 4, 25, 35, 210, DateTimeKind.Local).AddTicks(7830), "Howard89@yahoo.com", "Howard", "Ankunding", new DateTime(2018, 10, 13, 3, 0, 9, 310, DateTimeKind.Local).AddTicks(9532), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 20, new DateTime(1953, 12, 23, 5, 31, 55, 625, DateTimeKind.Local).AddTicks(1180), "Vivian99@yahoo.com", "Vivian", "Mertz", new DateTime(2018, 10, 19, 1, 37, 40, 756, DateTimeKind.Local).AddTicks(2662), 10 },
                    { 94, new DateTime(1993, 3, 28, 8, 1, 22, 960, DateTimeKind.Local).AddTicks(6430), "Erma6@yahoo.com", "Erma", "Lindgren", new DateTime(2018, 7, 8, 10, 34, 56, 220, DateTimeKind.Local).AddTicks(178), 7 },
                    { 93, new DateTime(1995, 10, 1, 20, 23, 59, 256, DateTimeKind.Local).AddTicks(2970), "Edith68@yahoo.com", "Edith", "Spinka", new DateTime(2019, 3, 16, 2, 47, 5, 779, DateTimeKind.Local).AddTicks(1730), 7 },
                    { 92, new DateTime(2000, 6, 30, 21, 41, 42, 401, DateTimeKind.Local).AddTicks(7060), "Tricia.Buckridge@hotmail.com", "Tricia", "Buckridge", new DateTime(2019, 11, 13, 0, 55, 18, 31, DateTimeKind.Local).AddTicks(8373), 7 },
                    { 91, new DateTime(2006, 8, 18, 8, 5, 57, 102, DateTimeKind.Local).AddTicks(2215), "Kellie.Graham@gmail.com", "Kellie", "Graham", new DateTime(2017, 5, 6, 3, 53, 37, 218, DateTimeKind.Local).AddTicks(4006), 7 },
                    { 90, new DateTime(1958, 2, 23, 8, 15, 10, 687, DateTimeKind.Local).AddTicks(1664), "Eloise_Conn@gmail.com", "Eloise", "Conn", new DateTime(2020, 11, 5, 22, 27, 2, 3, DateTimeKind.Local).AddTicks(6446), 7 },
                    { 89, new DateTime(1993, 5, 2, 22, 41, 35, 741, DateTimeKind.Local).AddTicks(9746), "Hugo_Haag7@hotmail.com", "Hugo", "Haag", new DateTime(2018, 5, 30, 21, 12, 20, 418, DateTimeKind.Local).AddTicks(9273), 7 },
                    { 88, new DateTime(2005, 6, 8, 12, 9, 38, 231, DateTimeKind.Local).AddTicks(2402), "Hubert_Kshlerin10@gmail.com", "Hubert", "Kshlerin", new DateTime(2019, 6, 4, 20, 50, 30, 57, DateTimeKind.Local).AddTicks(2265), 7 },
                    { 87, new DateTime(1993, 9, 10, 8, 15, 5, 335, DateTimeKind.Local).AddTicks(4909), "Henrietta14@gmail.com", "Henrietta", "Durgan", new DateTime(2020, 8, 1, 20, 37, 21, 50, DateTimeKind.Local).AddTicks(2033), 7 },
                    { 86, new DateTime(1984, 12, 7, 4, 6, 38, 180, DateTimeKind.Local).AddTicks(3491), "Johnnie_Morar@hotmail.com", "Johnnie", "Morar", new DateTime(2017, 12, 28, 23, 38, 56, 372, DateTimeKind.Local).AddTicks(6730), 7 },
                    { 85, new DateTime(1956, 10, 29, 13, 40, 16, 78, DateTimeKind.Local).AddTicks(7280), "Adrian28@gmail.com", "Adrian", "Schumm", new DateTime(2017, 7, 17, 15, 39, 41, 248, DateTimeKind.Local).AddTicks(761), 7 },
                    { 95, new DateTime(1996, 11, 1, 11, 57, 52, 29, DateTimeKind.Local).AddTicks(9757), "Jordan50@yahoo.com", "Jordan", "Ebert", new DateTime(2019, 5, 31, 19, 33, 47, 123, DateTimeKind.Local).AddTicks(6178), 7 },
                    { 84, new DateTime(1983, 9, 28, 6, 23, 13, 371, DateTimeKind.Local).AddTicks(7168), "Cedric_Schulist@gmail.com", "Cedric", "Schulist", new DateTime(2020, 1, 25, 23, 34, 39, 397, DateTimeKind.Local).AddTicks(8003), 7 },
                    { 82, new DateTime(1993, 5, 16, 10, 54, 36, 888, DateTimeKind.Local).AddTicks(9014), "Phillip_Jast63@hotmail.com", "Phillip", "Jast", new DateTime(2019, 10, 5, 17, 41, 33, 39, DateTimeKind.Local).AddTicks(269), 6 },
                    { 81, new DateTime(2012, 10, 17, 4, 32, 36, 204, DateTimeKind.Local).AddTicks(923), "Leslie.Kub11@gmail.com", "Leslie", "Kub", new DateTime(2018, 1, 14, 17, 3, 15, 548, DateTimeKind.Local).AddTicks(2193), 6 },
                    { 80, new DateTime(1977, 3, 26, 16, 45, 38, 693, DateTimeKind.Local).AddTicks(9773), "Steve.Schamberger@gmail.com", "Steve", "Schamberger", new DateTime(2020, 6, 20, 18, 48, 49, 930, DateTimeKind.Local).AddTicks(8181), 6 },
                    { 79, new DateTime(1997, 2, 11, 18, 29, 32, 385, DateTimeKind.Local).AddTicks(9620), "Darrel65@hotmail.com", "Darrel", "Bosco", new DateTime(2018, 3, 29, 21, 0, 0, 694, DateTimeKind.Local).AddTicks(9134), 6 },
                    { 78, new DateTime(2016, 5, 14, 9, 44, 20, 83, DateTimeKind.Local).AddTicks(2492), "Nathaniel_Jast@hotmail.com", "Nathaniel", "Jast", new DateTime(2016, 12, 17, 14, 36, 45, 469, DateTimeKind.Local).AddTicks(8460), 5 },
                    { 77, new DateTime(1954, 4, 27, 1, 34, 44, 682, DateTimeKind.Local).AddTicks(3812), "Kim.Hermann18@hotmail.com", "Kim", "Hermann", new DateTime(2021, 3, 7, 13, 9, 24, 309, DateTimeKind.Local).AddTicks(9500), 5 },
                    { 76, new DateTime(1978, 4, 28, 20, 29, 44, 66, DateTimeKind.Local).AddTicks(5115), "Maxine.Hoeger88@hotmail.com", "Maxine", "Hoeger", new DateTime(2019, 5, 10, 20, 6, 5, 366, DateTimeKind.Local).AddTicks(4920), 4 },
                    { 75, new DateTime(1994, 7, 9, 6, 11, 59, 433, DateTimeKind.Local).AddTicks(9644), "Guadalupe_Willms95@yahoo.com", "Guadalupe", "Willms", new DateTime(2018, 12, 13, 20, 26, 1, 676, DateTimeKind.Local).AddTicks(8983), 4 },
                    { 74, new DateTime(1958, 5, 25, 21, 41, 37, 196, DateTimeKind.Local).AddTicks(7743), "Sherry_Stamm@hotmail.com", "Sherry", "Stamm", new DateTime(2019, 12, 26, 22, 12, 17, 619, DateTimeKind.Local).AddTicks(1299), 4 },
                    { 73, new DateTime(1965, 10, 21, 5, 50, 34, 873, DateTimeKind.Local).AddTicks(4456), "Joshua67@gmail.com", "Joshua", "Brekke", new DateTime(2020, 1, 4, 20, 50, 58, 939, DateTimeKind.Local).AddTicks(9965), 4 },
                    { 83, new DateTime(1965, 1, 30, 2, 28, 46, 371, DateTimeKind.Local).AddTicks(9704), "Terrence_Feil@yahoo.com", "Terrence", "Feil", new DateTime(2017, 7, 26, 10, 29, 48, 725, DateTimeKind.Local).AddTicks(6737), 6 },
                    { 72, new DateTime(2015, 1, 1, 1, 41, 16, 977, DateTimeKind.Local).AddTicks(4806), "Stanley.Lang92@yahoo.com", "Stanley", "Lang", new DateTime(2018, 6, 17, 20, 19, 12, 360, DateTimeKind.Local).AddTicks(3431), 4 },
                    { 96, new DateTime(1980, 7, 2, 13, 22, 41, 322, DateTimeKind.Local).AddTicks(9778), "Rebecca53@gmail.com", "Rebecca", "Reynolds", new DateTime(2020, 9, 5, 14, 42, 16, 45, DateTimeKind.Local).AddTicks(7335), 7 },
                    { 98, new DateTime(1983, 10, 12, 4, 2, 1, 910, DateTimeKind.Local).AddTicks(3128), "Kristin_Harvey@hotmail.com", "Kristin", "Harvey", new DateTime(2016, 12, 17, 8, 42, 10, 244, DateTimeKind.Local).AddTicks(7694), 7 },
                    { 120, new DateTime(1986, 11, 12, 18, 3, 24, 890, DateTimeKind.Local).AddTicks(4951), "Cathy.Ernser74@yahoo.com", "Cathy", "Ernser", new DateTime(2019, 12, 12, 11, 7, 41, 862, DateTimeKind.Local).AddTicks(5101), 9 },
                    { 119, new DateTime(1963, 7, 31, 19, 2, 58, 36, DateTimeKind.Local).AddTicks(8395), "Kenneth12@hotmail.com", "Kenneth", "Bergnaum", new DateTime(2017, 3, 24, 21, 25, 54, 86, DateTimeKind.Local).AddTicks(2325), 9 },
                    { 118, new DateTime(1978, 12, 31, 1, 35, 24, 784, DateTimeKind.Local).AddTicks(2622), "Otis.OConnell41@hotmail.com", "Otis", "O'Connell", new DateTime(2021, 3, 30, 4, 11, 27, 91, DateTimeKind.Local).AddTicks(8850), 9 },
                    { 117, new DateTime(1971, 11, 8, 23, 39, 38, 451, DateTimeKind.Local).AddTicks(2451), "Zachary10@gmail.com", "Zachary", "Mayert", new DateTime(2019, 12, 23, 5, 2, 10, 771, DateTimeKind.Local).AddTicks(5539), 9 },
                    { 116, new DateTime(1987, 12, 2, 11, 30, 54, 809, DateTimeKind.Local).AddTicks(7190), "Domingo.Yundt97@hotmail.com", "Domingo", "Yundt", new DateTime(2018, 10, 7, 20, 4, 50, 786, DateTimeKind.Local).AddTicks(7959), 9 },
                    { 115, new DateTime(1993, 10, 11, 12, 13, 6, 11, DateTimeKind.Local).AddTicks(6355), "Donald_Beier@hotmail.com", "Donald", "Beier", new DateTime(2019, 9, 22, 9, 12, 6, 489, DateTimeKind.Local).AddTicks(4323), 9 },
                    { 114, new DateTime(1976, 1, 11, 6, 42, 27, 473, DateTimeKind.Local).AddTicks(629), "Nina4@yahoo.com", "Nina", "Braun", new DateTime(2016, 8, 25, 19, 7, 7, 846, DateTimeKind.Local).AddTicks(1860), 9 },
                    { 113, new DateTime(1969, 7, 24, 8, 48, 40, 740, DateTimeKind.Local).AddTicks(6598), "Natasha.Orn@gmail.com", "Natasha", "Orn", new DateTime(2017, 10, 29, 23, 34, 50, 864, DateTimeKind.Local).AddTicks(4270), 9 },
                    { 112, new DateTime(1956, 1, 20, 2, 14, 13, 361, DateTimeKind.Local).AddTicks(7325), "Roy83@yahoo.com", "Roy", "Lebsack", new DateTime(2019, 11, 15, 7, 11, 58, 517, DateTimeKind.Local).AddTicks(636), 8 },
                    { 111, new DateTime(1953, 5, 13, 3, 46, 32, 220, DateTimeKind.Local).AddTicks(5672), "Rachel.Schneider@hotmail.com", "Rachel", "Schneider", new DateTime(2021, 6, 4, 12, 5, 22, 884, DateTimeKind.Local).AddTicks(5380), 8 },
                    { 97, new DateTime(2006, 7, 29, 13, 51, 9, 637, DateTimeKind.Local).AddTicks(9634), "Gerald.Emmerich@hotmail.com", "Gerald", "Emmerich", new DateTime(2019, 12, 1, 2, 4, 41, 690, DateTimeKind.Local).AddTicks(6599), 7 },
                    { 110, new DateTime(1965, 4, 3, 9, 23, 3, 351, DateTimeKind.Local).AddTicks(3225), "Abraham31@yahoo.com", "Abraham", "White", new DateTime(2018, 6, 14, 11, 31, 5, 496, DateTimeKind.Local).AddTicks(2897), 8 },
                    { 108, new DateTime(2003, 11, 18, 11, 2, 47, 897, DateTimeKind.Local).AddTicks(10), "Marilyn_OHara77@hotmail.com", "Marilyn", "O'Hara", new DateTime(2021, 4, 28, 9, 31, 48, 98, DateTimeKind.Local).AddTicks(2897), 8 },
                    { 107, new DateTime(2007, 10, 12, 22, 43, 57, 858, DateTimeKind.Local).AddTicks(6210), "Aubrey.Luettgen48@hotmail.com", "Aubrey", "Luettgen", new DateTime(2016, 10, 12, 3, 51, 55, 42, DateTimeKind.Local).AddTicks(8877), 8 },
                    { 106, new DateTime(2011, 5, 18, 16, 46, 36, 243, DateTimeKind.Local).AddTicks(7239), "Gregory.Corwin58@gmail.com", "Gregory", "Corwin", new DateTime(2018, 3, 16, 19, 40, 54, 694, DateTimeKind.Local).AddTicks(3735), 8 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 105, new DateTime(1977, 12, 10, 16, 37, 47, 375, DateTimeKind.Local).AddTicks(6041), "Carol_Larson62@gmail.com", "Carol", "Larson", new DateTime(2019, 6, 21, 8, 59, 19, 547, DateTimeKind.Local).AddTicks(3273), 8 },
                    { 104, new DateTime(1952, 12, 14, 8, 20, 26, 670, DateTimeKind.Local).AddTicks(9768), "Janice_Brekke@hotmail.com", "Janice", "Brekke", new DateTime(2019, 6, 6, 4, 4, 37, 107, DateTimeKind.Local).AddTicks(6381), 8 },
                    { 103, new DateTime(1989, 12, 18, 7, 25, 8, 861, DateTimeKind.Local).AddTicks(1911), "Jared34@gmail.com", "Jared", "Pollich", new DateTime(2020, 6, 6, 15, 56, 11, 72, DateTimeKind.Local).AddTicks(9258), 8 },
                    { 102, new DateTime(1959, 9, 6, 2, 16, 51, 675, DateTimeKind.Local).AddTicks(8099), "Noah.Goyette@gmail.com", "Noah", "Goyette", new DateTime(2018, 9, 6, 1, 27, 5, 890, DateTimeKind.Local).AddTicks(8668), 8 },
                    { 101, new DateTime(1980, 5, 31, 19, 3, 37, 842, DateTimeKind.Local).AddTicks(6622), "Roland.Fadel@yahoo.com", "Roland", "Fadel", new DateTime(2019, 9, 13, 5, 54, 24, 609, DateTimeKind.Local).AddTicks(3134), 7 },
                    { 100, new DateTime(2007, 10, 14, 15, 9, 13, 415, DateTimeKind.Local).AddTicks(2130), "Clayton82@gmail.com", "Clayton", "Pfannerstill", new DateTime(2017, 12, 12, 14, 24, 53, 674, DateTimeKind.Local).AddTicks(2868), 7 },
                    { 99, new DateTime(2014, 3, 7, 6, 51, 25, 818, DateTimeKind.Local).AddTicks(4223), "Johnnie32@hotmail.com", "Johnnie", "Wuckert", new DateTime(2020, 2, 15, 23, 48, 35, 879, DateTimeKind.Local).AddTicks(9264), 7 },
                    { 109, new DateTime(1958, 11, 23, 20, 20, 25, 453, DateTimeKind.Local).AddTicks(6110), "Gary.Jones@hotmail.com", "Gary", "Jones", new DateTime(2020, 12, 27, 22, 0, 14, 24, DateTimeKind.Local).AddTicks(3114), 8 },
                    { 121, new DateTime(1959, 2, 10, 15, 25, 28, 464, DateTimeKind.Local).AddTicks(6129), "Kendra97@hotmail.com", "Kendra", "Hand", new DateTime(2017, 12, 29, 3, 31, 22, 739, DateTimeKind.Local).AddTicks(2771), 9 },
                    { 71, new DateTime(1951, 8, 11, 8, 56, 57, 131, DateTimeKind.Local).AddTicks(7749), "Wayne57@hotmail.com", "Wayne", "Balistreri", new DateTime(2019, 1, 24, 22, 49, 9, 597, DateTimeKind.Local).AddTicks(1016), 4 },
                    { 69, new DateTime(1983, 10, 16, 14, 46, 41, 111, DateTimeKind.Local).AddTicks(7473), "Velma_Daniel31@gmail.com", "Velma", "Daniel", new DateTime(2019, 10, 25, 6, 29, 14, 770, DateTimeKind.Local).AddTicks(6539), 4 },
                    { 42, new DateTime(1959, 12, 10, 9, 49, 27, 657, DateTimeKind.Local).AddTicks(3470), "Gail92@hotmail.com", "Gail", "Kuhlman", new DateTime(2018, 3, 9, 22, 50, 49, 326, DateTimeKind.Local).AddTicks(9783), 1 },
                    { 41, new DateTime(1978, 8, 31, 5, 24, 17, 178, DateTimeKind.Local).AddTicks(1745), "Francis_Bode@gmail.com", "Francis", "Bode", new DateTime(2018, 9, 17, 2, 33, 33, 113, DateTimeKind.Local).AddTicks(2650), 1 },
                    { 40, new DateTime(1997, 4, 13, 16, 59, 17, 300, DateTimeKind.Local).AddTicks(3976), "Regina.Swaniawski95@gmail.com", "Regina", "Swaniawski", new DateTime(2018, 12, 30, 22, 31, 54, 142, DateTimeKind.Local).AddTicks(2198), 1 },
                    { 39, new DateTime(1965, 10, 25, 8, 43, 35, 823, DateTimeKind.Local).AddTicks(3300), "Jared_Reichert@gmail.com", "Jared", "Reichert", new DateTime(2019, 6, 16, 6, 24, 19, 779, DateTimeKind.Local).AddTicks(2006), 1 },
                    { 38, new DateTime(1981, 6, 23, 12, 22, 10, 437, DateTimeKind.Local).AddTicks(8304), "Bonnie.Donnelly4@hotmail.com", "Bonnie", "Donnelly", new DateTime(2021, 1, 31, 0, 19, 51, 635, DateTimeKind.Local).AddTicks(6560), 1 },
                    { 37, new DateTime(2014, 1, 15, 1, 13, 26, 25, DateTimeKind.Local).AddTicks(9005), "Jared_Anderson50@yahoo.com", "Jared", "Anderson", new DateTime(2017, 7, 31, 4, 55, 48, 675, DateTimeKind.Local).AddTicks(9553), 1 },
                    { 36, new DateTime(2015, 7, 7, 11, 27, 52, 307, DateTimeKind.Local).AddTicks(313), "Traci38@yahoo.com", "Traci", "Wunsch", new DateTime(2019, 9, 16, 12, 21, 35, 997, DateTimeKind.Local).AddTicks(6958), 1 },
                    { 35, new DateTime(1970, 8, 22, 23, 31, 46, 782, DateTimeKind.Local).AddTicks(7196), "Angelo.Homenick@hotmail.com", "Angelo", "Homenick", new DateTime(2017, 9, 19, 13, 24, 45, 825, DateTimeKind.Local).AddTicks(8661), 10 },
                    { 34, new DateTime(1990, 9, 5, 0, 20, 1, 446, DateTimeKind.Local).AddTicks(7559), "Kurt39@gmail.com", "Kurt", "Bahringer", new DateTime(2019, 1, 19, 5, 7, 6, 586, DateTimeKind.Local).AddTicks(4758), 10 },
                    { 33, new DateTime(1974, 8, 13, 2, 43, 3, 840, DateTimeKind.Local).AddTicks(5988), "Latoya53@gmail.com", "Latoya", "Bernhard", new DateTime(2019, 7, 9, 22, 50, 57, 715, DateTimeKind.Local).AddTicks(7167), 10 },
                    { 43, new DateTime(1967, 9, 9, 19, 39, 22, 179, DateTimeKind.Local).AddTicks(3752), "Ruth.Towne58@hotmail.com", "Ruth", "Towne", new DateTime(2019, 3, 24, 18, 19, 54, 92, DateTimeKind.Local).AddTicks(5316), 1 },
                    { 32, new DateTime(1997, 8, 1, 13, 17, 18, 266, DateTimeKind.Local).AddTicks(3990), "Cody_Morissette@hotmail.com", "Cody", "Morissette", new DateTime(2021, 6, 18, 20, 42, 9, 184, DateTimeKind.Local).AddTicks(1517), 10 },
                    { 30, new DateTime(1961, 9, 11, 9, 38, 14, 838, DateTimeKind.Local).AddTicks(2487), "Felicia.Kirlin74@yahoo.com", "Felicia", "Kirlin", new DateTime(2020, 12, 5, 23, 40, 46, 113, DateTimeKind.Local).AddTicks(3753), 10 },
                    { 29, new DateTime(1994, 5, 9, 12, 53, 45, 921, DateTimeKind.Local).AddTicks(8955), "Micheal71@hotmail.com", "Micheal", "Franecki", new DateTime(2020, 7, 6, 22, 33, 41, 938, DateTimeKind.Local).AddTicks(340), 10 },
                    { 28, new DateTime(1963, 9, 19, 21, 24, 20, 711, DateTimeKind.Local).AddTicks(674), "Lori_Vandervort@hotmail.com", "Lori", "Vandervort", new DateTime(2018, 9, 1, 1, 41, 7, 688, DateTimeKind.Local).AddTicks(8922), 10 },
                    { 27, new DateTime(1981, 1, 10, 14, 38, 30, 529, DateTimeKind.Local).AddTicks(222), "Christie.Gusikowski@hotmail.com", "Christie", "Gusikowski", new DateTime(2019, 10, 7, 10, 41, 43, 246, DateTimeKind.Local).AddTicks(699), 10 },
                    { 26, new DateTime(1962, 2, 26, 11, 8, 59, 71, DateTimeKind.Local).AddTicks(1820), "Ann.Langworth@hotmail.com", "Ann", "Langworth", new DateTime(2017, 8, 9, 8, 47, 42, 369, DateTimeKind.Local).AddTicks(9036), 10 },
                    { 25, new DateTime(2009, 5, 12, 6, 9, 16, 237, DateTimeKind.Local).AddTicks(3321), "Joanna25@hotmail.com", "Joanna", "Botsford", new DateTime(2019, 5, 14, 21, 2, 44, 99, DateTimeKind.Local).AddTicks(5821), 10 },
                    { 24, new DateTime(1954, 4, 9, 9, 4, 50, 470, DateTimeKind.Local).AddTicks(9098), "Alfredo_Simonis@yahoo.com", "Alfredo", "Simonis", new DateTime(2019, 10, 14, 19, 40, 52, 277, DateTimeKind.Local).AddTicks(2028), 10 },
                    { 23, new DateTime(1980, 2, 20, 19, 32, 12, 635, DateTimeKind.Local).AddTicks(8667), "Theresa82@hotmail.com", "Theresa", "Ebert", new DateTime(2017, 5, 14, 5, 37, 44, 448, DateTimeKind.Local).AddTicks(6766), 10 },
                    { 22, new DateTime(2007, 1, 1, 8, 10, 18, 898, DateTimeKind.Local).AddTicks(8690), "Brandy.Witting@gmail.com", "Brandy", "Witting", new DateTime(2019, 1, 10, 5, 51, 56, 714, DateTimeKind.Local).AddTicks(8896), 10 },
                    { 21, new DateTime(1992, 9, 28, 0, 27, 3, 523, DateTimeKind.Local).AddTicks(6015), "Theresa_Gottlieb66@yahoo.com", "Theresa", "Gottlieb", new DateTime(2019, 12, 4, 19, 52, 4, 372, DateTimeKind.Local).AddTicks(7619), 10 },
                    { 31, new DateTime(1979, 7, 21, 14, 29, 24, 231, DateTimeKind.Local).AddTicks(1143), "Kelvin.Gleichner70@yahoo.com", "Kelvin", "Gleichner", new DateTime(2020, 5, 12, 6, 13, 21, 282, DateTimeKind.Local).AddTicks(1256), 10 },
                    { 70, new DateTime(1958, 1, 22, 1, 39, 4, 564, DateTimeKind.Local).AddTicks(346), "Arturo_Howell3@gmail.com", "Arturo", "Howell", new DateTime(2019, 6, 2, 4, 39, 53, 488, DateTimeKind.Local).AddTicks(582), 4 },
                    { 44, new DateTime(2002, 12, 10, 8, 8, 46, 690, DateTimeKind.Local).AddTicks(7795), "Alfredo_Bosco74@hotmail.com", "Alfredo", "Bosco", new DateTime(2019, 9, 12, 5, 53, 33, 380, DateTimeKind.Local).AddTicks(3685), 1 },
                    { 46, new DateTime(2013, 7, 4, 15, 47, 56, 171, DateTimeKind.Local).AddTicks(6888), "Donnie.Kemmer@hotmail.com", "Donnie", "Kemmer", new DateTime(2020, 5, 28, 14, 0, 37, 181, DateTimeKind.Local).AddTicks(4147), 1 },
                    { 68, new DateTime(2008, 1, 28, 4, 50, 59, 585, DateTimeKind.Local).AddTicks(2294), "Lucia_Mraz@hotmail.com", "Lucia", "Mraz", new DateTime(2019, 4, 9, 10, 38, 52, 923, DateTimeKind.Local).AddTicks(1187), 4 },
                    { 67, new DateTime(1986, 8, 3, 17, 31, 36, 155, DateTimeKind.Local).AddTicks(1871), "Darrell_Beier71@gmail.com", "Darrell", "Beier", new DateTime(2019, 1, 13, 19, 54, 23, 644, DateTimeKind.Local).AddTicks(9812), 3 },
                    { 66, new DateTime(1961, 3, 18, 10, 16, 52, 612, DateTimeKind.Local).AddTicks(7570), "Jana.Walter12@yahoo.com", "Jana", "Walter", new DateTime(2019, 10, 26, 11, 51, 16, 983, DateTimeKind.Local).AddTicks(832), 3 },
                    { 65, new DateTime(2013, 6, 10, 15, 26, 40, 924, DateTimeKind.Local).AddTicks(7392), "Linda_Nicolas@hotmail.com", "Linda", "Nicolas", new DateTime(2021, 3, 27, 2, 8, 20, 525, DateTimeKind.Local).AddTicks(962), 3 },
                    { 64, new DateTime(1991, 2, 22, 21, 4, 10, 383, DateTimeKind.Local).AddTicks(5514), "Elias_Jacobi@gmail.com", "Elias", "Jacobi", new DateTime(2017, 1, 25, 5, 21, 43, 146, DateTimeKind.Local).AddTicks(2865), 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 63, new DateTime(1973, 6, 24, 6, 21, 54, 392, DateTimeKind.Local).AddTicks(2787), "Monica24@hotmail.com", "Monica", "Rodriguez", new DateTime(2017, 9, 21, 8, 15, 29, 647, DateTimeKind.Local).AddTicks(8821), 3 },
                    { 62, new DateTime(1966, 7, 20, 20, 9, 45, 687, DateTimeKind.Local).AddTicks(7503), "Lynda_Grant85@hotmail.com", "Lynda", "Grant", new DateTime(2021, 6, 10, 16, 8, 42, 871, DateTimeKind.Local).AddTicks(9538), 3 },
                    { 61, new DateTime(1989, 3, 23, 6, 9, 17, 785, DateTimeKind.Local).AddTicks(3449), "Virgil_Hauck@hotmail.com", "Virgil", "Hauck", new DateTime(2021, 5, 13, 11, 24, 18, 12, DateTimeKind.Local).AddTicks(9537), 2 },
                    { 60, new DateTime(1995, 6, 21, 21, 36, 22, 445, DateTimeKind.Local).AddTicks(9621), "Tara.Morar@gmail.com", "Tara", "Morar", new DateTime(2019, 11, 11, 23, 17, 11, 718, DateTimeKind.Local).AddTicks(3127), 2 },
                    { 59, new DateTime(1982, 7, 16, 6, 30, 2, 312, DateTimeKind.Local).AddTicks(1231), "Heidi_Boehm55@gmail.com", "Heidi", "Boehm", new DateTime(2018, 6, 7, 9, 9, 38, 325, DateTimeKind.Local).AddTicks(9580), 2 },
                    { 45, new DateTime(1951, 10, 2, 8, 4, 59, 56, DateTimeKind.Local).AddTicks(1607), "Raymond_Reilly63@gmail.com", "Raymond", "Reilly", new DateTime(2018, 6, 16, 7, 30, 6, 181, DateTimeKind.Local).AddTicks(9252), 1 },
                    { 58, new DateTime(1955, 1, 24, 3, 17, 45, 848, DateTimeKind.Local).AddTicks(7390), "Laura_Jacobson20@hotmail.com", "Laura", "Jacobson", new DateTime(2019, 7, 8, 10, 50, 11, 246, DateTimeKind.Local).AddTicks(3550), 2 },
                    { 56, new DateTime(2005, 10, 19, 4, 22, 26, 834, DateTimeKind.Local).AddTicks(2335), "Faith9@hotmail.com", "Faith", "Gaylord", new DateTime(2018, 7, 22, 21, 43, 27, 130, DateTimeKind.Local).AddTicks(1853), 2 },
                    { 55, new DateTime(2015, 6, 1, 1, 59, 3, 373, DateTimeKind.Local).AddTicks(9277), "Jay.Bashirian37@hotmail.com", "Jay", "Bashirian", new DateTime(2018, 1, 23, 19, 6, 30, 767, DateTimeKind.Local).AddTicks(9633), 2 },
                    { 54, new DateTime(1980, 5, 17, 15, 25, 45, 365, DateTimeKind.Local).AddTicks(4839), "Tammy.Sawayn@hotmail.com", "Tammy", "Sawayn", new DateTime(2019, 11, 16, 12, 3, 21, 500, DateTimeKind.Local).AddTicks(7796), 2 },
                    { 53, new DateTime(1956, 9, 10, 18, 33, 58, 385, DateTimeKind.Local).AddTicks(454), "Terrance1@gmail.com", "Terrance", "Yundt", new DateTime(2019, 11, 13, 1, 36, 19, 996, DateTimeKind.Local).AddTicks(5370), 2 },
                    { 52, new DateTime(1960, 9, 15, 14, 26, 58, 871, DateTimeKind.Local).AddTicks(9793), "Ethel.Berge5@gmail.com", "Ethel", "Berge", new DateTime(2017, 10, 24, 2, 56, 45, 831, DateTimeKind.Local).AddTicks(1970), 2 },
                    { 51, new DateTime(1991, 12, 28, 18, 6, 8, 206, DateTimeKind.Local).AddTicks(6741), "Arnold_Kuhn3@yahoo.com", "Arnold", "Kuhn", new DateTime(2019, 4, 16, 18, 40, 5, 549, DateTimeKind.Local).AddTicks(9205), 2 },
                    { 50, new DateTime(1978, 12, 26, 9, 5, 21, 202, DateTimeKind.Local).AddTicks(9844), "Cecelia_Purdy27@hotmail.com", "Cecelia", "Purdy", new DateTime(2019, 12, 22, 14, 50, 48, 649, DateTimeKind.Local).AddTicks(2489), 1 },
                    { 49, new DateTime(1976, 11, 14, 3, 11, 37, 371, DateTimeKind.Local).AddTicks(9932), "Kerry.Smith8@yahoo.com", "Kerry", "Smith", new DateTime(2020, 10, 5, 22, 31, 18, 566, DateTimeKind.Local).AddTicks(893), 1 },
                    { 48, new DateTime(1962, 9, 5, 20, 44, 4, 241, DateTimeKind.Local).AddTicks(9398), "Deanna75@hotmail.com", "Deanna", "Hodkiewicz", new DateTime(2021, 4, 21, 20, 11, 48, 576, DateTimeKind.Local).AddTicks(6282), 1 },
                    { 47, new DateTime(1979, 11, 15, 6, 28, 59, 575, DateTimeKind.Local).AddTicks(3379), "Carmen62@hotmail.com", "Carmen", "Rowe", new DateTime(2019, 3, 4, 5, 41, 1, 521, DateTimeKind.Local).AddTicks(8276), 1 },
                    { 57, new DateTime(2008, 10, 7, 20, 58, 56, 996, DateTimeKind.Local).AddTicks(5510), "Samuel_Pouros39@hotmail.com", "Samuel", "Pouros", new DateTime(2020, 3, 15, 3, 1, 7, 633, DateTimeKind.Local).AddTicks(6612), 2 },
                    { 122, new DateTime(1978, 8, 23, 16, 22, 23, 552, DateTimeKind.Local).AddTicks(4873), "Sophia.Corwin18@hotmail.com", "Sophia", "Corwin", new DateTime(2018, 6, 14, 17, 11, 50, 268, DateTimeKind.Local).AddTicks(4324), 9 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, 22, new DateTime(2020, 8, 25, 20, 49, 50, 451, DateTimeKind.Local).AddTicks(8054), new DateTime(2021, 9, 12, 22, 17, 47, 233, DateTimeKind.Local).AddTicks(5223), "Et doloribus et temporibus.", "backing up Handcrafted Fresh Shoes challenge", 10 },
                    { 60, 92, new DateTime(2020, 4, 28, 5, 15, 52, 959, DateTimeKind.Local).AddTicks(5246), new DateTime(2021, 12, 11, 0, 33, 22, 144, DateTimeKind.Local).AddTicks(6380), "Architecto qui ut aut neque.", "deposit radical Proactive", 7 },
                    { 75, 91, new DateTime(2020, 7, 2, 11, 57, 3, 35, DateTimeKind.Local).AddTicks(417), new DateTime(2021, 9, 18, 9, 28, 2, 280, DateTimeKind.Local).AddTicks(3136), "Perferendis asperiores consectetur cumque rem beatae quibusdam non ea.", "Kids Tasty", 7 },
                    { 72, 91, new DateTime(2020, 1, 26, 20, 6, 0, 345, DateTimeKind.Local).AddTicks(5330), new DateTime(2021, 12, 8, 11, 16, 37, 418, DateTimeKind.Local).AddTicks(2642), "Odio sed modi sed nemo magni neque rerum nam.", "driver Orchestrator", 7 },
                    { 70, 90, new DateTime(2020, 6, 28, 17, 1, 2, 305, DateTimeKind.Local).AddTicks(3978), new DateTime(2021, 6, 23, 18, 53, 6, 466, DateTimeKind.Local).AddTicks(717), "Illo temporibus nam repellendus ut.", "optical", 7 },
                    { 73, 89, new DateTime(2020, 12, 13, 18, 45, 34, 125, DateTimeKind.Local).AddTicks(7351), new DateTime(2021, 9, 5, 7, 47, 57, 773, DateTimeKind.Local).AddTicks(3646), "Rerum molestiae ut aperiam quas quo ab commodi.", "lavender Port e-business", 7 },
                    { 71, 87, new DateTime(2020, 4, 1, 1, 44, 5, 852, DateTimeKind.Local).AddTicks(5593), new DateTime(2021, 12, 10, 19, 1, 24, 460, DateTimeKind.Local).AddTicks(1643), "Eius error recusandae libero cumque commodi reprehenderit voluptatem et omnis.", "National", 7 },
                    { 61, 87, new DateTime(2020, 4, 18, 8, 46, 30, 890, DateTimeKind.Local).AddTicks(5128), new DateTime(2021, 9, 24, 16, 40, 2, 610, DateTimeKind.Local).AddTicks(459), "Laborum est similique.", "Home Loan Account Re-engineered Australian Dollar", 7 },
                    { 67, 85, new DateTime(2019, 10, 30, 16, 42, 19, 432, DateTimeKind.Local).AddTicks(8527), new DateTime(2021, 10, 30, 0, 13, 56, 294, DateTimeKind.Local).AddTicks(4597), "Voluptatibus id corporis.", "primary Tasty Fresh Fish", 7 },
                    { 68, 84, new DateTime(2020, 9, 7, 14, 44, 25, 561, DateTimeKind.Local).AddTicks(7), new DateTime(2021, 8, 8, 1, 37, 48, 716, DateTimeKind.Local).AddTicks(3495), "Qui nostrum nesciunt a in cupiditate hic quasi.", "deposit Handmade Wooden Chair", 7 },
                    { 69, 92, new DateTime(2020, 5, 14, 11, 24, 50, 306, DateTimeKind.Local).AddTicks(5639), new DateTime(2021, 8, 26, 10, 2, 13, 227, DateTimeKind.Local).AddTicks(9163), "Nulla tempore molestiae necessitatibus voluptatum omnis provident accusamus cum non.", "Licensed", 7 },
                    { 62, 84, new DateTime(2021, 3, 12, 21, 41, 7, 70, DateTimeKind.Local).AddTicks(5771), new DateTime(2021, 10, 23, 2, 37, 45, 333, DateTimeKind.Local).AddTicks(4507), "Nam harum officia.", "withdrawal XML Books", 7 },
                    { 58, 82, new DateTime(2020, 11, 27, 15, 26, 18, 254, DateTimeKind.Local).AddTicks(7011), new DateTime(2021, 9, 1, 15, 51, 0, 165, DateTimeKind.Local).AddTicks(1103), "Commodi voluptatum eligendi.", "web services Handmade Metal Hat card", 6 },
                    { 57, 82, new DateTime(2020, 8, 4, 1, 47, 8, 458, DateTimeKind.Local).AddTicks(5349), new DateTime(2021, 10, 10, 15, 44, 9, 288, DateTimeKind.Local).AddTicks(5111), "Ut culpa aut blanditiis sint corrupti.", "forecast Home & Toys Global", 6 },
                    { 55, 82, new DateTime(2019, 9, 8, 4, 47, 23, 703, DateTimeKind.Local).AddTicks(2528), new DateTime(2021, 10, 12, 19, 58, 34, 977, DateTimeKind.Local).AddTicks(54), "Mollitia tenetur non numquam.", "Practical Wooden Car Haiti Unions", 6 },
                    { 54, 81, new DateTime(2021, 3, 16, 20, 32, 2, 185, DateTimeKind.Local).AddTicks(7021), new DateTime(2021, 9, 29, 0, 50, 8, 469, DateTimeKind.Local).AddTicks(6444), "Nisi qui quia inventore maiores qui aut quas dolor et.", "Bhutanese Ngultrum Gorgeous", 6 },
                    { 56, 80, new DateTime(2021, 1, 26, 22, 43, 20, 597, DateTimeKind.Local).AddTicks(5913), new DateTime(2021, 9, 9, 16, 6, 48, 39, DateTimeKind.Local).AddTicks(4059), "Non blanditiis quo est sit amet enim explicabo iusto.", "Oklahoma", 6 },
                    { 53, 78, new DateTime(2020, 8, 27, 9, 52, 57, 100, DateTimeKind.Local).AddTicks(3543), new DateTime(2021, 11, 14, 1, 44, 10, 223, DateTimeKind.Local).AddTicks(396), "Rerum nam ipsam repudiandae vel animi numquam et placeat.", "compress", 5 },
                    { 51, 78, new DateTime(2021, 6, 4, 3, 57, 33, 934, DateTimeKind.Local).AddTicks(2261), new DateTime(2021, 8, 9, 18, 14, 25, 18, DateTimeKind.Local).AddTicks(162), "Et dolore quaerat pariatur illum sed amet dolores deleniti.", "Practical Soft Hat", 5 },
                    { 50, 78, new DateTime(2020, 1, 2, 3, 56, 0, 968, DateTimeKind.Local).AddTicks(7162), new DateTime(2021, 9, 16, 4, 51, 20, 392, DateTimeKind.Local).AddTicks(3540), "Recusandae itaque necessitatibus sunt unde est.", "Bedfordshire Generic Cotton Chair", 5 },
                    { 49, 78, new DateTime(2019, 12, 29, 22, 48, 6, 882, DateTimeKind.Local).AddTicks(2589), new DateTime(2021, 11, 14, 15, 32, 0, 415, DateTimeKind.Local).AddTicks(8865), "Dolorem sunt optio sed excepturi dolores sequi ipsa.", "Cape Verde virtual", 5 },
                    { 59, 83, new DateTime(2020, 2, 18, 6, 51, 8, 636, DateTimeKind.Local).AddTicks(8736), new DateTime(2021, 11, 26, 16, 32, 57, 452, DateTimeKind.Local).AddTicks(6908), "Et consectetur dolores quas.", "system-worthy input Data", 6 },
                    { 74, 92, new DateTime(2021, 4, 20, 13, 27, 55, 958, DateTimeKind.Local).AddTicks(1408), new DateTime(2021, 8, 4, 19, 24, 13, 678, DateTimeKind.Local).AddTicks(9294), "Autem repellat ea fuga ut ut esse est eum ut.", "Delaware", 7 },
                    { 64, 95, new DateTime(2020, 5, 23, 14, 36, 23, 918, DateTimeKind.Local).AddTicks(7435), new DateTime(2021, 11, 11, 19, 14, 45, 281, DateTimeKind.Local).AddTicks(3100), "Quasi minus et atque minima totam iste doloribus.", "deposit", 7 },
                    { 63, 96, new DateTime(2021, 2, 23, 12, 54, 4, 107, DateTimeKind.Local).AddTicks(4780), new DateTime(2021, 10, 13, 3, 17, 35, 153, DateTimeKind.Local).AddTicks(1305), "Error placeat nemo.", "Awesome Personal Loan Account Ethiopian Birr", 7 },
                    { 95, 116, new DateTime(2020, 12, 24, 4, 50, 44, 960, DateTimeKind.Local).AddTicks(861), new DateTime(2021, 7, 7, 1, 53, 44, 689, DateTimeKind.Local).AddTicks(1399), "Cupiditate ipsam ex quaerat blanditiis.", "Generic Rubber Bacon", 9 },
                    { 92, 116, new DateTime(2019, 10, 30, 22, 53, 28, 598, DateTimeKind.Local).AddTicks(6128), new DateTime(2021, 11, 8, 11, 39, 31, 111, DateTimeKind.Local).AddTicks(7124), "Est atque voluptatem a facilis aut est nulla doloribus.", "THX solid state Awesome Concrete Chair", 9 },
                    { 96, 115, new DateTime(2020, 4, 3, 1, 59, 29, 126, DateTimeKind.Local).AddTicks(7673), new DateTime(2021, 9, 4, 2, 58, 34, 691, DateTimeKind.Local).AddTicks(2828), "Voluptatem occaecati laboriosam voluptatem.", "metrics", 9 },
                    { 91, 115, new DateTime(2021, 4, 26, 5, 25, 29, 198, DateTimeKind.Local).AddTicks(7347), new DateTime(2021, 11, 12, 22, 17, 54, 173, DateTimeKind.Local).AddTicks(8048), "Saepe sit distinctio veritatis aliquam odio.", "Wooden", 9 },
                    { 85, 112, new DateTime(2020, 1, 11, 15, 12, 40, 823, DateTimeKind.Local).AddTicks(334), new DateTime(2021, 9, 8, 17, 16, 2, 345, DateTimeKind.Local).AddTicks(7950), "Reiciendis aut facere harum omnis non eius recusandae aliquam occaecati.", "Solutions drive", 8 },
                    { 82, 111, new DateTime(2019, 11, 13, 0, 52, 24, 576, DateTimeKind.Local).AddTicks(9742), new DateTime(2021, 8, 24, 23, 41, 20, 10, DateTimeKind.Local).AddTicks(9658), "Laboriosam aut accusamus sit saepe et ut velit.", "invoice Fort", 8 },
                    { 86, 110, new DateTime(2021, 6, 15, 1, 7, 25, 100, DateTimeKind.Local).AddTicks(9230), new DateTime(2021, 9, 1, 10, 14, 7, 856, DateTimeKind.Local).AddTicks(2266), "Voluptas ut corrupti fugit.", "Tasty Wooden Chicken Peso Uruguayo", 8 },
                    { 83, 109, new DateTime(2020, 12, 18, 13, 55, 57, 929, DateTimeKind.Local).AddTicks(9305), new DateTime(2021, 9, 25, 18, 16, 36, 530, DateTimeKind.Local).AddTicks(856), "Ullam voluptatem id dignissimos ea porro ut eveniet ipsum aut.", "communities EXE", 8 },
                    { 76, 109, new DateTime(2020, 6, 28, 14, 17, 11, 813, DateTimeKind.Local).AddTicks(1449), new DateTime(2021, 7, 20, 19, 58, 36, 455, DateTimeKind.Local).AddTicks(3333), "Aut ut odit non cumque.", "Lodge", 8 },
                    { 81, 108, new DateTime(2021, 3, 3, 17, 25, 25, 722, DateTimeKind.Local).AddTicks(4981), new DateTime(2021, 7, 25, 6, 22, 53, 344, DateTimeKind.Local).AddTicks(6560), "Quod beatae et optio sit reiciendis omnis cum sint.", "Intelligent synergies", 8 },
                    { 90, 107, new DateTime(2019, 6, 25, 10, 41, 55, 695, DateTimeKind.Local).AddTicks(5478), new DateTime(2021, 10, 17, 8, 20, 10, 250, DateTimeKind.Local).AddTicks(9511), "Repellat officiis blanditiis ipsum velit pariatur quis dolores quaerat autem.", "Reunion hack", 8 },
                    { 88, 107, new DateTime(2020, 6, 7, 13, 29, 37, 139, DateTimeKind.Local).AddTicks(8476), new DateTime(2021, 8, 9, 1, 23, 57, 232, DateTimeKind.Local).AddTicks(5977), "Expedita itaque repellendus eos et.", "Cambridgeshire real-time invoice", 8 },
                    { 87, 107, new DateTime(2019, 11, 29, 8, 55, 20, 958, DateTimeKind.Local).AddTicks(8410), new DateTime(2021, 7, 19, 20, 14, 22, 970, DateTimeKind.Local).AddTicks(8238), "Quidem perferendis esse enim ut.", "copy Hong Kong Infrastructure", 8 },
                    { 84, 106, new DateTime(2020, 1, 8, 8, 3, 25, 921, DateTimeKind.Local).AddTicks(9474), new DateTime(2021, 10, 13, 4, 43, 2, 513, DateTimeKind.Local).AddTicks(3689), "Reiciendis velit amet.", "Assistant California", 8 },
                    { 80, 106, new DateTime(2021, 5, 26, 4, 34, 28, 637, DateTimeKind.Local).AddTicks(8602), new DateTime(2021, 11, 3, 10, 52, 30, 935, DateTimeKind.Local).AddTicks(1581), "Deleniti accusantium vel aliquid doloremque iure.", "Springs", 8 },
                    { 78, 105, new DateTime(2021, 3, 8, 21, 10, 57, 409, DateTimeKind.Local).AddTicks(4461), new DateTime(2021, 11, 30, 14, 21, 3, 231, DateTimeKind.Local).AddTicks(4281), "At nostrum enim quo cumque iusto quisquam qui.", "Sleek Cotton Keyboard COM neural", 8 },
                    { 79, 104, new DateTime(2020, 3, 10, 22, 3, 12, 124, DateTimeKind.Local).AddTicks(6224), new DateTime(2021, 8, 27, 1, 27, 26, 483, DateTimeKind.Local).AddTicks(9892), "Et et expedita rerum.", "orchestrate disintermediate", 8 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[,]
                {
                    { 77, 104, new DateTime(2019, 9, 13, 5, 33, 24, 476, DateTimeKind.Local).AddTicks(5452), new DateTime(2021, 11, 3, 0, 10, 35, 170, DateTimeKind.Local).AddTicks(5719), "Voluptas saepe eum aut distinctio voluptatem praesentium.", "Personal Loan Account orchestrate hacking", 8 },
                    { 89, 103, new DateTime(2021, 4, 21, 7, 12, 37, 629, DateTimeKind.Local).AddTicks(7882), new DateTime(2021, 7, 3, 7, 35, 10, 271, DateTimeKind.Local).AddTicks(2948), "Sit dolor saepe officiis voluptas eos enim in dolores maiores.", "Swiss Franc Bedfordshire", 8 },
                    { 65, 101, new DateTime(2020, 4, 17, 16, 7, 39, 185, DateTimeKind.Local).AddTicks(8192), new DateTime(2021, 10, 8, 14, 16, 55, 936, DateTimeKind.Local).AddTicks(9968), "Et quidem quia.", "Small Fresh Pants Home Loan Account", 7 },
                    { 66, 97, new DateTime(2020, 8, 29, 1, 3, 46, 278, DateTimeKind.Local).AddTicks(2746), new DateTime(2021, 10, 10, 6, 3, 2, 272, DateTimeKind.Local).AddTicks(1778), "Asperiores sint rerum.", "Fantastic Steel Shirt", 7 },
                    { 48, 78, new DateTime(2020, 4, 6, 15, 8, 44, 858, DateTimeKind.Local).AddTicks(4885), new DateTime(2021, 8, 7, 10, 30, 51, 185, DateTimeKind.Local).AddTicks(889), "Quis consequatur est qui.", "compelling Director virtual", 5 },
                    { 93, 117, new DateTime(2020, 3, 27, 21, 56, 6, 315, DateTimeKind.Local).AddTicks(9036), new DateTime(2021, 9, 21, 4, 20, 56, 607, DateTimeKind.Local).AddTicks(7298), "Recusandae et perferendis autem sit.", "action-items PNG", 9 },
                    { 46, 78, new DateTime(2020, 8, 21, 8, 2, 20, 337, DateTimeKind.Local).AddTicks(5031), new DateTime(2021, 10, 8, 5, 7, 40, 950, DateTimeKind.Local).AddTicks(4841), "Numquam sed voluptatibus voluptatibus quas.", "Outdoors, Kids & Computers Bedfordshire Berkshire", 5 },
                    { 43, 78, new DateTime(2021, 5, 6, 14, 53, 0, 688, DateTimeKind.Local).AddTicks(2002), new DateTime(2021, 12, 10, 22, 11, 13, 572, DateTimeKind.Local).AddTicks(4739), "Aut non deserunt et est illum.", "Kansas firewall", 5 },
                    { 29, 63, new DateTime(2019, 10, 20, 15, 8, 31, 873, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 8, 15, 22, 36, 32, 664, DateTimeKind.Local).AddTicks(9445), "Facere nemo atque amet in iste.", "Music", 3 },
                    { 24, 63, new DateTime(2020, 3, 24, 14, 40, 48, 394, DateTimeKind.Local).AddTicks(8371), new DateTime(2021, 11, 30, 21, 26, 25, 898, DateTimeKind.Local).AddTicks(3258), "Aliquam quasi dolore.", "Plain Global", 3 },
                    { 18, 55, new DateTime(2021, 4, 18, 11, 47, 30, 821, DateTimeKind.Local).AddTicks(6119), new DateTime(2021, 11, 17, 3, 36, 46, 800, DateTimeKind.Local).AddTicks(523), "Reprehenderit qui et praesentium cupiditate hic.", "Avon", 2 },
                    { 16, 55, new DateTime(2021, 2, 21, 9, 5, 6, 152, DateTimeKind.Local).AddTicks(4385), new DateTime(2021, 9, 27, 5, 47, 45, 207, DateTimeKind.Local).AddTicks(4038), "Ratione corporis inventore modi nesciunt quo qui illum rerum voluptatum.", "Cuban Peso 6th generation", 2 },
                    { 17, 54, new DateTime(2020, 2, 27, 17, 41, 57, 877, DateTimeKind.Local).AddTicks(7711), new DateTime(2021, 8, 28, 2, 42, 54, 219, DateTimeKind.Local).AddTicks(9855), "Non dolores id eligendi.", "optimize solid state actuating", 2 },
                    { 13, 49, new DateTime(2020, 3, 29, 23, 50, 9, 46, DateTimeKind.Local).AddTicks(8406), new DateTime(2021, 8, 2, 5, 31, 39, 328, DateTimeKind.Local).AddTicks(3064), "Est doloribus expedita vel distinctio.", "protocol", 1 },
                    { 14, 46, new DateTime(2020, 4, 19, 8, 51, 4, 872, DateTimeKind.Local).AddTicks(6359), new DateTime(2021, 8, 2, 12, 18, 48, 661, DateTimeKind.Local).AddTicks(2819), "Autem id qui ut.", "Metal Facilitator", 1 },
                    { 15, 38, new DateTime(2019, 11, 22, 16, 41, 23, 730, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 11, 30, 6, 13, 22, 935, DateTimeKind.Local).AddTicks(9388), "Qui quia reiciendis molestiae est reprehenderit sint fugiat dolorum.", "transmitting Intelligent Metal Table unleash", 1 },
                    { 11, 38, new DateTime(2020, 1, 16, 10, 5, 5, 697, DateTimeKind.Local).AddTicks(7700), new DateTime(2021, 10, 3, 17, 57, 28, 977, DateTimeKind.Local).AddTicks(4796), "Officiis maiores exercitationem.", "THX", 1 },
                    { 25, 64, new DateTime(2020, 10, 21, 23, 23, 8, 27, DateTimeKind.Local).AddTicks(3707), new DateTime(2021, 7, 12, 10, 18, 6, 848, DateTimeKind.Local).AddTicks(3870), "Perferendis molestias ex sed.", "SMS Unbranded Fresh", 3 },
                    { 12, 36, new DateTime(2020, 6, 9, 20, 10, 47, 907, DateTimeKind.Local).AddTicks(7465), new DateTime(2021, 11, 22, 3, 45, 47, 205, DateTimeKind.Local).AddTicks(6714), "Praesentium est similique velit libero inventore totam.", "Cambridgeshire", 1 },
                    { 3, 31, new DateTime(2020, 3, 15, 23, 33, 15, 673, DateTimeKind.Local).AddTicks(1141), new DateTime(2021, 7, 21, 11, 32, 51, 335, DateTimeKind.Local).AddTicks(4654), "Quia et tempora hic pariatur voluptatem doloribus sunt.", "Dam", 10 },
                    { 2, 31, new DateTime(2021, 1, 30, 17, 38, 53, 883, DateTimeKind.Local).AddTicks(8745), new DateTime(2021, 7, 24, 15, 7, 31, 935, DateTimeKind.Local).AddTicks(7846), "Non voluptatem voluptas libero.", "Village", 10 },
                    { 5, 29, new DateTime(2021, 3, 15, 22, 47, 35, 933, DateTimeKind.Local).AddTicks(5401), new DateTime(2021, 9, 14, 5, 53, 20, 800, DateTimeKind.Local).AddTicks(3038), "Voluptatibus error ut id libero quam natus molestias natus.", "Libyan Dinar Netherlands Antilles", 10 },
                    { 4, 29, new DateTime(2019, 7, 3, 6, 39, 1, 997, DateTimeKind.Local).AddTicks(8679), new DateTime(2021, 6, 25, 14, 25, 0, 711, DateTimeKind.Local).AddTicks(1264), "Soluta non sed assumenda.", "iterate project", 10 },
                    { 10, 28, new DateTime(2019, 10, 17, 10, 0, 17, 845, DateTimeKind.Local).AddTicks(2998), new DateTime(2021, 6, 29, 15, 43, 45, 38, DateTimeKind.Local).AddTicks(1411), "Molestias et inventore totam architecto explicabo dolorum et esse.", "Sleek Frozen Mouse", 10 },
                    { 97, 26, new DateTime(2019, 7, 17, 9, 42, 48, 376, DateTimeKind.Local).AddTicks(2460), new DateTime(2021, 8, 3, 4, 8, 10, 322, DateTimeKind.Local).AddTicks(8394), "Repellendus expedita dolorum saepe ut culpa nobis sunt itaque labore.", "open architecture Outdoors, Grocery & Baby Dynamic", 10 },
                    { 7, 25, new DateTime(2021, 1, 3, 6, 55, 46, 12, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 11, 30, 0, 13, 16, 969, DateTimeKind.Local).AddTicks(2138), "Voluptate et quae error est ut.", "connect", 10 },
                    { 6, 25, new DateTime(2020, 3, 22, 19, 51, 40, 196, DateTimeKind.Local).AddTicks(5166), new DateTime(2021, 9, 23, 6, 11, 42, 199, DateTimeKind.Local).AddTicks(4133), "Quas fuga qui eaque et corporis.", "New Jersey capacitor program", 10 },
                    { 9, 24, new DateTime(2019, 8, 25, 15, 59, 27, 794, DateTimeKind.Local).AddTicks(9549), new DateTime(2021, 8, 30, 5, 27, 10, 377, DateTimeKind.Local).AddTicks(6173), "Ea optio et et.", "Unbranded Soft Pants Chief", 10 },
                    { 8, 31, new DateTime(2021, 1, 9, 9, 15, 17, 961, DateTimeKind.Local).AddTicks(1807), new DateTime(2021, 10, 16, 0, 14, 10, 449, DateTimeKind.Local).AddTicks(3204), "Incidunt quam consequatur eos maxime qui.", "matrix", 10 },
                    { 30, 64, new DateTime(2019, 8, 23, 16, 7, 35, 546, DateTimeKind.Local).AddTicks(1833), new DateTime(2021, 7, 14, 18, 1, 23, 119, DateTimeKind.Local).AddTicks(5733), "Quia aut voluptatem eius est et culpa cumque quia.", "Plastic", 3 },
                    { 19, 65, new DateTime(2020, 7, 26, 5, 26, 8, 8, DateTimeKind.Local).AddTicks(8803), new DateTime(2021, 7, 22, 14, 8, 53, 845, DateTimeKind.Local).AddTicks(5228), "Et nostrum aut doloribus optio recusandae.", "revolutionary sensor integrate", 3 },
                    { 20, 65, new DateTime(2019, 12, 1, 3, 15, 0, 670, DateTimeKind.Local).AddTicks(5850), new DateTime(2021, 8, 22, 0, 47, 2, 109, DateTimeKind.Local).AddTicks(9660), "Vero neque et perspiciatis eos architecto adipisci deleniti rerum.", "lime Cameroon Avon", 3 },
                    { 41, 78, new DateTime(2020, 7, 31, 8, 30, 37, 838, DateTimeKind.Local).AddTicks(5240), new DateTime(2021, 12, 7, 1, 21, 2, 291, DateTimeKind.Local).AddTicks(5360), "Deleniti ut voluptatem id ducimus.", "override Health & Outdoors", 5 },
                    { 52, 77, new DateTime(2020, 9, 3, 7, 32, 37, 782, DateTimeKind.Local).AddTicks(963), new DateTime(2021, 6, 29, 0, 27, 44, 946, DateTimeKind.Local).AddTicks(9928), "Possimus itaque occaecati ratione nisi.", "strategize bypass Cotton", 5 },
                    { 47, 77, new DateTime(2019, 11, 18, 10, 38, 49, 415, DateTimeKind.Local).AddTicks(9192), new DateTime(2021, 10, 6, 14, 58, 37, 400, DateTimeKind.Local).AddTicks(8817), "Iusto unde fuga.", "background Awesome Concrete Hat array", 5 },
                    { 44, 77, new DateTime(2019, 11, 7, 5, 20, 52, 328, DateTimeKind.Local).AddTicks(647), new DateTime(2021, 10, 3, 11, 31, 46, 890, DateTimeKind.Local).AddTicks(8489), "Voluptatem placeat perferendis at deserunt.", "Dynamic Loop Concrete", 5 },
                    { 42, 77, new DateTime(2019, 10, 28, 13, 19, 59, 23, DateTimeKind.Local).AddTicks(5124), new DateTime(2021, 12, 3, 17, 44, 13, 492, DateTimeKind.Local).AddTicks(3418), "Numquam in odio.", "Stravenue Personal Loan Account", 5 },
                    { 40, 76, new DateTime(2020, 5, 2, 16, 48, 57, 751, DateTimeKind.Local).AddTicks(2520), new DateTime(2021, 12, 2, 4, 6, 39, 110, DateTimeKind.Local).AddTicks(4838), "Dolore temporibus aut in qui eum assumenda.", "solution-oriented ubiquitous", 4 },
                    { 39, 76, new DateTime(2019, 11, 10, 18, 49, 22, 984, DateTimeKind.Local).AddTicks(1897), new DateTime(2021, 10, 29, 9, 39, 46, 801, DateTimeKind.Local).AddTicks(6210), "Sed corporis sequi enim et.", "deposit open-source Licensed", 4 },
                    { 37, 76, new DateTime(2020, 9, 29, 20, 4, 16, 95, DateTimeKind.Local).AddTicks(8935), new DateTime(2021, 8, 8, 11, 45, 49, 547, DateTimeKind.Local).AddTicks(5316), "Placeat iure sunt quo libero sunt aut et molestias eos.", "mindshare systemic New Jersey", 4 },
                    { 38, 74, new DateTime(2020, 11, 18, 15, 7, 46, 191, DateTimeKind.Local).AddTicks(7041), new DateTime(2021, 9, 11, 23, 37, 7, 935, DateTimeKind.Local).AddTicks(3832), "Voluptatem recusandae aut.", "Licensed Soft Soap synthesize Divide", 4 },
                    { 36, 74, new DateTime(2020, 1, 21, 1, 22, 20, 876, DateTimeKind.Local).AddTicks(9856), new DateTime(2021, 7, 21, 5, 58, 43, 748, DateTimeKind.Local).AddTicks(7443), "Vel enim modi libero.", "gold Fantastic Steel Chips", 4 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[,]
                {
                    { 32, 74, new DateTime(2020, 1, 26, 19, 39, 3, 647, DateTimeKind.Local).AddTicks(8616), new DateTime(2021, 10, 3, 5, 6, 35, 399, DateTimeKind.Local).AddTicks(6098), "Voluptatem dicta illo ut ut reiciendis sint porro in sit.", "Tasty copying Checking Account", 4 },
                    { 35, 73, new DateTime(2020, 6, 9, 19, 43, 3, 896, DateTimeKind.Local).AddTicks(4789), new DateTime(2021, 12, 14, 13, 10, 42, 847, DateTimeKind.Local).AddTicks(6515), "Dolore est nobis.", "Refined whiteboard Borders", 4 },
                    { 34, 73, new DateTime(2019, 11, 28, 4, 21, 45, 852, DateTimeKind.Local).AddTicks(1989), new DateTime(2021, 7, 30, 13, 58, 6, 105, DateTimeKind.Local).AddTicks(5667), "Vel eaque facere et et labore.", "array virtual", 4 },
                    { 31, 71, new DateTime(2021, 4, 20, 13, 22, 21, 584, DateTimeKind.Local).AddTicks(2329), new DateTime(2021, 9, 6, 22, 47, 13, 133, DateTimeKind.Local).AddTicks(2692), "Ullam enim in minima.", "parsing connect", 4 },
                    { 33, 68, new DateTime(2021, 5, 12, 3, 58, 10, 841, DateTimeKind.Local).AddTicks(6380), new DateTime(2021, 7, 16, 10, 27, 46, 844, DateTimeKind.Local).AddTicks(2060), "Harum non aperiam praesentium perspiciatis optio voluptas.", "Trail", 4 },
                    { 28, 67, new DateTime(2021, 5, 8, 15, 36, 0, 238, DateTimeKind.Local).AddTicks(9615), new DateTime(2021, 9, 10, 6, 7, 42, 565, DateTimeKind.Local).AddTicks(3935), "Temporibus non molestiae qui laboriosam placeat.", "Concrete", 3 },
                    { 23, 67, new DateTime(2021, 5, 23, 9, 30, 39, 183, DateTimeKind.Local).AddTicks(6259), new DateTime(2021, 9, 10, 3, 35, 14, 153, DateTimeKind.Local).AddTicks(8400), "Assumenda facilis quis aut deleniti et rem.", "Human cross-media", 3 },
                    { 22, 67, new DateTime(2020, 9, 11, 16, 33, 10, 594, DateTimeKind.Local).AddTicks(1776), new DateTime(2021, 10, 7, 23, 1, 12, 651, DateTimeKind.Local).AddTicks(5298), "Tenetur et non consequuntur molestiae alias numquam omnis molestias inventore.", "circuit", 3 },
                    { 27, 65, new DateTime(2020, 4, 20, 13, 36, 41, 351, DateTimeKind.Local).AddTicks(8888), new DateTime(2021, 8, 21, 4, 17, 40, 45, DateTimeKind.Local).AddTicks(5707), "Sapiente deleniti voluptate qui est.", "bypassing solid state", 3 },
                    { 26, 65, new DateTime(2020, 9, 12, 13, 40, 13, 64, DateTimeKind.Local).AddTicks(3475), new DateTime(2021, 9, 18, 9, 6, 50, 714, DateTimeKind.Local).AddTicks(8434), "Quos rerum rem maiores.", "sensor Park", 3 },
                    { 21, 65, new DateTime(2019, 8, 27, 17, 50, 36, 131, DateTimeKind.Local).AddTicks(2271), new DateTime(2021, 6, 28, 9, 48, 42, 429, DateTimeKind.Local).AddTicks(7028), "Ea facere soluta nostrum architecto quam.", "SQL revolutionize Credit Card Account", 3 },
                    { 45, 78, new DateTime(2020, 4, 9, 3, 43, 0, 78, DateTimeKind.Local).AddTicks(7715), new DateTime(2021, 9, 23, 5, 46, 8, 360, DateTimeKind.Local).AddTicks(4060), "Officia dicta asperiores et.", "Money Market Account JSON", 5 },
                    { 94, 119, new DateTime(2019, 9, 26, 19, 47, 4, 383, DateTimeKind.Local).AddTicks(5870), new DateTime(2021, 12, 3, 3, 46, 3, 828, DateTimeKind.Local).AddTicks(4801), "Eaque voluptatem et.", "Developer Mobility", 9 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 46, new DateTime(2018, 4, 24, 12, 11, 45, 206, DateTimeKind.Local).AddTicks(3265), "Sed qui tempora qui et corporis ea quia earum.", null, "JBOD Visionary", 61, 9, 2 },
                    { 313, new DateTime(2019, 8, 8, 4, 27, 17, 619, DateTimeKind.Local).AddTicks(8882), "Ut ex omnis veritatis est omnis nemo consequuntur nam.", null, "bandwidth hybrid overriding", 21, 60, 2 },
                    { 312, new DateTime(2017, 9, 16, 20, 37, 38, 592, DateTimeKind.Local).AddTicks(8532), "Rerum sint fugiat eius est dolorem voluptatem ipsum.", null, "circuit turquoise Azerbaijanian Manat", 89, 60, 2 },
                    { 397, new DateTime(2019, 10, 11, 13, 9, 58, 11, DateTimeKind.Local).AddTicks(4102), "Quia rerum assumenda occaecati eligendi quisquam quia.", null, "Croatian Kuna USB", 67, 75, 2 },
                    { 396, new DateTime(2018, 10, 29, 6, 57, 33, 829, DateTimeKind.Local).AddTicks(5620), "Enim et quia rerum minima voluptatem alias aut.", new DateTime(2020, 11, 17, 20, 7, 41, 981, DateTimeKind.Local).AddTicks(4929), "olive Row", 96, 75, 2 },
                    { 378, new DateTime(2019, 7, 30, 8, 50, 21, 751, DateTimeKind.Local).AddTicks(8905), "Dolorem sint repellat mollitia quia.", null, "Field", 117, 70, 2 },
                    { 377, new DateTime(2020, 4, 29, 20, 52, 15, 156, DateTimeKind.Local).AddTicks(9297), "Delectus facilis et totam.", null, "blockchains plum", 104, 70, 2 },
                    { 376, new DateTime(2018, 4, 23, 11, 43, 16, 627, DateTimeKind.Local).AddTicks(9244), "Quisquam quisquam nihil quibusdam aut sapiente.", null, "Landing", 84, 70, 2 },
                    { 375, new DateTime(2017, 9, 11, 20, 35, 15, 796, DateTimeKind.Local).AddTicks(5555), "Natus corrupti dolorem possimus minima in vel assumenda.", new DateTime(2020, 7, 16, 3, 28, 19, 616, DateTimeKind.Local).AddTicks(6754), "Fantastic Cotton Car Lead Valleys", 40, 70, 2 },
                    { 389, new DateTime(2020, 2, 22, 21, 32, 34, 705, DateTimeKind.Local).AddTicks(543), "Fuga quasi et velit placeat et.", null, "Refined Soft Car virtual back-end", 57, 73, 2 },
                    { 388, new DateTime(2020, 6, 5, 14, 21, 22, 34, DateTimeKind.Local).AddTicks(8671), "Temporibus voluptas tempora.", null, "Assurance", 24, 73, 2 },
                    { 387, new DateTime(2019, 2, 5, 3, 50, 46, 465, DateTimeKind.Local).AddTicks(5830), "Velit odio voluptatem consequatur impedit cupiditate cum autem.", null, "Minnesota quantifying Paradigm", 53, 73, 2 },
                    { 386, new DateTime(2019, 4, 17, 8, 2, 59, 819, DateTimeKind.Local).AddTicks(1029), "Enim nostrum atque.", null, "plug-and-play", 112, 73, 2 },
                    { 385, new DateTime(2017, 7, 26, 11, 40, 9, 534, DateTimeKind.Local).AddTicks(6771), "Quam amet eveniet.", null, "Frozen Vision-oriented", 71, 73, 2 },
                    { 314, new DateTime(2018, 1, 9, 19, 14, 10, 960, DateTimeKind.Local).AddTicks(4806), "Minus sunt repellat nam debitis perferendis.", new DateTime(2020, 7, 28, 20, 43, 37, 922, DateTimeKind.Local).AddTicks(4013), "Credit Card Account Digitized Dynamic", 23, 60, 2 },
                    { 384, new DateTime(2020, 5, 8, 8, 6, 38, 476, DateTimeKind.Local).AddTicks(5817), "Ex reiciendis ipsa molestiae aut numquam alias.", new DateTime(2020, 7, 12, 19, 36, 38, 231, DateTimeKind.Local).AddTicks(9306), "Hawaii Reactive Bermuda", 38, 71, 2 },
                    { 382, new DateTime(2018, 12, 20, 4, 32, 55, 246, DateTimeKind.Local).AddTicks(6931), "Veritatis a libero eligendi.", new DateTime(2021, 3, 4, 10, 37, 30, 395, DateTimeKind.Local).AddTicks(6038), "Fresh Mountains", 113, 71, 2 },
                    { 381, new DateTime(2020, 2, 20, 12, 28, 54, 639, DateTimeKind.Local).AddTicks(9570), "Nisi quis necessitatibus saepe fuga qui.", new DateTime(2020, 9, 29, 5, 8, 24, 703, DateTimeKind.Local).AddTicks(2785), "reboot Causeway Automated", 58, 71, 2 },
                    { 380, new DateTime(2018, 4, 12, 23, 5, 1, 383, DateTimeKind.Local).AddTicks(3528), "Et voluptatem dolorem.", new DateTime(2020, 10, 1, 15, 51, 14, 741, DateTimeKind.Local).AddTicks(1275), "Directives", 89, 71, 2 },
                    { 379, new DateTime(2018, 1, 31, 2, 48, 40, 929, DateTimeKind.Local).AddTicks(9114), "Alias ea rerum qui eum dignissimos ad.", new DateTime(2021, 4, 17, 20, 54, 35, 909, DateTimeKind.Local).AddTicks(674), "payment", 98, 71, 2 },
                    { 320, new DateTime(2018, 7, 13, 4, 50, 38, 880, DateTimeKind.Local).AddTicks(2521), "Impedit laudantium suscipit asperiores nostrum dignissimos.", null, "Representative Consultant", 64, 61, 2 },
                    { 319, new DateTime(2018, 1, 28, 17, 22, 7, 104, DateTimeKind.Local).AddTicks(3732), "Aut repellat excepturi qui reprehenderit molestiae reiciendis corporis dolore sunt.", new DateTime(2021, 5, 13, 7, 47, 45, 173, DateTimeKind.Local).AddTicks(8402), "navigate withdrawal", 99, 61, 2 },
                    { 318, new DateTime(2020, 1, 15, 14, 9, 47, 226, DateTimeKind.Local).AddTicks(4611), "Quia rem consequatur aliquid earum nulla explicabo recusandae.", null, "frictionless", 30, 61, 2 },
                    { 317, new DateTime(2017, 10, 4, 6, 46, 15, 142, DateTimeKind.Local).AddTicks(9950), "Eos rerum quia qui facilis.", new DateTime(2020, 8, 28, 6, 41, 17, 348, DateTimeKind.Local).AddTicks(2721), "Plastic Nevada", 62, 61, 2 },
                    { 316, new DateTime(2019, 7, 17, 8, 42, 5, 957, DateTimeKind.Local).AddTicks(5803), "Similique dolorum quia veritatis voluptatem ut exercitationem.", null, "withdrawal", 78, 61, 2 },
                    { 360, new DateTime(2018, 7, 2, 20, 58, 9, 832, DateTimeKind.Local).AddTicks(2066), "Harum aliquid delectus est consequuntur perferendis quis enim quibusdam.", new DateTime(2020, 9, 16, 10, 9, 50, 599, DateTimeKind.Local).AddTicks(850), "bypassing Dam Bhutanese Ngultrum", 53, 67, 2 },
                    { 359, new DateTime(2019, 11, 3, 13, 12, 31, 662, DateTimeKind.Local).AddTicks(993), "Voluptas voluptatibus consectetur quia aut qui qui voluptate nisi.", null, "Rustic niches", 89, 67, 2 },
                    { 358, new DateTime(2018, 5, 11, 5, 37, 30, 596, DateTimeKind.Local).AddTicks(6480), "Velit ipsam ullam illo labore voluptatibus est ut rerum.", new DateTime(2021, 5, 5, 23, 43, 17, 695, DateTimeKind.Local).AddTicks(2993), "Lempira", 26, 67, 2 },
                    { 357, new DateTime(2017, 9, 10, 7, 28, 56, 145, DateTimeKind.Local).AddTicks(8918), "Accusamus asperiores libero ut non est.", new DateTime(2021, 1, 31, 14, 14, 3, 514, DateTimeKind.Local).AddTicks(8843), "SSL Identity", 22, 67, 2 },
                    { 383, new DateTime(2018, 11, 16, 4, 57, 59, 135, DateTimeKind.Local).AddTicks(1757), "Quia inventore ut atque autem.", new DateTime(2020, 6, 25, 3, 35, 52, 588, DateTimeKind.Local).AddTicks(5304), "Home Loan Account Licensed Soft Shirt Handmade Metal Tuna", 21, 71, 2 },
                    { 356, new DateTime(2017, 9, 3, 21, 49, 27, 684, DateTimeKind.Local).AddTicks(40), "Amet nulla perferendis placeat qui suscipit minus dolores sed.", null, "Avon Money Market Account white", 43, 67, 2 },
                    { 315, new DateTime(2019, 12, 7, 13, 48, 34, 616, DateTimeKind.Local).AddTicks(2268), "Quaerat sunt nam.", null, "Factors Arizona Tasty Steel Sausages", 108, 60, 2 },
                    { 367, new DateTime(2019, 10, 15, 23, 50, 53, 464, DateTimeKind.Local).AddTicks(5533), "Ut dolores alias aut perspiciatis dignissimos hic sapiente hic.", null, "reboot firewall", 29, 69, 2 },
                    { 350, new DateTime(2018, 11, 29, 14, 31, 4, 42, DateTimeKind.Local).AddTicks(4456), "Molestiae quas eum ut et animi similique sed ut.", new DateTime(2021, 1, 8, 16, 33, 14, 418, DateTimeKind.Local).AddTicks(7426), "Lakes synthesize", 118, 66, 2 },
                    { 349, new DateTime(2020, 2, 18, 9, 6, 53, 741, DateTimeKind.Local).AddTicks(2068), "Dolor officiis nulla non facilis recusandae natus.", null, "instruction set invoice", 75, 66, 2 },
                    { 348, new DateTime(2017, 10, 12, 3, 56, 33, 182, DateTimeKind.Local).AddTicks(309), "Omnis ut quia quas repudiandae harum et omnis.", null, "wireless Marketing", 32, 66, 2 },
                    { 347, new DateTime(2017, 9, 22, 2, 29, 1, 661, DateTimeKind.Local).AddTicks(3633), "Esse perferendis pariatur quia dolores atque.", null, "Rwanda Sleek Frozen Computer", 24, 66, 2 },
                    { 327, new DateTime(2017, 11, 11, 5, 12, 19, 1, DateTimeKind.Local).AddTicks(3098), "Possimus excepturi ut qui nulla.", null, "Borders Buckinghamshire", 87, 63, 2 },
                    { 337, new DateTime(2018, 7, 3, 13, 24, 1, 320, DateTimeKind.Local).AddTicks(2367), "Labore velit qui expedita.", null, "AGP Vista", 95, 64, 2 },
                    { 336, new DateTime(2018, 2, 20, 0, 38, 23, 374, DateTimeKind.Local).AddTicks(9334), "Qui rerum saepe suscipit quia sed.", new DateTime(2021, 5, 4, 2, 55, 12, 418, DateTimeKind.Local).AddTicks(7240), "primary Incredible Granite Chair purple", 108, 64, 2 },
                    { 335, new DateTime(2019, 6, 16, 11, 44, 21, 457, DateTimeKind.Local).AddTicks(4521), "Id accusantium sequi provident aut consequatur eum asperiores sit eos.", null, "Jewelery Licensed Wooden Chicken", 41, 64, 2 },
                    { 334, new DateTime(2019, 10, 10, 18, 18, 3, 328, DateTimeKind.Local).AddTicks(7010), "Rem perferendis omnis laborum ut non.", null, "user-centric transmitting", 33, 64, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 333, new DateTime(2018, 9, 16, 10, 17, 42, 545, DateTimeKind.Local).AddTicks(6952), "Quisquam accusantium officiis est perspiciatis laudantium magni.", null, "Cambridgeshire collaborative", 41, 64, 2 },
                    { 332, new DateTime(2018, 8, 28, 9, 59, 59, 398, DateTimeKind.Local).AddTicks(4081), "Placeat minima quos quis sed sint et.", null, "monitor Brazil", 114, 64, 2 },
                    { 331, new DateTime(2019, 11, 8, 0, 30, 58, 632, DateTimeKind.Local).AddTicks(1177), "Delectus corporis eveniet provident dolorum dolores ea incidunt placeat.", new DateTime(2020, 11, 21, 13, 50, 57, 529, DateTimeKind.Local).AddTicks(9898), "RAM parsing maximize", 78, 64, 2 },
                    { 330, new DateTime(2019, 6, 15, 20, 7, 25, 759, DateTimeKind.Local).AddTicks(1187), "Est consequatur dolores omnis numquam.", new DateTime(2021, 4, 20, 17, 57, 38, 105, DateTimeKind.Local).AddTicks(4805), "holistic", 88, 64, 2 },
                    { 366, new DateTime(2020, 3, 9, 8, 22, 41, 846, DateTimeKind.Local).AddTicks(9326), "Laboriosam corporis repellat eum sequi maiores voluptatem.", null, "deposit Maryland", 61, 69, 2 },
                    { 329, new DateTime(2019, 7, 25, 11, 57, 6, 130, DateTimeKind.Local).AddTicks(8997), "Illum numquam corrupti alias consequatur.", null, "quantify HTTP Nuevo Sol", 41, 64, 2 },
                    { 395, new DateTime(2019, 1, 15, 9, 17, 8, 124, DateTimeKind.Local).AddTicks(1490), "A asperiores et.", new DateTime(2021, 6, 7, 11, 32, 19, 183, DateTimeKind.Local).AddTicks(1962), "New Caledonia Assurance", 100, 74, 2 },
                    { 394, new DateTime(2018, 12, 25, 4, 56, 56, 842, DateTimeKind.Local).AddTicks(1749), "Possimus iure quibusdam id.", null, "payment Nauru mint green", 67, 74, 2 },
                    { 393, new DateTime(2019, 1, 21, 5, 26, 10, 343, DateTimeKind.Local).AddTicks(5886), "Soluta quis sunt id laudantium quia.", null, "Aruba Avon", 104, 74, 2 },
                    { 392, new DateTime(2020, 1, 17, 15, 46, 1, 112, DateTimeKind.Local).AddTicks(8665), "Minus et ipsa in.", null, "tan", 48, 74, 2 },
                    { 391, new DateTime(2019, 2, 4, 19, 3, 17, 41, DateTimeKind.Local).AddTicks(2730), "Voluptas ipsam rerum aspernatur autem sit est et ipsa soluta.", null, "bandwidth target", 101, 74, 2 },
                    { 390, new DateTime(2017, 9, 12, 4, 30, 52, 519, DateTimeKind.Local).AddTicks(2450), "Vitae distinctio iusto quae.", null, "Row transmitting", 48, 74, 2 },
                    { 374, new DateTime(2017, 11, 13, 14, 9, 1, 836, DateTimeKind.Local).AddTicks(9435), "Minus quidem aut et.", null, "Handmade", 43, 69, 2 },
                    { 373, new DateTime(2019, 12, 10, 9, 29, 55, 311, DateTimeKind.Local).AddTicks(1469), "Nostrum aut est rerum fugit et illo laborum.", null, "Sleek", 86, 69, 2 },
                    { 372, new DateTime(2019, 12, 27, 7, 6, 58, 330, DateTimeKind.Local).AddTicks(9108), "Velit vel saepe in dolor et fugiat.", null, "monitor Borders", 66, 69, 2 },
                    { 371, new DateTime(2020, 5, 26, 9, 28, 23, 704, DateTimeKind.Local).AddTicks(6980), "Amet tenetur vel iste incidunt optio.", null, "Auto Loan Account", 54, 69, 2 },
                    { 370, new DateTime(2018, 3, 5, 18, 41, 54, 826, DateTimeKind.Local).AddTicks(6529), "Voluptatum facere quidem sit autem quidem ea debitis.", null, "matrix invoice", 35, 69, 2 },
                    { 369, new DateTime(2020, 1, 16, 6, 35, 58, 831, DateTimeKind.Local).AddTicks(9419), "Possimus iste debitis adipisci eaque autem omnis.", null, "COM", 47, 69, 2 },
                    { 368, new DateTime(2020, 4, 4, 7, 42, 9, 973, DateTimeKind.Local).AddTicks(6011), "Voluptatem magnam ipsum ea et ipsam animi.", null, "pink ivory backing up", 82, 69, 2 },
                    { 328, new DateTime(2018, 9, 25, 11, 59, 40, 401, DateTimeKind.Local).AddTicks(1357), "Ipsa illo esse laboriosam architecto.", new DateTime(2020, 7, 7, 1, 37, 55, 616, DateTimeKind.Local).AddTicks(8603), "invoice pink generating", 70, 64, 2 },
                    { 365, new DateTime(2018, 5, 26, 13, 34, 21, 340, DateTimeKind.Local).AddTicks(1967), "Nam quas quod expedita neque culpa ipsa ut est.", null, "calculate Strategist Garden", 56, 68, 2 },
                    { 364, new DateTime(2019, 6, 5, 19, 26, 31, 355, DateTimeKind.Local).AddTicks(9361), "Dignissimos voluptatum dolorem non pariatur ut.", null, "partnerships", 54, 68, 2 },
                    { 363, new DateTime(2018, 3, 14, 13, 7, 32, 115, DateTimeKind.Local).AddTicks(7120), "Delectus reprehenderit molestiae sint autem sed est sit quae.", null, "programming", 22, 68, 2 },
                    { 302, new DateTime(2018, 12, 1, 2, 7, 31, 639, DateTimeKind.Local).AddTicks(8390), "Sit expedita debitis nesciunt eligendi.", null, "Dam deposit", 30, 56, 2 },
                    { 301, new DateTime(2017, 9, 4, 20, 51, 56, 323, DateTimeKind.Local).AddTicks(9506), "Dolorem optio aut incidunt consequatur magni id.", null, "Connecticut Fundamental SCSI", 35, 56, 2 },
                    { 281, new DateTime(2018, 2, 5, 16, 21, 8, 95, DateTimeKind.Local).AddTicks(4939), "Et veritatis eveniet aut consequuntur nihil consequatur soluta dolores porro.", new DateTime(2020, 7, 11, 2, 33, 28, 693, DateTimeKind.Local).AddTicks(9354), "Generic", 33, 51, 2 },
                    { 280, new DateTime(2019, 10, 2, 0, 29, 50, 51, DateTimeKind.Local).AddTicks(5347), "Suscipit molestiae non recusandae.", new DateTime(2021, 3, 2, 5, 51, 18, 849, DateTimeKind.Local).AddTicks(2747), "architecture", 62, 51, 2 },
                    { 279, new DateTime(2019, 9, 14, 10, 53, 36, 782, DateTimeKind.Local).AddTicks(8805), "Voluptatem molestiae veniam et unde.", null, "maximized", 122, 51, 2 },
                    { 278, new DateTime(2019, 12, 8, 20, 43, 29, 492, DateTimeKind.Local).AddTicks(6408), "Sapiente sint rerum sit ipsam dolores fugiat.", new DateTime(2021, 6, 5, 15, 35, 17, 15, DateTimeKind.Local).AddTicks(8297), "cross-platform", 86, 51, 2 },
                    { 277, new DateTime(2017, 7, 27, 15, 47, 20, 128, DateTimeKind.Local).AddTicks(9892), "Vel et ut.", new DateTime(2020, 7, 8, 14, 18, 56, 899, DateTimeKind.Local).AddTicks(9775), "platforms primary", 21, 50, 2 },
                    { 276, new DateTime(2019, 7, 19, 5, 30, 20, 871, DateTimeKind.Local).AddTicks(9848), "Eaque sunt reiciendis quas nisi.", null, "Garden & Automotive Home Loan Account compress", 55, 50, 2 },
                    { 275, new DateTime(2020, 4, 7, 16, 22, 32, 425, DateTimeKind.Local).AddTicks(1905), "Omnis accusamus facere accusantium quam laboriosam provident.", null, "Corner", 110, 50, 2 },
                    { 274, new DateTime(2018, 2, 20, 16, 53, 20, 345, DateTimeKind.Local).AddTicks(5568), "Dolores ut eos debitis eaque vel rerum soluta voluptatibus.", null, "Zambia International", 74, 50, 2 },
                    { 273, new DateTime(2019, 12, 23, 23, 56, 45, 495, DateTimeKind.Local).AddTicks(6387), "Beatae soluta aliquam sapiente veniam.", null, "European Monetary Unit (E.M.U.-6) Intelligent Steel Pizza Philippine Peso", 97, 50, 2 },
                    { 272, new DateTime(2018, 9, 23, 12, 43, 24, 992, DateTimeKind.Local).AddTicks(1121), "Delectus sequi minus officiis voluptas omnis consequatur maiores nihil quas.", null, "Stream Buckinghamshire back-end", 104, 50, 2 },
                    { 271, new DateTime(2017, 8, 30, 10, 17, 3, 857, DateTimeKind.Local).AddTicks(4375), "Vitae et fuga et accusamus quod et eos sed.", null, "Ohio 1080p Internal", 34, 50, 2 },
                    { 303, new DateTime(2019, 2, 27, 9, 33, 14, 146, DateTimeKind.Local).AddTicks(8683), "Alias nulla non voluptas eligendi quis aperiam dignissimos.", null, "Incredible PCI facilitate", 120, 56, 2 },
                    { 270, new DateTime(2019, 12, 16, 20, 57, 30, 917, DateTimeKind.Local).AddTicks(7664), "Dicta error facilis corporis beatae.", null, "Radial Handmade", 67, 50, 2 },
                    { 268, new DateTime(2018, 12, 13, 7, 24, 3, 944, DateTimeKind.Local).AddTicks(2483), "Suscipit natus eveniet in ipsa saepe.", null, "Refined", 44, 49, 2 },
                    { 267, new DateTime(2019, 9, 4, 18, 21, 15, 312, DateTimeKind.Local).AddTicks(6079), "Dolores impedit quibusdam.", null, "Rustic Cotton Chips invoice", 85, 49, 2 },
                    { 266, new DateTime(2018, 12, 18, 23, 28, 58, 338, DateTimeKind.Local).AddTicks(7243), "Aliquam nam reprehenderit possimus veniam a.", null, "Internal payment mint green", 38, 49, 2 },
                    { 265, new DateTime(2018, 12, 20, 1, 4, 23, 969, DateTimeKind.Local).AddTicks(9455), "Nihil quis ut velit sed enim beatae atque.", new DateTime(2020, 9, 25, 6, 31, 36, 366, DateTimeKind.Local).AddTicks(233), "orchestrate Beauty, Movies & Toys navigate", 91, 49, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 264, new DateTime(2018, 1, 21, 1, 30, 23, 771, DateTimeKind.Local).AddTicks(181), "Dolor amet iure blanditiis eum aspernatur minima voluptates voluptatem expedita.", null, "Bahamas", 86, 49, 2 },
                    { 263, new DateTime(2018, 11, 13, 11, 40, 20, 389, DateTimeKind.Local).AddTicks(5428), "Labore harum placeat asperiores odit error qui accusamus repellat ad.", null, "quantifying hacking Buckinghamshire", 58, 49, 2 },
                    { 262, new DateTime(2018, 3, 23, 12, 50, 35, 217, DateTimeKind.Local).AddTicks(7791), "Aut harum quam.", null, "silver Lead", 66, 49, 2 },
                    { 261, new DateTime(2019, 7, 15, 14, 53, 48, 575, DateTimeKind.Local).AddTicks(4627), "Eos sed sit ut et officiis accusamus.", new DateTime(2020, 10, 29, 13, 7, 14, 738, DateTimeKind.Local).AddTicks(6866), "Licensed", 76, 48, 2 },
                    { 260, new DateTime(2018, 5, 7, 14, 22, 15, 558, DateTimeKind.Local).AddTicks(6944), "Incidunt possimus odio blanditiis sit facilis non minima aut.", null, "Borders scale", 42, 48, 2 },
                    { 259, new DateTime(2017, 12, 15, 18, 42, 0, 951, DateTimeKind.Local).AddTicks(7963), "Sunt animi qui accusamus rem sit vitae.", null, "feed real-time", 35, 48, 2 },
                    { 258, new DateTime(2020, 1, 14, 1, 28, 4, 861, DateTimeKind.Local).AddTicks(9006), "Sed provident doloribus quos aliquam minus quo commodi asperiores eaque.", new DateTime(2021, 3, 6, 4, 39, 17, 372, DateTimeKind.Local).AddTicks(791), "Trinidad and Tobago Dollar quantifying", 64, 48, 2 },
                    { 257, new DateTime(2018, 9, 28, 4, 3, 15, 3, DateTimeKind.Local).AddTicks(733), "Corrupti voluptatem qui quia nobis ex.", new DateTime(2020, 8, 28, 1, 8, 31, 476, DateTimeKind.Local).AddTicks(4283), "circuit port", 38, 48, 2 },
                    { 256, new DateTime(2017, 10, 29, 13, 34, 28, 336, DateTimeKind.Local).AddTicks(7464), "Quo earum ad.", null, "neutral Forward Intelligent", 115, 48, 2 },
                    { 269, new DateTime(2020, 6, 9, 22, 51, 58, 989, DateTimeKind.Local).AddTicks(7509), "Odit quod quas fugiat.", null, "transform", 114, 49, 2 },
                    { 304, new DateTime(2020, 3, 22, 17, 19, 8, 982, DateTimeKind.Local).AddTicks(940), "Qui minus odio.", null, "Small Metal Bike deposit", 61, 56, 2 },
                    { 305, new DateTime(2020, 6, 12, 5, 12, 54, 941, DateTimeKind.Local).AddTicks(8228), "Enim quia vero sapiente quas consequuntur magnam vitae.", null, "driver Sleek", 100, 56, 2 },
                    { 306, new DateTime(2018, 10, 30, 19, 59, 29, 204, DateTimeKind.Local).AddTicks(1901), "Optio nisi quidem.", null, "concept", 47, 56, 2 },
                    { 362, new DateTime(2020, 2, 11, 1, 29, 5, 728, DateTimeKind.Local).AddTicks(8581), "Voluptas non laboriosam eligendi iusto.", null, "Designer Progressive Camp", 115, 68, 2 },
                    { 361, new DateTime(2019, 12, 19, 18, 22, 44, 824, DateTimeKind.Local).AddTicks(190), "Repellendus in ut accusantium.", null, "Concrete", 104, 68, 2 },
                    { 326, new DateTime(2018, 5, 13, 5, 54, 36, 663, DateTimeKind.Local).AddTicks(933), "Aut eum et temporibus ea suscipit officiis quia et reiciendis.", null, "grey", 57, 62, 2 },
                    { 325, new DateTime(2020, 4, 23, 13, 25, 23, 193, DateTimeKind.Local).AddTicks(1194), "A qui ipsa est.", null, "Integration", 34, 62, 2 },
                    { 324, new DateTime(2018, 5, 31, 0, 50, 35, 884, DateTimeKind.Local).AddTicks(9306), "Delectus doloremque qui eos.", null, "back up", 83, 62, 2 },
                    { 323, new DateTime(2017, 7, 13, 14, 3, 10, 273, DateTimeKind.Local).AddTicks(2862), "Iusto neque et corrupti est quod est qui est.", null, "TCP", 114, 62, 2 },
                    { 322, new DateTime(2019, 5, 29, 13, 45, 54, 938, DateTimeKind.Local).AddTicks(774), "Odit rerum dolor aut vero velit sed.", null, "North Dakota", 28, 62, 2 },
                    { 321, new DateTime(2017, 12, 30, 15, 11, 19, 681, DateTimeKind.Local).AddTicks(1584), "Delectus perspiciatis nulla nulla ut unde possimus veritatis voluptatem laudantium.", new DateTime(2021, 1, 27, 3, 46, 35, 791, DateTimeKind.Local).AddTicks(2475), "e-services Solomon Islands Dollar Tasty", 65, 62, 2 },
                    { 311, new DateTime(2019, 4, 27, 2, 22, 47, 955, DateTimeKind.Local).AddTicks(2321), "Veniam repellat molestiae illum dignissimos non aut aut neque.", null, "synthesizing", 25, 59, 2 },
                    { 310, new DateTime(2020, 3, 30, 18, 12, 21, 624, DateTimeKind.Local).AddTicks(9059), "Non vel pariatur voluptate dolorem quis totam.", null, "Afghani hard drive", 34, 59, 2 },
                    { 309, new DateTime(2019, 8, 3, 6, 53, 21, 446, DateTimeKind.Local).AddTicks(8248), "Eum voluptates nobis perferendis.", null, "connecting Trail", 64, 59, 2 },
                    { 308, new DateTime(2018, 2, 12, 1, 14, 51, 348, DateTimeKind.Local).AddTicks(880), "Aspernatur sed aliquid laborum eveniet nemo voluptatum qui dicta aliquam.", null, "Polarised portal", 54, 58, 2 },
                    { 307, new DateTime(2017, 11, 20, 7, 21, 59, 559, DateTimeKind.Local).AddTicks(7630), "Quo facere aut qui ad sequi aut facere quis est.", null, "Producer redundant", 87, 58, 2 },
                    { 300, new DateTime(2019, 7, 23, 21, 55, 44, 425, DateTimeKind.Local).AddTicks(2479), "Aut beatae voluptatem blanditiis ullam.", null, "Global", 97, 55, 2 },
                    { 299, new DateTime(2018, 11, 2, 20, 1, 44, 503, DateTimeKind.Local).AddTicks(5437), "Nostrum dicta cupiditate consequatur.", null, "Personal Loan Account magenta", 44, 55, 2 },
                    { 298, new DateTime(2019, 9, 17, 21, 36, 19, 120, DateTimeKind.Local).AddTicks(9830), "Voluptatem voluptatem sit eos voluptatem dolorem vel placeat vitae ex.", null, "Rest Cambridgeshire bus", 26, 55, 2 },
                    { 297, new DateTime(2017, 11, 28, 17, 57, 39, 794, DateTimeKind.Local).AddTicks(5510), "Mollitia ducimus magni suscipit quis.", null, "incentivize Integrated", 30, 55, 2 },
                    { 296, new DateTime(2018, 7, 5, 13, 59, 8, 426, DateTimeKind.Local).AddTicks(1842), "Non et est.", null, "Intuitive access Cambodia", 84, 55, 2 },
                    { 295, new DateTime(2019, 7, 11, 4, 11, 1, 428, DateTimeKind.Local).AddTicks(4243), "Sit praesentium accusamus.", new DateTime(2020, 9, 16, 16, 33, 53, 191, DateTimeKind.Local).AddTicks(5947), "Lake global Handmade Granite Soap", 23, 55, 2 },
                    { 294, new DateTime(2020, 3, 22, 20, 51, 39, 420, DateTimeKind.Local).AddTicks(6463), "Sit ea ad incidunt dolorem fuga.", null, "deposit Personal Loan Account", 96, 55, 2 },
                    { 293, new DateTime(2019, 6, 1, 11, 4, 22, 315, DateTimeKind.Local).AddTicks(7521), "Eveniet sit et quia sequi iusto minima et maxime reiciendis.", null, "visionary Personal Loan Account", 72, 54, 2 },
                    { 292, new DateTime(2018, 1, 12, 23, 46, 51, 71, DateTimeKind.Local).AddTicks(9339), "Omnis laudantium voluptas nemo.", null, "cross-platform application Bedfordshire", 108, 54, 2 },
                    { 291, new DateTime(2020, 1, 27, 12, 5, 1, 364, DateTimeKind.Local).AddTicks(1211), "Ea autem in eius quos eius quibusdam assumenda ullam.", null, "Tools Belgium", 41, 54, 2 },
                    { 290, new DateTime(2019, 3, 29, 3, 37, 30, 651, DateTimeKind.Local).AddTicks(4214), "Aut corporis ut sed qui est consequatur et id.", null, "Toys Trinidad and Tobago AI", 51, 54, 2 },
                    { 289, new DateTime(2020, 1, 25, 7, 6, 58, 285, DateTimeKind.Local).AddTicks(3961), "Blanditiis natus molestiae rem.", null, "Cotton AGP", 23, 54, 2 },
                    { 288, new DateTime(2017, 8, 26, 14, 45, 56, 844, DateTimeKind.Local).AddTicks(7544), "Perspiciatis sit non iure et.", new DateTime(2021, 2, 19, 0, 9, 55, 320, DateTimeKind.Local).AddTicks(905), "tan Usability Alabama", 28, 54, 2 },
                    { 287, new DateTime(2019, 2, 17, 18, 26, 2, 420, DateTimeKind.Local).AddTicks(7296), "Necessitatibus rerum voluptatem natus.", null, "Mobility cutting-edge Niger", 107, 54, 2 },
                    { 286, new DateTime(2020, 2, 27, 17, 23, 13, 285, DateTimeKind.Local).AddTicks(9030), "In corrupti dolorum ducimus et vero.", null, "copy", 90, 54, 2 },
                    { 285, new DateTime(2020, 3, 18, 4, 20, 19, 135, DateTimeKind.Local).AddTicks(3213), "Ut sunt pariatur necessitatibus dolor.", null, "zero administration applications Generic Cotton Bike", 82, 54, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 351, new DateTime(2017, 8, 11, 10, 20, 31, 23, DateTimeKind.Local).AddTicks(7704), "Voluptas sint impedit soluta similique aliquid sint explicabo consequatur tempore.", null, "PCI", 118, 66, 2 },
                    { 255, new DateTime(2019, 6, 30, 8, 44, 59, 35, DateTimeKind.Local).AddTicks(71), "Autem labore adipisci voluptatum.", null, "Savings Account California invoice", 103, 48, 2 },
                    { 352, new DateTime(2020, 4, 5, 17, 3, 36, 129, DateTimeKind.Local).AddTicks(9258), "Dignissimos dolore a odio qui ipsa distinctio cumque ducimus beatae.", null, "monitor circuit", 96, 66, 2 },
                    { 354, new DateTime(2019, 7, 20, 2, 16, 22, 139, DateTimeKind.Local).AddTicks(7820), "Adipisci sit quia tempore facere labore ipsum.", null, "Intuitive", 93, 66, 2 },
                    { 435, new DateTime(2018, 2, 18, 3, 27, 51, 581, DateTimeKind.Local).AddTicks(9307), "Quidem voluptatum quaerat est quas ut autem odio officiis autem.", null, "incubate", 59, 82, 2 },
                    { 434, new DateTime(2019, 9, 28, 22, 24, 22, 26, DateTimeKind.Local).AddTicks(918), "Qui corrupti omnis quis beatae ullam dignissimos.", null, "Gateway extend Sri Lanka Rupee", 110, 82, 2 },
                    { 433, new DateTime(2019, 6, 5, 13, 54, 29, 319, DateTimeKind.Local).AddTicks(8791), "Et optio perferendis ut.", new DateTime(2021, 1, 24, 17, 13, 59, 108, DateTimeKind.Local).AddTicks(6722), "Legacy SMS needs-based", 118, 82, 2 },
                    { 432, new DateTime(2019, 1, 31, 23, 27, 50, 533, DateTimeKind.Local).AddTicks(8156), "Voluptas eum occaecati dignissimos qui pariatur officiis libero.", null, "orange", 47, 82, 2 },
                    { 431, new DateTime(2018, 5, 25, 3, 52, 43, 6, DateTimeKind.Local).AddTicks(6669), "Nesciunt maxime omnis ut sint id alias.", new DateTime(2021, 3, 9, 3, 18, 0, 553, DateTimeKind.Local).AddTicks(3071), "Plaza", 108, 82, 2 },
                    { 430, new DateTime(2018, 12, 29, 9, 6, 26, 547, DateTimeKind.Local).AddTicks(6575), "Eum quae non minima aliquid aut quis voluptas tenetur maxime.", null, "transmit Berkshire IB", 67, 82, 2 },
                    { 429, new DateTime(2019, 3, 24, 17, 35, 17, 153, DateTimeKind.Local).AddTicks(5040), "Sequi molestiae qui est quos hic nesciunt et.", null, "Handmade Soft Tuna Rustic", 67, 82, 2 },
                    { 458, new DateTime(2018, 11, 16, 0, 27, 2, 803, DateTimeKind.Local).AddTicks(8829), "Eum modi odio repellendus sed quo ea qui.", null, "Shoes innovate", 106, 86, 2 },
                    { 457, new DateTime(2017, 8, 31, 15, 38, 53, 927, DateTimeKind.Local).AddTicks(6709), "Veritatis et quis debitis.", null, "Data", 114, 86, 2 },
                    { 456, new DateTime(2017, 12, 3, 14, 36, 22, 959, DateTimeKind.Local).AddTicks(2035), "Similique ut molestiae dolorem exercitationem rerum illo debitis.", new DateTime(2020, 12, 12, 17, 29, 15, 256, DateTimeKind.Local).AddTicks(7614), "maximized Money Market Account", 109, 86, 2 },
                    { 455, new DateTime(2019, 5, 28, 1, 48, 19, 737, DateTimeKind.Local).AddTicks(3142), "Debitis et aperiam officia dicta consectetur iste.", null, "encoding Refined Steel Car", 47, 86, 2 },
                    { 454, new DateTime(2019, 8, 2, 1, 53, 26, 742, DateTimeKind.Local).AddTicks(8877), "Minus earum sint quia laudantium voluptatem earum illum adipisci.", null, "Rustic Granite Pizza Steel Representative", 42, 86, 2 },
                    { 453, new DateTime(2018, 12, 15, 4, 35, 7, 342, DateTimeKind.Local).AddTicks(1885), "Tempora aut sapiente aut expedita.", null, "supply-chains Minnesota object-oriented", 43, 86, 2 },
                    { 436, new DateTime(2019, 7, 25, 19, 46, 4, 20, DateTimeKind.Local).AddTicks(6337), "Tempora quos qui neque assumenda magnam est nostrum.", null, "Dale", 37, 82, 2 },
                    { 452, new DateTime(2019, 6, 13, 5, 26, 11, 886, DateTimeKind.Local).AddTicks(6977), "Aut excepturi excepturi eos dolorem.", null, "benchmark connecting ADP", 89, 86, 2 },
                    { 450, new DateTime(2019, 8, 5, 13, 35, 12, 375, DateTimeKind.Local).AddTicks(810), "Voluptatem molestias quos ullam sit et voluptatem ullam.", null, "generating Legacy", 31, 86, 2 },
                    { 438, new DateTime(2019, 1, 4, 18, 29, 21, 361, DateTimeKind.Local).AddTicks(5678), "Labore ipsam quos iusto minus laborum.", null, "Solutions Money Market Account", 110, 83, 2 },
                    { 402, new DateTime(2018, 7, 18, 3, 32, 19, 485, DateTimeKind.Local).AddTicks(2119), "Qui rerum ea.", null, "Home Loan Account withdrawal interfaces", 80, 76, 2 },
                    { 401, new DateTime(2019, 12, 4, 9, 38, 23, 484, DateTimeKind.Local).AddTicks(400), "Repellendus et incidunt vel eaque est quasi.", null, "orchestrate", 91, 76, 2 },
                    { 400, new DateTime(2017, 7, 16, 2, 48, 33, 744, DateTimeKind.Local).AddTicks(6132), "Natus numquam assumenda nobis.", null, "driver generate", 104, 76, 2 },
                    { 399, new DateTime(2019, 12, 17, 3, 10, 43, 250, DateTimeKind.Local).AddTicks(6206), "Enim sunt necessitatibus autem.", null, "Lakes connect", 79, 76, 2 },
                    { 398, new DateTime(2020, 3, 29, 13, 59, 6, 227, DateTimeKind.Local).AddTicks(4598), "Placeat nobis ea alias.", null, "zero administration Borders", 104, 76, 2 },
                    { 488, new DateTime(2019, 8, 24, 23, 47, 25, 407, DateTimeKind.Local).AddTicks(3508), "Culpa repudiandae aliquid et accusantium quas quam iusto voluptas.", new DateTime(2020, 8, 14, 7, 31, 29, 725, DateTimeKind.Local).AddTicks(544), "Communications Mexican Peso Managed", 43, 90, 2 },
                    { 487, new DateTime(2018, 11, 26, 3, 4, 52, 19, DateTimeKind.Local).AddTicks(2024), "Sit aut tempore.", null, "internet solution Auto Loan Account", 79, 90, 2 },
                    { 486, new DateTime(2019, 11, 21, 20, 25, 8, 20, DateTimeKind.Local).AddTicks(5316), "Sunt dolorum suscipit.", null, "Buckinghamshire", 23, 90, 2 },
                    { 485, new DateTime(2019, 11, 12, 10, 30, 3, 793, DateTimeKind.Local).AddTicks(910), "Iure aliquam provident.", null, "navigate Granite", 97, 90, 2 },
                    { 484, new DateTime(2020, 4, 28, 2, 57, 42, 718, DateTimeKind.Local).AddTicks(2712), "In dolorem vero maxime voluptate.", null, "empower concept Fresh", 29, 90, 2 },
                    { 483, new DateTime(2019, 7, 25, 12, 33, 35, 978, DateTimeKind.Local).AddTicks(3371), "Iusto voluptas in qui ipsa earum nobis earum est.", null, "XSS Kansas", 79, 90, 2 },
                    { 451, new DateTime(2019, 11, 1, 10, 11, 57, 791, DateTimeKind.Local).AddTicks(6547), "Qui asperiores eveniet veniam reprehenderit laboriosam.", null, "ROI streamline", 122, 86, 2 },
                    { 482, new DateTime(2017, 7, 31, 13, 1, 14, 16, DateTimeKind.Local).AddTicks(8289), "Sapiente saepe occaecati molestiae velit numquam qui quam est.", null, "Communications", 25, 90, 2 },
                    { 437, new DateTime(2018, 12, 3, 6, 40, 36, 283, DateTimeKind.Local).AddTicks(6035), "Optio voluptatem velit veniam.", new DateTime(2020, 6, 23, 21, 37, 53, 720, DateTimeKind.Local).AddTicks(6809), "parallelism help-desk primary", 51, 82, 2 },
                    { 445, new DateTime(2019, 11, 5, 1, 4, 8, 880, DateTimeKind.Local).AddTicks(7190), "Nam tempore voluptatem eos sed.", null, "architect Fork", 22, 85, 2 },
                    { 499, new DateTime(2018, 9, 8, 4, 10, 32, 583, DateTimeKind.Local).AddTicks(9098), "Voluptate minus quia tempore omnis.", null, "Cotton Nakfa", 32, 93, 2 },
                    { 498, new DateTime(2020, 4, 8, 5, 31, 24, 581, DateTimeKind.Local).AddTicks(5982), "Exercitationem cum et aut magni quod veniam similique ut sapiente.", null, "Cliffs interface", 67, 93, 2 },
                    { 497, new DateTime(2018, 4, 5, 15, 32, 18, 0, DateTimeKind.Local).AddTicks(983), "Maiores eius nobis sunt qui esse ut reprehenderit alias.", new DateTime(2021, 5, 2, 20, 19, 27, 446, DateTimeKind.Local).AddTicks(8671), "Granite Missouri sensor", 82, 93, 2 },
                    { 511, new DateTime(2018, 5, 27, 20, 38, 48, 288, DateTimeKind.Local).AddTicks(9828), "In saepe doloremque eius molestiae occaecati.", null, "networks", 63, 95, 2 },
                    { 510, new DateTime(2018, 3, 22, 5, 26, 31, 145, DateTimeKind.Local).AddTicks(539), "Nisi enim porro fugiat a.", null, "California", 33, 95, 2 },
                    { 509, new DateTime(2017, 12, 29, 22, 12, 20, 878, DateTimeKind.Local).AddTicks(6417), "Harum in sunt odio placeat accusantium.", null, "Awesome Rubber Chicken bus algorithm", 20, 95, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 508, new DateTime(2018, 5, 22, 5, 15, 19, 955, DateTimeKind.Local).AddTicks(3952), "Provident voluptatibus ex eum qui.", new DateTime(2021, 4, 22, 23, 16, 4, 643, DateTimeKind.Local).AddTicks(4159), "platforms", 54, 95, 2 },
                    { 507, new DateTime(2019, 5, 8, 0, 27, 12, 782, DateTimeKind.Local).AddTicks(2662), "Pariatur nemo officiis quam consectetur perferendis.", null, "Grass-roots", 50, 95, 2 },
                    { 506, new DateTime(2019, 9, 30, 13, 17, 44, 65, DateTimeKind.Local).AddTicks(1408), "Vero itaque eaque sed dolorum nobis consequuntur totam eum rerum.", new DateTime(2020, 12, 10, 19, 45, 38, 632, DateTimeKind.Local).AddTicks(1711), "Beauty, Tools & Automotive Cambridgeshire", 30, 95, 2 },
                    { 505, new DateTime(2019, 1, 23, 23, 23, 28, 489, DateTimeKind.Local).AddTicks(886), "Nihil mollitia ipsam at sit.", null, "Savings Account Cambridgeshire", 85, 95, 2 },
                    { 504, new DateTime(2018, 4, 11, 18, 34, 50, 738, DateTimeKind.Local).AddTicks(5514), "Nisi quibusdam quis voluptas voluptatum.", null, "Personal Loan Account synthesize", 33, 95, 2 },
                    { 503, new DateTime(2019, 8, 20, 8, 55, 58, 189, DateTimeKind.Local).AddTicks(17), "Tempora aut cum aliquid illum et voluptas sit.", null, "orange", 91, 95, 2 },
                    { 502, new DateTime(2020, 1, 14, 3, 43, 36, 987, DateTimeKind.Local).AddTicks(3119), "Libero qui quibusdam qui vel impedit dolor sint.", null, "impactful Borders definition", 22, 95, 2 },
                    { 444, new DateTime(2018, 3, 7, 12, 28, 12, 408, DateTimeKind.Local).AddTicks(4392), "Magnam dolores facilis nihil.", null, "Lead", 105, 85, 2 },
                    { 496, new DateTime(2019, 11, 4, 16, 33, 15, 847, DateTimeKind.Local).AddTicks(1063), "Commodi et autem ut placeat facilis consequuntur.", new DateTime(2021, 1, 24, 1, 44, 5, 348, DateTimeKind.Local).AddTicks(7293), "Robust Personal Loan Account", 67, 92, 2 },
                    { 494, new DateTime(2019, 5, 31, 12, 37, 7, 854, DateTimeKind.Local).AddTicks(7776), "Beatae eos odio esse culpa et qui quo.", new DateTime(2020, 11, 8, 10, 28, 26, 911, DateTimeKind.Local).AddTicks(6206), "engineer Tasty Chief", 120, 92, 2 },
                    { 514, new DateTime(2019, 3, 13, 6, 38, 22, 774, DateTimeKind.Local).AddTicks(1198), "Non modi provident eveniet omnis unde ipsam.", null, "Tasty Soft Towels Concrete", 115, 96, 2 },
                    { 513, new DateTime(2017, 10, 11, 10, 32, 33, 361, DateTimeKind.Local).AddTicks(579), "Et similique sunt ut voluptas aut voluptatum iure dolores sunt.", null, "Brook Directives Avon", 21, 96, 2 },
                    { 512, new DateTime(2018, 4, 14, 15, 0, 27, 77, DateTimeKind.Local).AddTicks(2674), "Vero est dolores nemo laboriosam voluptate eos voluptatum architecto.", null, "Mission", 78, 96, 2 },
                    { 493, new DateTime(2018, 2, 19, 11, 23, 42, 781, DateTimeKind.Local).AddTicks(1262), "Deleniti dolores sunt.", null, "Handcrafted Intelligent", 55, 91, 2 },
                    { 492, new DateTime(2017, 11, 2, 20, 41, 29, 336, DateTimeKind.Local).AddTicks(2061), "Ratione ut non cum sapiente quia exercitationem repellendus rem.", null, "Rubber", 52, 91, 2 },
                    { 491, new DateTime(2019, 11, 3, 11, 3, 22, 775, DateTimeKind.Local).AddTicks(8007), "Qui voluptas impedit commodi aspernatur est iste cumque atque.", new DateTime(2021, 5, 11, 6, 22, 22, 36, DateTimeKind.Local).AddTicks(4685), "Fantastic Frozen Chicken auxiliary generating", 68, 91, 2 },
                    { 490, new DateTime(2019, 6, 22, 5, 34, 49, 90, DateTimeKind.Local).AddTicks(5810), "Ut voluptatibus placeat nulla ut cumque.", null, "project Tools, Computers & Clothing", 94, 91, 2 },
                    { 489, new DateTime(2018, 11, 28, 7, 0, 48, 453, DateTimeKind.Local).AddTicks(5740), "Voluptas earum sed ut est vel animi voluptatem.", null, "National panel Island", 28, 91, 2 },
                    { 449, new DateTime(2018, 7, 7, 3, 8, 54, 991, DateTimeKind.Local).AddTicks(9132), "In voluptates natus asperiores esse nam odio praesentium.", null, "EXE Green mesh", 33, 85, 2 },
                    { 448, new DateTime(2017, 11, 24, 13, 37, 6, 38, DateTimeKind.Local).AddTicks(2696), "Et ea itaque.", new DateTime(2020, 7, 3, 21, 44, 47, 320, DateTimeKind.Local).AddTicks(9291), "wireless Unbranded Steel Salad", 120, 85, 2 },
                    { 447, new DateTime(2018, 1, 5, 13, 23, 37, 530, DateTimeKind.Local).AddTicks(9289), "Enim reiciendis eaque et nesciunt.", new DateTime(2020, 9, 12, 15, 35, 8, 324, DateTimeKind.Local).AddTicks(2226), "Jersey", 107, 85, 2 },
                    { 446, new DateTime(2018, 2, 6, 17, 54, 54, 576, DateTimeKind.Local).AddTicks(3626), "Id exercitationem quia voluptates consequatur.", new DateTime(2020, 10, 19, 13, 12, 9, 848, DateTimeKind.Local).AddTicks(2967), "Architect New Jersey global", 46, 85, 2 },
                    { 495, new DateTime(2019, 9, 6, 5, 12, 12, 156, DateTimeKind.Local).AddTicks(7594), "Voluptatem non quis impedit earum aut rerum excepturi accusantium.", null, "Personal Loan Account Customer implement", 93, 92, 2 },
                    { 481, new DateTime(2017, 6, 28, 4, 35, 37, 948, DateTimeKind.Local).AddTicks(7195), "Voluptate nisi accusantium voluptas modi temporibus adipisci eius.", null, "upward-trending Internal secondary", 57, 90, 2 },
                    { 480, new DateTime(2017, 8, 30, 20, 10, 47, 65, DateTimeKind.Local).AddTicks(8393), "Tenetur distinctio vero velit et consectetur facilis voluptatem.", null, "Berkshire Rwanda Franc", 80, 90, 2 },
                    { 473, new DateTime(2018, 12, 31, 23, 19, 22, 360, DateTimeKind.Local).AddTicks(6318), "Ipsa aut veritatis quo laudantium aut et.", null, "transmitting", 49, 88, 2 },
                    { 420, new DateTime(2018, 5, 21, 5, 41, 4, 76, DateTimeKind.Local).AddTicks(7911), "Dolor tenetur ipsa expedita a enim odit.", null, "Director", 42, 79, 2 },
                    { 419, new DateTime(2017, 7, 26, 2, 59, 27, 516, DateTimeKind.Local).AddTicks(3701), "Vel non enim inventore.", null, "program Antarctica (the territory South of 60 deg S)", 69, 79, 2 },
                    { 418, new DateTime(2020, 3, 1, 16, 12, 37, 768, DateTimeKind.Local).AddTicks(4998), "Praesentium est molestiae.", new DateTime(2021, 5, 5, 2, 9, 11, 736, DateTimeKind.Local).AddTicks(4289), "China Mandatory", 120, 79, 2 },
                    { 417, new DateTime(2019, 8, 30, 16, 16, 41, 999, DateTimeKind.Local).AddTicks(6783), "Vero aut aut beatae aut ut et.", null, "Pennsylvania Pound Sterling", 34, 79, 2 },
                    { 416, new DateTime(2018, 1, 28, 14, 53, 2, 389, DateTimeKind.Local).AddTicks(9403), "Quo labore minus autem.", null, "fuchsia", 116, 79, 2 },
                    { 415, new DateTime(2018, 1, 28, 22, 20, 21, 434, DateTimeKind.Local).AddTicks(5198), "Similique non cupiditate.", new DateTime(2020, 8, 7, 14, 19, 58, 152, DateTimeKind.Local).AddTicks(3429), "Metrics", 62, 79, 2 },
                    { 408, new DateTime(2017, 6, 28, 12, 17, 34, 969, DateTimeKind.Local).AddTicks(7006), "Voluptatibus mollitia iste consequuntur eum magnam praesentium illo nostrum quis.", null, "rich", 90, 77, 2 },
                    { 407, new DateTime(2020, 5, 15, 13, 25, 1, 489, DateTimeKind.Local).AddTicks(1724), "Atque quod voluptas ullam sit quia voluptatem ad.", null, "one-to-one engage", 67, 77, 2 },
                    { 406, new DateTime(2017, 8, 26, 3, 57, 19, 174, DateTimeKind.Local).AddTicks(3673), "Fugiat asperiores enim qui sunt et.", new DateTime(2021, 4, 1, 14, 41, 1, 241, DateTimeKind.Local).AddTicks(2609), "Tasty Plastic Car harness Arizona", 67, 77, 2 },
                    { 405, new DateTime(2017, 6, 27, 1, 36, 16, 26, DateTimeKind.Local).AddTicks(6618), "Molestiae omnis qui esse dolorem voluptatem.", null, "Licensed Cotton Chicken Zimbabwe", 119, 77, 2 },
                    { 404, new DateTime(2019, 8, 5, 16, 27, 30, 125, DateTimeKind.Local).AddTicks(5228), "Nisi et consequatur qui qui eveniet error officia exercitationem provident.", null, "Tasty purple", 74, 77, 2 },
                    { 403, new DateTime(2020, 2, 5, 3, 38, 7, 28, DateTimeKind.Local).AddTicks(4139), "Modi quaerat eveniet quia aliquid maiores.", null, "transmitter", 66, 77, 2 },
                    { 479, new DateTime(2018, 11, 15, 11, 12, 31, 765, DateTimeKind.Local).AddTicks(3504), "Consequatur doloremque dicta dolorem eligendi dolores.", null, "Investment Account Intelligent Wooden Fish mission-critical", 83, 89, 2 },
                    { 421, new DateTime(2018, 1, 27, 10, 20, 34, 634, DateTimeKind.Local).AddTicks(1199), "Veritatis consequatur qui et rem non.", null, "Planner Falls 1080p", 97, 79, 2 },
                    { 478, new DateTime(2017, 11, 5, 20, 43, 0, 142, DateTimeKind.Local).AddTicks(4804), "Ut officiis consequatur voluptatibus iusto ut.", null, "Fresh", 47, 89, 2 },
                    { 476, new DateTime(2017, 8, 8, 12, 30, 24, 733, DateTimeKind.Local).AddTicks(4417), "Molestias quia eveniet officia similique omnis et amet et odit.", null, "24/7 optical hack", 61, 89, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 475, new DateTime(2020, 2, 29, 7, 13, 0, 677, DateTimeKind.Local).AddTicks(8906), "Sunt dolor temporibus.", null, "local", 62, 89, 2 },
                    { 474, new DateTime(2017, 8, 11, 0, 43, 33, 807, DateTimeKind.Local).AddTicks(372), "Expedita minima quis porro vero beatae.", null, "Point", 52, 89, 2 },
                    { 346, new DateTime(2019, 4, 20, 21, 42, 44, 411, DateTimeKind.Local).AddTicks(3281), "Laboriosam aut natus.", null, "Burg", 29, 65, 2 },
                    { 345, new DateTime(2018, 9, 12, 23, 1, 33, 598, DateTimeKind.Local).AddTicks(5900), "Impedit voluptatem expedita earum sunt eius expedita.", null, "Handmade Wooden Bike SCSI", 115, 65, 2 },
                    { 344, new DateTime(2020, 6, 20, 0, 13, 14, 424, DateTimeKind.Local).AddTicks(6946), "Eos fugit est.", null, "throughput bandwidth ADP", 39, 65, 2 },
                    { 343, new DateTime(2020, 6, 5, 22, 55, 58, 462, DateTimeKind.Local).AddTicks(5854), "Dolor et optio quas voluptatem beatae perferendis sapiente tenetur deserunt.", null, "Pass initiatives budgetary management", 58, 65, 2 },
                    { 342, new DateTime(2017, 10, 17, 0, 6, 48, 198, DateTimeKind.Local).AddTicks(331), "Aut enim culpa in autem repellendus ad et.", null, "bluetooth scalable virtual", 21, 65, 2 },
                    { 341, new DateTime(2019, 6, 24, 9, 50, 15, 50, DateTimeKind.Local).AddTicks(5306), "Et iste porro id molestias iure atque.", null, "Money Market Account New Taiwan Dollar Monitored", 97, 65, 2 },
                    { 340, new DateTime(2019, 8, 13, 13, 30, 49, 328, DateTimeKind.Local).AddTicks(3975), "Dolor itaque dolores magni voluptates et provident molestiae aut.", null, "Refined Steel Bacon", 29, 65, 2 },
                    { 339, new DateTime(2018, 7, 11, 15, 26, 14, 2, DateTimeKind.Local).AddTicks(6832), "Quod quibusdam blanditiis perferendis animi nulla aspernatur asperiores mollitia.", null, "Sleek Metal Hat Practical Cambridgeshire", 50, 65, 2 },
                    { 338, new DateTime(2018, 11, 1, 12, 33, 16, 893, DateTimeKind.Local).AddTicks(4680), "Quia id natus esse qui nihil esse quasi.", null, "Incredible Cotton Fish backing up Generic Cotton Shoes", 57, 65, 2 },
                    { 355, new DateTime(2019, 5, 12, 14, 28, 9, 164, DateTimeKind.Local).AddTicks(5879), "Nesciunt enim aut vel ipsam laboriosam.", null, "Quality Cambridgeshire Ports", 81, 66, 2 },
                    { 477, new DateTime(2017, 11, 3, 14, 15, 33, 726, DateTimeKind.Local).AddTicks(1723), "Sed blanditiis quas exercitationem vel nihil.", null, "deposit", 50, 89, 2 },
                    { 409, new DateTime(2017, 6, 26, 8, 43, 16, 90, DateTimeKind.Local).AddTicks(1353), "Omnis iusto quo aut.", null, "HDD", 93, 78, 2 },
                    { 410, new DateTime(2019, 1, 3, 19, 8, 15, 242, DateTimeKind.Local).AddTicks(7489), "Dolor aperiam fuga et.", null, "back-end Berkshire", 29, 78, 2 },
                    { 411, new DateTime(2020, 1, 27, 12, 30, 58, 747, DateTimeKind.Local).AddTicks(6858), "Sapiente eos ex.", null, "intangible", 97, 78, 2 },
                    { 472, new DateTime(2019, 12, 17, 1, 43, 47, 951, DateTimeKind.Local).AddTicks(4945), "Libero voluptas sunt quae voluptatibus nisi laudantium.", new DateTime(2021, 5, 12, 6, 17, 17, 609, DateTimeKind.Local).AddTicks(8709), "applications Coordinator models", 108, 88, 2 },
                    { 471, new DateTime(2020, 1, 3, 17, 31, 9, 712, DateTimeKind.Local).AddTicks(1421), "Molestiae consequuntur itaque modi voluptatum corrupti cupiditate.", new DateTime(2020, 12, 2, 5, 38, 32, 363, DateTimeKind.Local).AddTicks(3933), "Puerto Rico Generic Garden, Jewelery & Industrial", 24, 88, 2 },
                    { 470, new DateTime(2018, 9, 11, 19, 46, 26, 511, DateTimeKind.Local).AddTicks(2287), "Explicabo mollitia quidem quibusdam sit rem aut repellat veritatis itaque.", null, "next generation", 108, 88, 2 },
                    { 469, new DateTime(2019, 1, 6, 2, 27, 20, 783, DateTimeKind.Local).AddTicks(1322), "Qui corporis repellat qui voluptatum harum aspernatur asperiores.", null, "Handcrafted Cotton Shoes", 96, 88, 2 },
                    { 468, new DateTime(2019, 10, 23, 7, 32, 40, 618, DateTimeKind.Local).AddTicks(7956), "Molestiae veniam voluptatibus necessitatibus hic quae aut.", null, "Bedfordshire function", 74, 88, 2 },
                    { 467, new DateTime(2018, 9, 1, 1, 34, 59, 373, DateTimeKind.Local).AddTicks(4454), "Cupiditate placeat tempora aliquid incidunt eveniet ratione.", null, "niches", 85, 88, 2 },
                    { 466, new DateTime(2018, 10, 25, 23, 11, 56, 404, DateTimeKind.Local).AddTicks(8278), "Incidunt exercitationem fuga ut et perspiciatis veniam voluptatibus.", null, "mission-critical Fantastic Granite Towels Books, Health & Jewelery", 109, 88, 2 },
                    { 465, new DateTime(2019, 10, 25, 21, 28, 11, 497, DateTimeKind.Local).AddTicks(9179), "Qui est et.", null, "Mill bandwidth", 57, 88, 2 },
                    { 464, new DateTime(2019, 6, 11, 12, 26, 21, 945, DateTimeKind.Local).AddTicks(6115), "Omnis numquam consequatur et.", null, "deposit Gorgeous Soft Pizza", 106, 88, 2 },
                    { 463, new DateTime(2018, 7, 15, 22, 36, 4, 267, DateTimeKind.Local).AddTicks(4228), "Commodi officiis ut ut delectus asperiores eos fuga.", new DateTime(2020, 12, 6, 23, 12, 5, 447, DateTimeKind.Local).AddTicks(7361), "optical", 93, 87, 2 },
                    { 462, new DateTime(2020, 5, 11, 21, 8, 51, 696, DateTimeKind.Local).AddTicks(1969), "Illo ut officiis non praesentium sed aut ea est veniam.", null, "Refined Horizontal Manor", 97, 87, 2 },
                    { 461, new DateTime(2018, 2, 18, 23, 47, 13, 717, DateTimeKind.Local).AddTicks(4020), "Nesciunt aut corporis consequatur cupiditate dolorum.", null, "Drive", 50, 87, 2 },
                    { 460, new DateTime(2018, 4, 18, 15, 50, 57, 949, DateTimeKind.Local).AddTicks(3834), "Perferendis et ut molestias saepe nisi.", null, "Unbranded", 102, 87, 2 },
                    { 459, new DateTime(2018, 7, 23, 5, 25, 2, 309, DateTimeKind.Local).AddTicks(6180), "Aliquid laudantium optio illum consequatur officia sit voluptas.", null, "markets one-to-one", 75, 87, 2 },
                    { 443, new DateTime(2018, 10, 7, 21, 44, 25, 157, DateTimeKind.Local).AddTicks(3324), "Non quia voluptatem consequatur.", null, "Oklahoma Idaho Oklahoma", 58, 84, 2 },
                    { 442, new DateTime(2020, 1, 27, 17, 25, 22, 90, DateTimeKind.Local).AddTicks(2211), "Nostrum id debitis quia et eum tempore non eum.", null, "Human", 24, 84, 2 },
                    { 441, new DateTime(2018, 5, 10, 1, 23, 37, 850, DateTimeKind.Local).AddTicks(540), "Consequuntur qui ullam aliquam iusto labore sit vel qui inventore.", null, "copy", 95, 84, 2 },
                    { 440, new DateTime(2019, 11, 8, 16, 19, 7, 283, DateTimeKind.Local).AddTicks(5909), "Nisi et quia sint sequi.", null, "payment indexing Representative", 89, 84, 2 },
                    { 439, new DateTime(2017, 9, 20, 8, 34, 40, 769, DateTimeKind.Local).AddTicks(1724), "Facilis beatae quas provident ipsum maiores debitis magnam aliquam.", null, "metrics", 78, 84, 2 },
                    { 428, new DateTime(2019, 12, 9, 23, 27, 27, 270, DateTimeKind.Local).AddTicks(8387), "Unde enim sed natus voluptatem.", new DateTime(2021, 4, 18, 22, 27, 2, 68, DateTimeKind.Local).AddTicks(8152), "Texas mint green", 92, 80, 2 },
                    { 427, new DateTime(2018, 1, 15, 13, 6, 47, 791, DateTimeKind.Local).AddTicks(2176), "Neque dolorem consequatur ipsa perferendis amet.", null, "Fantastic Soft Shoes", 88, 80, 2 },
                    { 426, new DateTime(2020, 2, 12, 12, 50, 13, 908, DateTimeKind.Local).AddTicks(4070), "Laudantium voluptates corporis eligendi et repudiandae.", null, "GB", 71, 80, 2 },
                    { 425, new DateTime(2020, 2, 22, 4, 17, 11, 229, DateTimeKind.Local).AddTicks(9374), "Accusantium illum et consequuntur est.", null, "primary", 63, 80, 2 },
                    { 424, new DateTime(2019, 6, 16, 0, 13, 36, 357, DateTimeKind.Local).AddTicks(239), "Qui in dolore rem et ipsum vitae.", null, "Refined Wooden Sausages", 46, 80, 2 },
                    { 423, new DateTime(2017, 10, 27, 15, 29, 17, 433, DateTimeKind.Local).AddTicks(9726), "Quos consequatur et et sit placeat rem vel iure perferendis.", new DateTime(2020, 10, 18, 20, 58, 35, 464, DateTimeKind.Local).AddTicks(499), "Electronics", 75, 80, 2 },
                    { 422, new DateTime(2019, 12, 14, 15, 21, 51, 270, DateTimeKind.Local).AddTicks(7168), "Et atque natus reiciendis.", null, "Prairie Nepal Refined", 67, 80, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 414, new DateTime(2018, 6, 26, 0, 24, 46, 732, DateTimeKind.Local).AddTicks(1511), "Quia praesentium facilis et est iusto.", new DateTime(2020, 8, 20, 18, 18, 2, 858, DateTimeKind.Local).AddTicks(5327), "index", 37, 78, 2 },
                    { 413, new DateTime(2017, 9, 24, 13, 14, 36, 769, DateTimeKind.Local).AddTicks(4515), "Ea nihil tempora eligendi eveniet ducimus dolores quis.", null, "Armenian Dram Money Market Account Directives", 118, 78, 2 },
                    { 412, new DateTime(2020, 2, 28, 21, 22, 42, 582, DateTimeKind.Local).AddTicks(7497), "Culpa aut quas aut est quo soluta impedit tempora.", null, "Creek logistical Versatile", 76, 78, 2 },
                    { 353, new DateTime(2018, 8, 17, 20, 33, 0, 4, DateTimeKind.Local).AddTicks(8136), "Et qui veritatis non.", null, "Fantastic", 107, 66, 2 },
                    { 500, new DateTime(2020, 3, 13, 22, 34, 36, 790, DateTimeKind.Local).AddTicks(3561), "Ut dignissimos nulla necessitatibus et recusandae alias.", null, "Licensed yellow Colorado", 62, 93, 2 },
                    { 254, new DateTime(2018, 8, 1, 14, 43, 54, 281, DateTimeKind.Local).AddTicks(2843), "Molestiae omnis illo qui placeat et et.", null, "Steel", 79, 48, 2 },
                    { 246, new DateTime(2019, 7, 1, 18, 37, 35, 238, DateTimeKind.Local).AddTicks(3320), "Ipsa quasi iste nemo sed aut aut autem.", null, "sky blue Massachusetts enterprise", 73, 46, 2 },
                    { 93, new DateTime(2020, 1, 12, 16, 59, 34, 47, DateTimeKind.Local).AddTicks(3880), "Aut molestias at.", null, "Meadows", 62, 18, 2 },
                    { 92, new DateTime(2019, 4, 29, 18, 38, 16, 274, DateTimeKind.Local).AddTicks(3330), "Sit et sed debitis aliquam iusto doloremque.", null, "Frozen Operations bandwidth", 116, 18, 2 },
                    { 91, new DateTime(2020, 2, 9, 12, 6, 24, 790, DateTimeKind.Local).AddTicks(8631), "Quidem aut ipsam et.", null, "invoice Fresh", 113, 18, 2 },
                    { 90, new DateTime(2020, 5, 14, 14, 36, 52, 134, DateTimeKind.Local).AddTicks(6243), "Ut distinctio quae eos aut quam numquam.", new DateTime(2021, 5, 13, 22, 37, 19, 37, DateTimeKind.Local).AddTicks(1412), "Applications", 36, 18, 2 },
                    { 89, new DateTime(2017, 10, 10, 0, 8, 10, 107, DateTimeKind.Local).AddTicks(7559), "Ex vero et quam sit autem tenetur rerum.", null, "challenge", 41, 18, 2 },
                    { 88, new DateTime(2020, 3, 4, 7, 51, 58, 863, DateTimeKind.Local).AddTicks(4833), "Natus sint qui quasi ab impedit fugiat voluptas est tenetur.", null, "JBOD", 62, 18, 2 },
                    { 87, new DateTime(2018, 8, 30, 15, 31, 54, 16, DateTimeKind.Local).AddTicks(4555), "Explicabo similique itaque maxime itaque doloribus non rem.", new DateTime(2021, 6, 7, 17, 27, 19, 600, DateTimeKind.Local).AddTicks(9829), "Armenia", 114, 17, 2 },
                    { 86, new DateTime(2020, 5, 31, 14, 3, 3, 73, DateTimeKind.Local).AddTicks(8514), "Tempora pariatur iste molestiae voluptas autem.", null, "Estates", 51, 17, 2 },
                    { 80, new DateTime(2017, 11, 6, 13, 2, 33, 948, DateTimeKind.Local).AddTicks(7883), "Optio vitae qui et mollitia.", null, "engage", 75, 13, 2 },
                    { 79, new DateTime(2018, 10, 27, 23, 20, 4, 156, DateTimeKind.Local).AddTicks(4513), "Id possimus aliquid quidem architecto unde in quasi.", new DateTime(2020, 11, 3, 18, 14, 13, 289, DateTimeKind.Local).AddTicks(2928), "National", 57, 13, 2 },
                    { 78, new DateTime(2019, 12, 9, 18, 41, 47, 38, DateTimeKind.Local).AddTicks(3547), "Qui maxime ut modi maxime repellat aliquid voluptas.", null, "encompassing Bedfordshire", 82, 13, 2 },
                    { 77, new DateTime(2019, 4, 15, 10, 10, 45, 870, DateTimeKind.Local).AddTicks(3821), "Ad deleniti porro.", null, "Licensed Rubber Pants", 74, 13, 2 },
                    { 83, new DateTime(2017, 11, 21, 18, 5, 40, 512, DateTimeKind.Local).AddTicks(822), "Qui ea dolore nihil voluptatum voluptas.", null, "e-markets Soft Maine", 25, 14, 2 },
                    { 94, new DateTime(2018, 6, 13, 8, 45, 12, 589, DateTimeKind.Local).AddTicks(3908), "Nostrum ipsum ea quasi.", null, "Sleek Wooden Car", 117, 18, 2 },
                    { 82, new DateTime(2017, 8, 3, 17, 57, 0, 90, DateTimeKind.Local).AddTicks(3991), "Incidunt dicta ex animi perspiciatis libero.", new DateTime(2020, 12, 18, 18, 15, 16, 643, DateTimeKind.Local).AddTicks(1330), "grey", 119, 14, 2 },
                    { 85, new DateTime(2018, 8, 23, 6, 1, 12, 579, DateTimeKind.Local).AddTicks(2432), "Harum mollitia cumque maxime alias voluptatem aut.", null, "cultivate", 96, 15, 2 },
                    { 84, new DateTime(2019, 7, 18, 5, 4, 53, 245, DateTimeKind.Local).AddTicks(3073), "Harum id architecto et.", null, "Zambian Kwacha morph", 74, 15, 2 },
                    { 68, new DateTime(2019, 1, 12, 19, 20, 44, 687, DateTimeKind.Local).AddTicks(8614), "Sit repellat ratione dolore fuga voluptatem quia iste.", new DateTime(2020, 7, 25, 9, 36, 43, 441, DateTimeKind.Local).AddTicks(8220), "Forint Burkina Faso", 102, 11, 2 },
                    { 67, new DateTime(2019, 2, 6, 14, 21, 3, 980, DateTimeKind.Local).AddTicks(8730), "Velit ratione harum.", null, "Turkish Lira", 51, 11, 2 },
                    { 66, new DateTime(2019, 7, 9, 13, 29, 40, 420, DateTimeKind.Local).AddTicks(6910), "Est dolor doloribus a.", null, "deposit Profound", 96, 11, 2 },
                    { 65, new DateTime(2017, 11, 6, 23, 49, 18, 922, DateTimeKind.Local).AddTicks(5920), "Eveniet molestiae architecto accusantium possimus cupiditate rem porro.", null, "parsing aggregate", 103, 11, 2 },
                    { 76, new DateTime(2019, 6, 4, 21, 7, 53, 502, DateTimeKind.Local).AddTicks(2409), "Rerum natus ut.", null, "Orchestrator", 77, 12, 2 },
                    { 75, new DateTime(2020, 2, 22, 14, 31, 2, 762, DateTimeKind.Local).AddTicks(8221), "Commodi totam ea.", new DateTime(2021, 1, 4, 3, 34, 34, 720, DateTimeKind.Local).AddTicks(403), "Japan mission-critical hard drive", 114, 12, 2 },
                    { 74, new DateTime(2018, 12, 10, 2, 0, 32, 533, DateTimeKind.Local).AddTicks(3322), "Quibusdam est cumque mollitia est deserunt aut aut.", null, "cyan", 87, 12, 2 },
                    { 73, new DateTime(2020, 5, 24, 12, 57, 23, 942, DateTimeKind.Local).AddTicks(5773), "Praesentium aut perspiciatis voluptatem omnis et vel exercitationem.", null, "Streamlined Robust Practical", 84, 12, 2 },
                    { 72, new DateTime(2019, 1, 2, 0, 17, 19, 600, DateTimeKind.Local).AddTicks(5276), "Non et quisquam sed adipisci repudiandae sed quod ea.", null, "Mozambique", 100, 12, 2 },
                    { 71, new DateTime(2020, 1, 20, 15, 59, 10, 927, DateTimeKind.Local).AddTicks(3488), "Aut nulla quo nulla odio alias voluptatem occaecati in iusto.", new DateTime(2020, 11, 18, 17, 23, 56, 911, DateTimeKind.Local).AddTicks(6340), "Checking Account Ferry", 35, 12, 2 },
                    { 70, new DateTime(2018, 5, 27, 1, 59, 15, 415, DateTimeKind.Local).AddTicks(3545), "Veritatis atque sint vero libero est quos sed qui.", null, "Officer", 64, 12, 2 },
                    { 81, new DateTime(2017, 8, 5, 18, 52, 20, 95, DateTimeKind.Local).AddTicks(6044), "Nihil aut laborum id est.", null, "Checking Account", 122, 14, 2 },
                    { 69, new DateTime(2019, 1, 13, 2, 56, 27, 964, DateTimeKind.Local).AddTicks(7509), "Cupiditate quo mollitia temporibus non ut omnis id ea fugit.", null, "Delaware Savings Account", 109, 12, 2 },
                    { 95, new DateTime(2018, 8, 9, 22, 50, 44, 846, DateTimeKind.Local).AddTicks(5259), "Voluptate eligendi quia.", new DateTime(2020, 8, 18, 5, 39, 29, 947, DateTimeKind.Local).AddTicks(7512), "attitude yellow", 59, 18, 2 },
                    { 97, new DateTime(2019, 8, 14, 19, 52, 38, 688, DateTimeKind.Local).AddTicks(4275), "Deleniti ut et veniam.", null, "programming Investment Account", 122, 18, 2 },
                    { 104, new DateTime(2019, 3, 29, 0, 35, 48, 323, DateTimeKind.Local).AddTicks(1459), "Quo impedit nesciunt assumenda ut ab odit voluptatem.", null, "Tools, Industrial & Games virtual", 33, 19, 2 },
                    { 103, new DateTime(2018, 9, 15, 14, 25, 54, 890, DateTimeKind.Local).AddTicks(9093), "Quam sunt magni in.", null, "Director Estates", 66, 19, 2 },
                    { 102, new DateTime(2018, 7, 16, 14, 43, 29, 138, DateTimeKind.Local).AddTicks(1798), "Necessitatibus illo magnam mollitia quis minus nulla iste rerum.", null, "Palladium online", 108, 19, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 101, new DateTime(2020, 5, 9, 23, 1, 9, 307, DateTimeKind.Local).AddTicks(4858), "Quia numquam eligendi.", null, "Cotton", 81, 19, 2 },
                    { 100, new DateTime(2017, 11, 28, 1, 47, 24, 872, DateTimeKind.Local).AddTicks(9588), "Amet aspernatur voluptatibus quisquam enim sapiente omnis.", null, "indexing", 96, 19, 2 },
                    { 99, new DateTime(2018, 7, 7, 18, 58, 36, 720, DateTimeKind.Local).AddTicks(3735), "Ad eius id quo ducimus et et asperiores officia.", null, "Buckinghamshire", 91, 19, 2 },
                    { 98, new DateTime(2018, 12, 19, 16, 17, 59, 257, DateTimeKind.Local).AddTicks(9394), "At dolor ex occaecati molestiae fuga.", new DateTime(2021, 4, 13, 1, 54, 27, 250, DateTimeKind.Local).AddTicks(5945), "pricing structure engineer", 81, 19, 2 },
                    { 157, new DateTime(2019, 9, 16, 14, 1, 11, 361, DateTimeKind.Local).AddTicks(5796), "Et reiciendis neque eaque exercitationem labore consequatur.", new DateTime(2021, 2, 10, 19, 45, 17, 788, DateTimeKind.Local).AddTicks(5284), "parse systemic Lithuanian Litas", 37, 30, 2 },
                    { 156, new DateTime(2018, 1, 3, 10, 52, 11, 381, DateTimeKind.Local).AddTicks(1589), "Iste suscipit soluta voluptatem rerum excepturi dolor laudantium.", null, "transition", 59, 30, 2 },
                    { 155, new DateTime(2017, 10, 30, 0, 9, 16, 262, DateTimeKind.Local).AddTicks(9990), "Et saepe omnis tenetur.", new DateTime(2021, 2, 26, 4, 30, 23, 195, DateTimeKind.Local).AddTicks(5303), "reinvent invoice Berkshire", 62, 30, 2 },
                    { 154, new DateTime(2020, 2, 28, 10, 16, 56, 594, DateTimeKind.Local).AddTicks(3214), "Nobis quia quod.", null, "Small Avon open-source", 87, 30, 2 },
                    { 153, new DateTime(2018, 12, 22, 23, 43, 50, 393, DateTimeKind.Local).AddTicks(618), "Et libero error similique voluptatum quia aut ipsum.", null, "1080p Rustic", 93, 30, 2 },
                    { 152, new DateTime(2017, 11, 24, 1, 3, 25, 342, DateTimeKind.Local).AddTicks(2179), "Ut omnis illo illum quis.", null, "bypass", 54, 30, 2 },
                    { 96, new DateTime(2020, 2, 5, 0, 30, 38, 47, DateTimeKind.Local).AddTicks(1332), "Corporis quod ad officiis illo quia eveniet repellat nisi id.", new DateTime(2021, 4, 13, 15, 40, 7, 519, DateTimeKind.Local).AddTicks(1458), "Applications bandwidth Refined Steel Salad", 20, 18, 2 },
                    { 124, new DateTime(2020, 3, 7, 12, 13, 52, 184, DateTimeKind.Local).AddTicks(5860), "Aspernatur molestias temporibus illo placeat eum.", null, "XML Nebraska Andorra", 27, 25, 2 },
                    { 122, new DateTime(2018, 3, 2, 6, 41, 48, 937, DateTimeKind.Local).AddTicks(988), "Odit ipsam nihil.", null, "Heights installation", 91, 25, 2 },
                    { 121, new DateTime(2020, 1, 7, 18, 54, 5, 913, DateTimeKind.Local).AddTicks(6495), "Labore rerum quia illo eius et fugit.", null, "applications attitude hacking", 84, 25, 2 },
                    { 120, new DateTime(2018, 2, 2, 2, 20, 30, 243, DateTimeKind.Local).AddTicks(536), "Officiis enim est rerum temporibus doloremque est eum aut.", null, "implementation Intelligent Steel Pizza", 54, 25, 2 },
                    { 119, new DateTime(2019, 3, 3, 9, 0, 14, 565, DateTimeKind.Local).AddTicks(8776), "Sed atque saepe aut sed exercitationem aspernatur fugiat qui.", null, "Buckinghamshire", 79, 25, 2 },
                    { 118, new DateTime(2019, 4, 16, 22, 56, 33, 8, DateTimeKind.Local).AddTicks(1552), "In aperiam officia modi nobis quis a et alias voluptas.", new DateTime(2020, 8, 7, 5, 39, 33, 741, DateTimeKind.Local).AddTicks(2623), "hack", 27, 25, 2 },
                    { 117, new DateTime(2018, 6, 3, 3, 57, 41, 317, DateTimeKind.Local).AddTicks(5228), "Consequuntur eum fugit et est sit et.", null, "copy", 108, 25, 2 },
                    { 116, new DateTime(2017, 8, 27, 0, 27, 46, 892, DateTimeKind.Local).AddTicks(2867), "Consequatur sint omnis maxime quo dolores.", null, "Personal Loan Account", 52, 25, 2 },
                    { 115, new DateTime(2019, 9, 27, 4, 0, 59, 443, DateTimeKind.Local).AddTicks(1438), "Rerum dolores dolor dolores facilis qui dignissimos voluptatum.", null, "fuchsia", 26, 25, 2 },
                    { 151, new DateTime(2018, 10, 20, 11, 41, 0, 911, DateTimeKind.Local).AddTicks(4010), "Animi quo dignissimos reiciendis aliquid delectus.", null, "mindshare Beauty", 99, 29, 2 },
                    { 150, new DateTime(2019, 6, 9, 22, 8, 40, 96, DateTimeKind.Local).AddTicks(6903), "Eos inventore blanditiis facere.", null, "Fantastic Frozen Computer", 57, 29, 2 },
                    { 149, new DateTime(2018, 1, 31, 5, 15, 27, 304, DateTimeKind.Local).AddTicks(4214), "Beatae veniam dolores ut voluptas ea nesciunt.", new DateTime(2021, 4, 29, 6, 1, 49, 118, DateTimeKind.Local).AddTicks(5039), "plug-and-play Bedfordshire Electronics, Outdoors & Shoes", 59, 29, 2 },
                    { 148, new DateTime(2019, 8, 23, 4, 50, 41, 145, DateTimeKind.Local).AddTicks(1925), "Commodi vel labore numquam repudiandae qui fugit voluptatem exercitationem sint.", new DateTime(2021, 5, 26, 15, 40, 8, 473, DateTimeKind.Local).AddTicks(4603), "Armenian Dram monitor", 20, 29, 2 },
                    { 147, new DateTime(2018, 4, 10, 9, 21, 58, 334, DateTimeKind.Local).AddTicks(6800), "Voluptatem est eius voluptatum et aut.", null, "interface", 28, 29, 2 },
                    { 123, new DateTime(2018, 5, 15, 5, 34, 45, 625, DateTimeKind.Local).AddTicks(6254), "Eligendi aliquid architecto.", null, "Incredible Fresh Chips", 22, 25, 2 },
                    { 45, new DateTime(2020, 6, 18, 12, 8, 26, 501, DateTimeKind.Local).AddTicks(9879), "Vel perferendis recusandae ducimus accusamus.", null, "Borders fresh-thinking Books", 80, 8, 2 },
                    { 44, new DateTime(2019, 1, 28, 2, 32, 0, 890, DateTimeKind.Local).AddTicks(4710), "Architecto voluptate modi omnis voluptate.", null, "Lights Specialist IB", 119, 8, 2 },
                    { 43, new DateTime(2019, 3, 27, 7, 15, 22, 507, DateTimeKind.Local).AddTicks(7319), "Animi veritatis tempora nihil eligendi harum et temporibus deleniti.", null, "seize invoice", 98, 8, 2 },
                    { 62, new DateTime(2020, 4, 25, 0, 9, 45, 852, DateTimeKind.Local).AddTicks(258), "Quod omnis tenetur illo.", null, "interfaces", 81, 10, 2 },
                    { 61, new DateTime(2020, 5, 20, 18, 37, 0, 13, DateTimeKind.Local).AddTicks(8642), "Eos eos quaerat odit consectetur dolor.", new DateTime(2021, 5, 22, 3, 19, 10, 168, DateTimeKind.Local).AddTicks(3851), "Manors transition interfaces", 110, 10, 2 },
                    { 60, new DateTime(2019, 10, 1, 2, 51, 6, 543, DateTimeKind.Local).AddTicks(9548), "Quasi rerum in quia molestias necessitatibus.", null, "parse bypassing pink", 80, 10, 2 },
                    { 59, new DateTime(2019, 12, 10, 9, 11, 47, 83, DateTimeKind.Local).AddTicks(3196), "Eius ut minus aliquam.", null, "Pre-emptive Plaza", 99, 10, 2 },
                    { 58, new DateTime(2018, 6, 9, 20, 52, 17, 403, DateTimeKind.Local).AddTicks(1764), "Sed iusto rerum suscipit non dolorum eveniet.", null, "Tasty Borders transmit", 63, 10, 2 },
                    { 57, new DateTime(2019, 11, 28, 7, 44, 0, 653, DateTimeKind.Local).AddTicks(2117), "Molestias officia voluptates sit magni temporibus et.", null, "Trail Representative", 96, 10, 2 },
                    { 56, new DateTime(2018, 2, 6, 0, 19, 57, 707, DateTimeKind.Local).AddTicks(2606), "Eos expedita ducimus est reiciendis.", null, "Montana", 33, 10, 2 },
                    { 515, new DateTime(2017, 10, 31, 12, 39, 16, 990, DateTimeKind.Local).AddTicks(799), "Eveniet nihil asperiores esse minima.", null, "index", 23, 97, 2 },
                    { 41, new DateTime(2019, 5, 22, 8, 5, 8, 223, DateTimeKind.Local).AddTicks(902), "Facere hic accusantium blanditiis eos quam est vero est.", null, "24/7", 77, 7, 2 },
                    { 40, new DateTime(2020, 5, 26, 0, 43, 14, 552, DateTimeKind.Local).AddTicks(5600), "Ullam praesentium deleniti repellat veniam totam asperiores sunt rerum.", null, "Rubber", 89, 7, 2 },
                    { 39, new DateTime(2017, 7, 4, 3, 56, 55, 101, DateTimeKind.Local).AddTicks(4795), "Rerum impedit aliquam facilis dolore perspiciatis occaecati amet provident.", null, "PCI Home Loan Account", 100, 7, 2 },
                    { 38, new DateTime(2019, 2, 26, 9, 22, 39, 312, DateTimeKind.Local).AddTicks(8783), "Enim alias vel est corporis nulla iste.", new DateTime(2021, 2, 25, 2, 46, 51, 166, DateTimeKind.Local).AddTicks(9257), "redundant Handmade Concrete Fish Refined Rubber Chair", 62, 7, 2 },
                    { 37, new DateTime(2019, 7, 24, 22, 47, 12, 232, DateTimeKind.Local).AddTicks(7505), "Ullam voluptas sunt.", null, "open-source South Dakota Concrete", 93, 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 63, new DateTime(2018, 12, 30, 4, 42, 7, 596, DateTimeKind.Local).AddTicks(8725), "Iure consequuntur dignissimos sed est.", new DateTime(2020, 11, 8, 18, 32, 39, 845, DateTimeKind.Local).AddTicks(6543), "black Small", 87, 10, 2 },
                    { 36, new DateTime(2019, 7, 9, 2, 27, 59, 109, DateTimeKind.Local).AddTicks(3219), "Voluptates rerum quo veniam beatae expedita.", null, "Views", 91, 7, 2 },
                    { 34, new DateTime(2020, 1, 21, 23, 38, 26, 350, DateTimeKind.Local).AddTicks(7675), "Optio reiciendis sequi reprehenderit aspernatur qui dolorem.", null, "Iowa magenta", 122, 7, 2 },
                    { 33, new DateTime(2019, 5, 2, 7, 51, 45, 234, DateTimeKind.Local).AddTicks(1543), "Quidem rem porro nobis est rerum quia accusantium corporis.", null, "Suriname", 39, 7, 2 },
                    { 32, new DateTime(2017, 7, 13, 20, 30, 5, 516, DateTimeKind.Local).AddTicks(8860), "Ducimus distinctio veniam accusamus omnis et magni.", null, "South Carolina e-business", 34, 7, 2 },
                    { 31, new DateTime(2018, 5, 22, 3, 41, 22, 284, DateTimeKind.Local).AddTicks(6408), "Ratione modi voluptatibus pariatur repudiandae consectetur tempora quia mollitia.", null, "Massachusetts Directives", 78, 6, 2 },
                    { 55, new DateTime(2019, 2, 16, 9, 16, 45, 574, DateTimeKind.Local).AddTicks(9804), "Vel esse architecto.", null, "Organic azure Metal", 32, 9, 2 },
                    { 54, new DateTime(2019, 10, 11, 11, 54, 34, 344, DateTimeKind.Local).AddTicks(7046), "Suscipit voluptatem ipsa non voluptate et harum.", null, "Liaison", 72, 9, 2 },
                    { 53, new DateTime(2017, 10, 8, 9, 29, 20, 633, DateTimeKind.Local).AddTicks(371), "Saepe occaecati non alias.", null, "algorithm", 72, 9, 2 },
                    { 52, new DateTime(2017, 7, 1, 3, 8, 1, 986, DateTimeKind.Local).AddTicks(1707), "Iure distinctio rerum doloribus nulla optio similique molestias quos id.", new DateTime(2020, 10, 6, 1, 0, 50, 780, DateTimeKind.Local).AddTicks(7284), "holistic Tasty Plastic Soap", 22, 9, 2 },
                    { 51, new DateTime(2018, 8, 13, 6, 31, 55, 407, DateTimeKind.Local).AddTicks(1035), "Sit sint et molestias dolorum architecto at animi animi.", null, "Officer North Carolina", 117, 9, 2 },
                    { 50, new DateTime(2018, 10, 23, 0, 52, 32, 972, DateTimeKind.Local).AddTicks(4208), "Placeat sed magni dolorum.", null, "quantifying", 63, 9, 2 },
                    { 49, new DateTime(2018, 7, 20, 10, 50, 43, 702, DateTimeKind.Local).AddTicks(5354), "Qui rerum non corrupti est exercitationem.", new DateTime(2020, 11, 26, 12, 1, 53, 635, DateTimeKind.Local).AddTicks(9258), "Cuban Peso Handmade Wooden Chair Cloned", 80, 9, 2 },
                    { 48, new DateTime(2017, 12, 8, 3, 12, 26, 191, DateTimeKind.Local).AddTicks(4069), "Veniam officia ab distinctio dolores non sunt nemo hic aut.", new DateTime(2020, 8, 13, 6, 54, 17, 531, DateTimeKind.Local).AddTicks(3629), "solid state monitor Creek", 102, 9, 2 },
                    { 47, new DateTime(2018, 12, 16, 7, 50, 51, 961, DateTimeKind.Local).AddTicks(9749), "Cumque aut et est eius non.", null, "logistical Incredible Wooden Chips real-time", 65, 9, 2 },
                    { 35, new DateTime(2019, 9, 10, 22, 27, 54, 694, DateTimeKind.Local).AddTicks(4614), "Nihil adipisci necessitatibus error ut.", null, "invoice", 62, 7, 2 },
                    { 64, new DateTime(2018, 2, 11, 17, 6, 46, 516, DateTimeKind.Local).AddTicks(7097), "Esse eius nemo.", new DateTime(2020, 8, 17, 23, 14, 38, 114, DateTimeKind.Local).AddTicks(2835), "Applications virtual", 74, 10, 2 },
                    { 19, new DateTime(2019, 3, 4, 18, 49, 26, 773, DateTimeKind.Local).AddTicks(3234), "Enim molestiae id explicabo quisquam enim sint fuga.", null, "Frozen", 110, 4, 2 },
                    { 20, new DateTime(2018, 3, 12, 0, 26, 9, 551, DateTimeKind.Local).AddTicks(9860), "Consequuntur porro voluptas dolor molestiae harum et.", null, "AI", 115, 4, 2 },
                    { 42, new DateTime(2019, 5, 22, 17, 1, 42, 491, DateTimeKind.Local).AddTicks(8181), "Repellendus est sequi animi quos ut.", null, "strategic turn-key", 46, 8, 2 },
                    { 18, new DateTime(2019, 12, 19, 21, 6, 29, 176, DateTimeKind.Local).AddTicks(7226), "Debitis quia odio doloremque error dicta quia natus rerum aut.", null, "Sleek", 83, 3, 2 },
                    { 17, new DateTime(2017, 11, 23, 19, 16, 9, 140, DateTimeKind.Local).AddTicks(4668), "Atque occaecati officiis non rerum.", null, "Liaison upward-trending", 97, 3, 2 },
                    { 16, new DateTime(2018, 7, 5, 16, 59, 24, 55, DateTimeKind.Local).AddTicks(3315), "Accusantium ea magni exercitationem et perferendis temporibus.", null, "Knoll Principal redundant", 105, 3, 2 },
                    { 15, new DateTime(2019, 8, 27, 23, 15, 57, 986, DateTimeKind.Local).AddTicks(9782), "Optio eum aut sunt cum nam.", null, "online", 89, 3, 2 },
                    { 14, new DateTime(2020, 3, 24, 2, 28, 4, 778, DateTimeKind.Local).AddTicks(6122), "Aliquam laboriosam consequatur qui.", null, "Intelligent Granite Mouse", 51, 3, 2 },
                    { 13, new DateTime(2019, 2, 5, 7, 59, 48, 101, DateTimeKind.Local).AddTicks(3258), "Aut tenetur voluptas quasi esse.", new DateTime(2020, 12, 4, 8, 46, 2, 82, DateTimeKind.Local).AddTicks(1778), "Auto Loan Account Cambridgeshire", 82, 3, 2 },
                    { 12, new DateTime(2017, 11, 30, 17, 58, 7, 288, DateTimeKind.Local).AddTicks(7592), "Vel sed ipsam.", null, "mesh Assimilated Fundamental", 76, 3, 2 },
                    { 11, new DateTime(2020, 3, 23, 9, 49, 8, 521, DateTimeKind.Local).AddTicks(2649), "Explicabo illo sed qui cupiditate sapiente ut eligendi repellat.", null, "online incentivize", 74, 3, 2 },
                    { 10, new DateTime(2020, 4, 14, 15, 55, 4, 403, DateTimeKind.Local).AddTicks(1688), "Iure sequi unde.", null, "navigate", 59, 2, 2 },
                    { 9, new DateTime(2020, 6, 19, 14, 42, 55, 73, DateTimeKind.Local).AddTicks(8847), "Rerum iure soluta consequatur velit aut.", null, "Borders Mountain", 26, 2, 2 },
                    { 8, new DateTime(2019, 5, 7, 23, 29, 10, 58, DateTimeKind.Local).AddTicks(2950), "Voluptas nostrum sint.", null, "payment methodologies", 68, 2, 2 },
                    { 7, new DateTime(2018, 7, 10, 19, 21, 12, 88, DateTimeKind.Local).AddTicks(6153), "Et rerum ad.", null, "Automotive & Tools transitional bifurcated", 87, 2, 2 },
                    { 6, new DateTime(2020, 5, 21, 17, 56, 53, 811, DateTimeKind.Local).AddTicks(7818), "Reiciendis iusto rerum non et aut eaque.", null, "world-class Circles", 109, 2, 2 },
                    { 5, new DateTime(2018, 6, 15, 9, 3, 48, 73, DateTimeKind.Local).AddTicks(2466), "Earum blanditiis repellendus qui magni aliquam quisquam consequatur odio ducimus.", null, "mobile Organized", 81, 2, 2 },
                    { 4, new DateTime(2018, 10, 19, 3, 58, 34, 804, DateTimeKind.Local).AddTicks(5103), "Delectus quibusdam id quia iure neque maiores molestias sed aut.", null, "withdrawal contextually-based", 85, 2, 2 },
                    { 3, new DateTime(2017, 8, 16, 9, 13, 44, 577, DateTimeKind.Local).AddTicks(3845), "Sint voluptatem quas.", new DateTime(2020, 9, 9, 9, 34, 47, 460, DateTimeKind.Local).AddTicks(2160), "bypass", 75, 2, 2 },
                    { 2, new DateTime(2019, 2, 15, 18, 6, 52, 60, DateTimeKind.Local).AddTicks(666), "Eum a eum.", null, "product Direct utilize", 66, 2, 2 },
                    { 1, new DateTime(2020, 5, 16, 1, 50, 46, 86, DateTimeKind.Local).AddTicks(832), "Quo sint aut et ea voluptatem omnis ut.", null, "real-time", 51, 2, 2 },
                    { 30, new DateTime(2018, 1, 9, 15, 9, 46, 744, DateTimeKind.Local).AddTicks(9678), "Quasi possimus corrupti iure et repudiandae nulla deleniti.", null, "website Strategist matrix", 118, 5, 2 },
                    { 29, new DateTime(2019, 1, 18, 0, 51, 55, 649, DateTimeKind.Local).AddTicks(646), "Voluptas quibusdam praesentium non.", null, "green", 83, 5, 2 },
                    { 28, new DateTime(2018, 6, 29, 12, 38, 34, 572, DateTimeKind.Local).AddTicks(1170), "Voluptatem qui molestiae odio qui.", null, "Libyan Dinar", 46, 5, 2 },
                    { 27, new DateTime(2018, 8, 17, 4, 10, 49, 218, DateTimeKind.Local).AddTicks(4558), "Aliquam assumenda omnis perspiciatis.", null, "Berkshire", 49, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 26, new DateTime(2018, 3, 7, 23, 37, 8, 626, DateTimeKind.Local).AddTicks(4819), "Omnis magnam voluptatem quia placeat assumenda aliquam.", null, "Customer innovate Cambridgeshire", 122, 5, 2 },
                    { 25, new DateTime(2018, 9, 16, 6, 42, 38, 616, DateTimeKind.Local).AddTicks(1575), "Non fugit commodi reiciendis praesentium qui.", null, "teal", 61, 5, 2 },
                    { 24, new DateTime(2017, 11, 16, 10, 24, 2, 321, DateTimeKind.Local).AddTicks(4674), "Et et quam.", new DateTime(2021, 1, 31, 14, 9, 24, 561, DateTimeKind.Local).AddTicks(2654), "payment", 65, 5, 2 },
                    { 23, new DateTime(2019, 5, 12, 16, 48, 53, 19, DateTimeKind.Local).AddTicks(5273), "Et repudiandae labore deserunt magnam est eum explicabo.", null, "Handmade Frozen Sausages gold infomediaries", 43, 5, 2 },
                    { 22, new DateTime(2018, 3, 24, 4, 6, 14, 321, DateTimeKind.Local).AddTicks(5285), "Iure nostrum officiis suscipit et rerum.", null, "infrastructures", 53, 5, 2 },
                    { 21, new DateTime(2019, 10, 15, 5, 20, 10, 194, DateTimeKind.Local).AddTicks(9772), "Rem nisi nemo exercitationem dolorem unde consequuntur porro et ipsum.", null, "Rustic Fresh Towels", 91, 5, 2 },
                    { 105, new DateTime(2019, 5, 23, 22, 9, 15, 156, DateTimeKind.Local).AddTicks(1863), "Pariatur aut pariatur id quisquam nihil vel fuga sapiente consectetur.", null, "Money Market Account impactful", 56, 19, 2 },
                    { 247, new DateTime(2020, 3, 13, 20, 13, 5, 550, DateTimeKind.Local).AddTicks(4838), "Quo saepe odio.", new DateTime(2020, 7, 16, 6, 34, 9, 805, DateTimeKind.Local).AddTicks(3894), "San Marino backing up", 117, 46, 2 },
                    { 106, new DateTime(2018, 8, 27, 2, 19, 50, 941, DateTimeKind.Local).AddTicks(9889), "Exercitationem enim accusantium.", null, "Avon invoice", 86, 19, 2 },
                    { 108, new DateTime(2018, 1, 5, 4, 30, 46, 697, DateTimeKind.Local).AddTicks(9142), "Est reiciendis voluptas iste quod.", new DateTime(2020, 6, 23, 7, 21, 57, 365, DateTimeKind.Local).AddTicks(3253), "Clothing, Outdoors & Games", 25, 20, 2 },
                    { 253, new DateTime(2019, 11, 19, 10, 32, 38, 440, DateTimeKind.Local).AddTicks(4178), "Aut voluptatibus est dolor placeat aut placeat eos et.", null, "parsing clicks-and-mortar", 52, 47, 2 },
                    { 252, new DateTime(2018, 9, 4, 4, 33, 0, 798, DateTimeKind.Local).AddTicks(3252), "Rerum quasi commodi dolorem asperiores eum doloribus suscipit aut cupiditate.", null, "XML Licensed Plastic Soap", 50, 47, 2 },
                    { 251, new DateTime(2020, 5, 24, 14, 50, 7, 906, DateTimeKind.Local).AddTicks(918), "Recusandae repudiandae rerum.", null, "Automotive Port French Southern Territories", 86, 47, 2 },
                    { 250, new DateTime(2020, 5, 3, 10, 53, 18, 508, DateTimeKind.Local).AddTicks(7646), "Earum dolores eaque quaerat sint nam consequuntur est eaque beatae.", null, "orchestrate", 83, 47, 2 },
                    { 249, new DateTime(2018, 9, 1, 18, 45, 18, 133, DateTimeKind.Local).AddTicks(2727), "Expedita assumenda porro ea et ipsa facere.", null, "South Africa Glen generating", 23, 47, 2 },
                    { 248, new DateTime(2018, 7, 11, 22, 13, 6, 548, DateTimeKind.Local).AddTicks(7327), "Est sint eos.", new DateTime(2021, 4, 20, 8, 3, 1, 848, DateTimeKind.Local).AddTicks(2950), "grey Customer", 89, 47, 2 },
                    { 230, new DateTime(2017, 11, 5, 17, 13, 4, 310, DateTimeKind.Local).AddTicks(2895), "Illo minus dignissimos.", null, "Berkshire", 63, 44, 2 },
                    { 229, new DateTime(2019, 6, 11, 7, 23, 27, 287, DateTimeKind.Local).AddTicks(3198), "Numquam voluptates officia velit aut.", null, "panel system", 56, 44, 2 },
                    { 228, new DateTime(2017, 12, 12, 5, 32, 48, 959, DateTimeKind.Local).AddTicks(5634), "Tempora ut excepturi aspernatur vel fugiat commodi architecto incidunt odit.", new DateTime(2020, 8, 2, 6, 21, 11, 660, DateTimeKind.Local).AddTicks(4174), "Handcrafted Assimilated", 66, 44, 2 },
                    { 227, new DateTime(2017, 11, 21, 8, 29, 2, 609, DateTimeKind.Local).AddTicks(3109), "Officia et repellat et tempore.", null, "Home Usability", 93, 44, 2 },
                    { 226, new DateTime(2018, 12, 4, 7, 51, 37, 915, DateTimeKind.Local).AddTicks(1777), "Ad sit nihil illum libero.", new DateTime(2020, 12, 17, 11, 23, 34, 606, DateTimeKind.Local).AddTicks(4176), "Brazilian Real Grocery purple", 85, 44, 2 },
                    { 225, new DateTime(2018, 10, 21, 16, 20, 31, 817, DateTimeKind.Local).AddTicks(5271), "Officia quod et.", new DateTime(2021, 2, 9, 0, 57, 49, 219, DateTimeKind.Local).AddTicks(4614), "Handcrafted", 101, 44, 2 },
                    { 224, new DateTime(2019, 11, 29, 6, 15, 32, 811, DateTimeKind.Local).AddTicks(9441), "Dolore quia eligendi ut praesentium.", new DateTime(2021, 2, 3, 16, 21, 0, 250, DateTimeKind.Local).AddTicks(6070), "convergence Extended", 121, 44, 2 },
                    { 282, new DateTime(2017, 12, 7, 3, 55, 58, 168, DateTimeKind.Local).AddTicks(9669), "Veniam eum magni.", null, "Frozen Shoes Health, Health & Home", 35, 52, 2 },
                    { 223, new DateTime(2019, 5, 21, 8, 51, 53, 947, DateTimeKind.Local).AddTicks(8934), "Molestias voluptatibus itaque quia distinctio architecto quod dicta.", null, "Denar Security Consultant", 34, 44, 2 },
                    { 213, new DateTime(2020, 5, 7, 14, 54, 49, 189, DateTimeKind.Local).AddTicks(182), "Quisquam ratione quidem ipsa sed eum quo minus exercitationem.", null, "GB FTP", 101, 42, 2 },
                    { 212, new DateTime(2019, 3, 10, 2, 18, 24, 857, DateTimeKind.Local).AddTicks(3713), "Voluptatum possimus dolorem.", null, "Falls withdrawal", 84, 42, 2 },
                    { 211, new DateTime(2018, 11, 5, 7, 33, 36, 683, DateTimeKind.Local).AddTicks(4262), "Ut ratione est enim.", null, "Pines Sleek Granite Sausages Gateway", 24, 42, 2 },
                    { 210, new DateTime(2018, 7, 18, 7, 44, 55, 792, DateTimeKind.Local).AddTicks(626), "Quia maiores laboriosam error qui omnis.", null, "Incredible", 43, 42, 2 },
                    { 209, new DateTime(2018, 8, 23, 14, 30, 34, 90, DateTimeKind.Local).AddTicks(5971), "Voluptatem velit consectetur magnam et dolore deleniti unde fuga.", null, "Credit Card Account Azerbaijan Checking Account", 117, 42, 2 },
                    { 202, new DateTime(2020, 4, 11, 14, 17, 47, 221, DateTimeKind.Local).AddTicks(1253), "Quo sit nisi eius voluptas et similique.", null, "Credit Card Account Wyoming Buckinghamshire", 74, 40, 2 },
                    { 201, new DateTime(2017, 8, 19, 8, 50, 43, 453, DateTimeKind.Local).AddTicks(1220), "Assumenda sunt ex voluptatibus ut animi illo blanditiis.", null, "Facilitator circuit", 48, 40, 2 },
                    { 200, new DateTime(2019, 3, 1, 19, 25, 35, 175, DateTimeKind.Local).AddTicks(7923), "Sint eum voluptas amet ea harum aliquid.", null, "bypassing Mall access", 107, 39, 2 },
                    { 193, new DateTime(2019, 4, 18, 20, 34, 26, 232, DateTimeKind.Local).AddTicks(9575), "Modi praesentium enim.", null, "Money Market Account 1080p", 121, 37, 2 },
                    { 192, new DateTime(2018, 5, 16, 19, 38, 24, 293, DateTimeKind.Local).AddTicks(5165), "Quidem laboriosam nulla mollitia esse eum.", null, "Knoll", 23, 37, 2 },
                    { 191, new DateTime(2018, 11, 14, 3, 37, 8, 817, DateTimeKind.Local).AddTicks(5116), "Incidunt exercitationem est.", new DateTime(2020, 9, 22, 20, 56, 30, 256, DateTimeKind.Local).AddTicks(7189), "Lari Sleek Metal Pants Outdoors", 58, 37, 2 },
                    { 190, new DateTime(2019, 9, 16, 19, 15, 4, 696, DateTimeKind.Local).AddTicks(2771), "Nemo animi laborum debitis id at porro dolor ut.", null, "synergies Unbranded Tokelau", 44, 37, 2 },
                    { 189, new DateTime(2019, 10, 3, 7, 59, 12, 249, DateTimeKind.Local).AddTicks(2714), "Numquam qui qui dolores consequatur.", null, "Administrator Zambian Kwacha", 100, 37, 2 },
                    { 214, new DateTime(2019, 5, 28, 18, 2, 13, 982, DateTimeKind.Local).AddTicks(7705), "Ratione magni eaque facere magni perferendis tempore sed illum.", null, "Mountain", 29, 42, 2 },
                    { 188, new DateTime(2019, 10, 28, 4, 0, 51, 577, DateTimeKind.Local).AddTicks(6797), "Itaque aut ea ad officiis deserunt quia laudantium.", null, "Handcrafted Steel Cheese Optimization", 23, 37, 2 },
                    { 283, new DateTime(2020, 2, 26, 14, 47, 57, 794, DateTimeKind.Local).AddTicks(4157), "Dolorum quidem in.", null, "Principal matrices Markets", 54, 52, 2 },
                    { 203, new DateTime(2017, 7, 11, 6, 35, 2, 525, DateTimeKind.Local).AddTicks(5408), "Officia corporis dolor ea perspiciatis quasi ex iste corporis expedita.", new DateTime(2021, 1, 16, 21, 55, 1, 954, DateTimeKind.Local).AddTicks(3462), "Sports", 89, 41, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 245, new DateTime(2019, 7, 8, 6, 12, 31, 238, DateTimeKind.Local).AddTicks(206), "Quo rerum eveniet voluptatem.", new DateTime(2020, 7, 3, 21, 56, 30, 934, DateTimeKind.Local).AddTicks(8948), "Washington turquoise", 108, 46, 2 },
                    { 244, new DateTime(2017, 10, 6, 9, 3, 33, 293, DateTimeKind.Local).AddTicks(9226), "Et assumenda aspernatur quidem dolor facere.", new DateTime(2021, 2, 20, 16, 48, 20, 255, DateTimeKind.Local).AddTicks(478), "challenge Identity multi-byte", 66, 46, 2 },
                    { 243, new DateTime(2018, 9, 17, 17, 45, 24, 823, DateTimeKind.Local).AddTicks(1923), "Dignissimos facere consequuntur tempora quia.", null, "Investment Account Circles", 31, 46, 2 },
                    { 242, new DateTime(2018, 11, 18, 14, 38, 56, 108, DateTimeKind.Local).AddTicks(1521), "Cupiditate iste ut et tenetur quidem.", null, "web-readiness", 68, 46, 2 },
                    { 241, new DateTime(2019, 11, 28, 4, 24, 42, 807, DateTimeKind.Local).AddTicks(3106), "Esse veniam maxime repudiandae quia aut dolor.", null, "parsing Applications circuit", 43, 46, 2 },
                    { 240, new DateTime(2019, 12, 10, 2, 51, 26, 791, DateTimeKind.Local).AddTicks(8979), "Consequatur sed aperiam ipsum velit aut sed autem reiciendis et.", null, "AGP Lakes", 42, 45, 2 },
                    { 239, new DateTime(2020, 1, 29, 1, 32, 4, 13, DateTimeKind.Local).AddTicks(9807), "Enim error odio ex rerum aliquid rerum et.", null, "backing up neural Islands", 33, 45, 2 },
                    { 238, new DateTime(2018, 4, 20, 10, 30, 11, 119, DateTimeKind.Local).AddTicks(334), "Ipsam voluptatem voluptas in consequatur soluta voluptas.", null, "Fully-configurable", 91, 45, 2 },
                    { 237, new DateTime(2018, 1, 13, 2, 1, 17, 588, DateTimeKind.Local).AddTicks(4793), "Corrupti delectus possimus sunt aut quam magnam non.", new DateTime(2021, 5, 13, 15, 25, 55, 469, DateTimeKind.Local).AddTicks(6704), "Sleek Frozen Chips", 75, 45, 2 },
                    { 236, new DateTime(2020, 2, 29, 0, 48, 26, 831, DateTimeKind.Local).AddTicks(2523), "Quasi et quia est saepe debitis possimus aut.", null, "transmitter solution", 21, 45, 2 },
                    { 235, new DateTime(2017, 10, 16, 1, 16, 4, 575, DateTimeKind.Local).AddTicks(3387), "Aspernatur rem est odio id eum sed.", null, "Mauritius Tasty Personal Loan Account", 90, 45, 2 },
                    { 234, new DateTime(2018, 2, 15, 14, 54, 54, 673, DateTimeKind.Local).AddTicks(6520), "Quam non nihil officia quia omnis.", null, "Analyst deposit Steel", 93, 45, 2 },
                    { 233, new DateTime(2018, 9, 20, 21, 56, 31, 563, DateTimeKind.Local).AddTicks(8386), "Dolor nisi distinctio eos aspernatur iste qui quia.", new DateTime(2020, 10, 26, 10, 9, 26, 502, DateTimeKind.Local).AddTicks(5653), "Sleek Wooden Chicken copy", 110, 45, 2 },
                    { 284, new DateTime(2017, 12, 13, 23, 33, 38, 529, DateTimeKind.Local).AddTicks(980), "Sint aliquid voluptate laboriosam.", null, "Practical", 21, 52, 2 },
                    { 232, new DateTime(2020, 5, 28, 16, 23, 2, 694, DateTimeKind.Local).AddTicks(4847), "Dolorem nobis et exercitationem eveniet.", null, "brand virtual SQL", 103, 45, 2 },
                    { 222, new DateTime(2019, 11, 11, 2, 54, 1, 513, DateTimeKind.Local).AddTicks(1846), "Sed corporis architecto nostrum earum dignissimos.", null, "Borders Books, Garden & Health", 73, 43, 2 },
                    { 221, new DateTime(2018, 11, 10, 10, 36, 33, 52, DateTimeKind.Local).AddTicks(4126), "Sunt quaerat est velit illo.", new DateTime(2020, 6, 30, 22, 4, 6, 951, DateTimeKind.Local).AddTicks(7431), "Data", 66, 43, 2 },
                    { 220, new DateTime(2019, 5, 3, 21, 46, 22, 729, DateTimeKind.Local).AddTicks(3072), "Sit id modi est.", null, "Rubber Turkey", 44, 43, 2 },
                    { 219, new DateTime(2018, 7, 14, 8, 35, 2, 910, DateTimeKind.Local).AddTicks(9232), "Nam non quod voluptatem quidem id deserunt necessitatibus.", null, "holistic", 25, 43, 2 },
                    { 218, new DateTime(2019, 9, 10, 23, 28, 33, 564, DateTimeKind.Local).AddTicks(8357), "Est fugit omnis consequuntur delectus dolore esse.", null, "Unbranded Plastic Pants neural", 22, 43, 2 },
                    { 217, new DateTime(2018, 3, 30, 13, 15, 1, 110, DateTimeKind.Local).AddTicks(8036), "Ut eligendi fuga ea autem.", null, "interface Product", 68, 43, 2 },
                    { 216, new DateTime(2018, 1, 27, 9, 18, 13, 850, DateTimeKind.Local).AddTicks(9257), "Perferendis fuga consequatur nam aut deleniti et repudiandae expedita aliquid.", null, "scale ivory", 26, 43, 2 },
                    { 215, new DateTime(2020, 5, 2, 5, 58, 45, 145, DateTimeKind.Local).AddTicks(6475), "Maxime laudantium repellendus voluptatem.", null, "Regional Officer Borders", 98, 43, 2 },
                    { 208, new DateTime(2020, 1, 3, 17, 43, 44, 375, DateTimeKind.Local).AddTicks(6205), "Harum provident asperiores deserunt et.", null, "transparent", 43, 41, 2 },
                    { 207, new DateTime(2019, 7, 22, 15, 50, 40, 800, DateTimeKind.Local).AddTicks(187), "Dolores blanditiis id eveniet modi sunt sunt.", null, "Guarani Practical Metal Pizza drive", 32, 41, 2 },
                    { 206, new DateTime(2018, 2, 9, 13, 12, 36, 414, DateTimeKind.Local).AddTicks(7914), "Rem saepe illum.", new DateTime(2021, 3, 12, 21, 2, 50, 1, DateTimeKind.Local).AddTicks(8659), "withdrawal hack", 65, 41, 2 },
                    { 205, new DateTime(2017, 9, 26, 20, 35, 36, 926, DateTimeKind.Local).AddTicks(7140), "Iusto repellendus ad eos veniam animi.", null, "AI", 94, 41, 2 },
                    { 204, new DateTime(2017, 11, 30, 5, 4, 20, 198, DateTimeKind.Local).AddTicks(6313), "Eligendi atque iure quia et hic harum.", null, "Computers, Books & Shoes", 47, 41, 2 },
                    { 231, new DateTime(2020, 5, 12, 23, 3, 28, 719, DateTimeKind.Local).AddTicks(9575), "Rerum ut autem nobis possimus ipsam hic aspernatur eius.", null, "Beauty standardization", 21, 45, 2 },
                    { 187, new DateTime(2020, 4, 4, 13, 39, 2, 823, DateTimeKind.Local).AddTicks(4390), "Totam cumque ipsum culpa voluptatum quia velit sed.", null, "Planner", 20, 37, 2 },
                    { 186, new DateTime(2019, 10, 29, 0, 45, 58, 289, DateTimeKind.Local).AddTicks(3703), "Repellendus cupiditate eos minus animi nihil.", new DateTime(2021, 3, 8, 12, 16, 30, 856, DateTimeKind.Local).AddTicks(2090), "Handcrafted Rubber Ball Lodge", 60, 37, 2 },
                    { 185, new DateTime(2019, 5, 18, 17, 46, 10, 842, DateTimeKind.Local).AddTicks(4659), "Nam explicabo officiis in consequatur laborum.", null, "explicit Inverse Global", 76, 37, 2 },
                    { 146, new DateTime(2020, 5, 24, 2, 13, 51, 795, DateTimeKind.Local).AddTicks(1792), "Eius qui dolorum pariatur voluptatum odio vel et eos perspiciatis.", new DateTime(2021, 2, 4, 10, 17, 49, 281, DateTimeKind.Local).AddTicks(4263), "Awesome Cotton Fish project", 35, 28, 2 },
                    { 145, new DateTime(2019, 9, 19, 0, 24, 54, 926, DateTimeKind.Local).AddTicks(7868), "Expedita itaque voluptas maiores tempora quo expedita nostrum harum.", null, "action-items turquoise access", 47, 28, 2 },
                    { 144, new DateTime(2019, 8, 16, 17, 8, 41, 166, DateTimeKind.Local).AddTicks(9111), "Voluptate sequi aut fugit aperiam laborum.", null, "sky blue", 106, 28, 2 },
                    { 143, new DateTime(2017, 11, 24, 21, 40, 32, 294, DateTimeKind.Local).AddTicks(4189), "Tempora est id autem sed commodi.", null, "Comoro Franc copying", 24, 28, 2 },
                    { 142, new DateTime(2018, 5, 10, 21, 27, 56, 296, DateTimeKind.Local).AddTicks(250), "Et ea nisi beatae sint perferendis quisquam nulla.", null, "Human Plastic Team-oriented", 67, 28, 2 },
                    { 141, new DateTime(2020, 5, 1, 13, 6, 12, 450, DateTimeKind.Local).AddTicks(6433), "Adipisci unde fuga alias ipsam.", null, "technologies markets Borders", 68, 28, 2 },
                    { 140, new DateTime(2017, 8, 28, 8, 48, 26, 968, DateTimeKind.Local).AddTicks(5599), "Doloremque eveniet doloremque tempora consequatur repellendus atque accusamus.", null, "reboot Rustic Future", 52, 28, 2 },
                    { 139, new DateTime(2020, 6, 2, 6, 25, 25, 954, DateTimeKind.Local).AddTicks(3852), "Neque aliquam dolore aut et at nulla numquam.", null, "payment Bahamian Dollar", 108, 28, 2 },
                    { 138, new DateTime(2020, 1, 18, 9, 8, 53, 942, DateTimeKind.Local).AddTicks(9925), "Expedita non impedit sit commodi sed non vel.", null, "Rustic", 42, 28, 2 },
                    { 114, new DateTime(2018, 11, 4, 3, 52, 0, 855, DateTimeKind.Local).AddTicks(9837), "Repellendus molestias cum unde dolorem pariatur repellendus occaecati consectetur.", null, "Fresh Pennsylvania Operations", 27, 23, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 113, new DateTime(2019, 7, 3, 8, 6, 45, 755, DateTimeKind.Local).AddTicks(5804), "Omnis velit iusto sequi iste nisi in provident ex.", null, "Handcrafted Generic", 54, 23, 2 },
                    { 112, new DateTime(2019, 2, 5, 10, 41, 11, 928, DateTimeKind.Local).AddTicks(2530), "Modi repellendus unde labore ut repellat.", null, "generating Gorgeous Metal Table", 61, 22, 2 },
                    { 137, new DateTime(2018, 12, 5, 18, 15, 8, 545, DateTimeKind.Local).AddTicks(9242), "Labore ad ipsum non rerum.", null, "Auto Loan Account maximized", 61, 27, 2 },
                    { 160, new DateTime(2019, 9, 9, 6, 51, 32, 251, DateTimeKind.Local).AddTicks(254), "Quam earum ut et excepturi sed aut.", null, "Unbranded Plastic Ball revolutionary coherent", 26, 33, 2 },
                    { 136, new DateTime(2018, 4, 9, 22, 52, 18, 927, DateTimeKind.Local).AddTicks(4633), "Consequatur adipisci id quidem quisquam.", null, "circuit relationships web-readiness", 61, 27, 2 },
                    { 134, new DateTime(2018, 8, 19, 20, 19, 29, 775, DateTimeKind.Local).AddTicks(992), "Tenetur ratione iste dicta autem ab et optio et.", new DateTime(2020, 10, 3, 17, 29, 7, 505, DateTimeKind.Local).AddTicks(4155), "incubate Savings Account", 83, 26, 2 },
                    { 133, new DateTime(2019, 2, 12, 0, 16, 54, 100, DateTimeKind.Local).AddTicks(9416), "Et totam voluptatum delectus iusto consequatur.", null, "azure RSS", 104, 26, 2 },
                    { 132, new DateTime(2018, 12, 21, 0, 48, 10, 680, DateTimeKind.Local).AddTicks(3449), "Est voluptate odit temporibus quia.", new DateTime(2020, 7, 23, 5, 46, 13, 126, DateTimeKind.Local).AddTicks(7100), "Research", 76, 26, 2 },
                    { 131, new DateTime(2018, 6, 6, 2, 31, 1, 633, DateTimeKind.Local).AddTicks(5205), "Velit voluptatibus blanditiis ut odio quos aspernatur.", null, "Sleek hybrid Cambridgeshire", 45, 26, 2 },
                    { 130, new DateTime(2017, 9, 1, 7, 54, 37, 35, DateTimeKind.Local).AddTicks(1595), "Et aut corporis.", null, "envisioneer Grocery zero tolerance", 97, 26, 2 },
                    { 129, new DateTime(2018, 3, 16, 2, 58, 32, 434, DateTimeKind.Local).AddTicks(9464), "Voluptate id et molestiae iusto ipsam quas repellat.", null, "New York", 27, 26, 2 },
                    { 128, new DateTime(2020, 5, 29, 11, 15, 13, 237, DateTimeKind.Local).AddTicks(4746), "Exercitationem sapiente ut adipisci iusto aspernatur inventore dolore.", new DateTime(2021, 1, 2, 0, 27, 11, 60, DateTimeKind.Local).AddTicks(5468), "Small Fresh Computer invoice", 107, 26, 2 },
                    { 127, new DateTime(2019, 3, 18, 20, 5, 25, 138, DateTimeKind.Local).AddTicks(2020), "Sit et quo incidunt provident adipisci recusandae aut commodi sit.", null, "Saint Martin Central", 101, 26, 2 },
                    { 126, new DateTime(2018, 4, 7, 11, 59, 52, 20, DateTimeKind.Local).AddTicks(4073), "Id ut repudiandae temporibus dolorum.", null, "Data Unbranded systematic", 20, 26, 2 },
                    { 125, new DateTime(2019, 8, 27, 7, 2, 9, 322, DateTimeKind.Local).AddTicks(4354), "Consequatur quaerat molestias fuga iste est aliquam aperiam animi error.", null, "Refined users", 39, 26, 2 },
                    { 111, new DateTime(2019, 9, 27, 20, 39, 12, 839, DateTimeKind.Local).AddTicks(2990), "Voluptas sed inventore quia ullam sed voluptas placeat.", null, "incubate Usability Ergonomic Rubber Shoes", 107, 20, 2 },
                    { 110, new DateTime(2018, 8, 24, 5, 19, 24, 564, DateTimeKind.Local).AddTicks(5633), "Eos reiciendis autem dolorem.", null, "Branding", 79, 20, 2 },
                    { 109, new DateTime(2019, 12, 21, 16, 16, 59, 620, DateTimeKind.Local).AddTicks(590), "Qui non qui.", null, "Generic", 110, 20, 2 },
                    { 135, new DateTime(2018, 10, 27, 16, 0, 24, 677, DateTimeKind.Local).AddTicks(7571), "Nulla aspernatur debitis quas inventore.", null, "Games & Movies Wisconsin Rufiyaa", 38, 27, 2 },
                    { 161, new DateTime(2019, 11, 5, 19, 43, 30, 194, DateTimeKind.Local).AddTicks(2234), "Qui sint atque placeat quasi et.", null, "Small magenta mint green", 108, 33, 2 },
                    { 162, new DateTime(2017, 8, 20, 7, 47, 41, 289, DateTimeKind.Local).AddTicks(6027), "Voluptatibus architecto voluptatem consequatur.", new DateTime(2021, 4, 10, 6, 42, 15, 962, DateTimeKind.Local).AddTicks(7536), "turquoise killer", 45, 33, 2 },
                    { 163, new DateTime(2019, 2, 7, 7, 54, 54, 6, DateTimeKind.Local).AddTicks(6644), "Nihil maxime quas.", null, "gold approach Personal Loan Account", 95, 33, 2 },
                    { 184, new DateTime(2017, 9, 24, 14, 18, 49, 188, DateTimeKind.Local).AddTicks(8314), "Vel similique exercitationem.", null, "Cape", 57, 37, 2 },
                    { 199, new DateTime(2020, 4, 5, 14, 37, 54, 41, DateTimeKind.Local).AddTicks(9691), "Expedita architecto tempora amet voluptas.", new DateTime(2020, 9, 9, 9, 13, 42, 756, DateTimeKind.Local).AddTicks(6390), "maroon", 113, 38, 2 },
                    { 198, new DateTime(2017, 7, 12, 16, 34, 35, 784, DateTimeKind.Local).AddTicks(5906), "Tenetur laboriosam nihil voluptas ad cumque ut dolor assumenda.", null, "methodologies", 61, 38, 2 },
                    { 197, new DateTime(2017, 9, 16, 10, 23, 11, 731, DateTimeKind.Local).AddTicks(1934), "Quam quo magnam.", null, "Tunnel scalable", 116, 38, 2 },
                    { 196, new DateTime(2020, 1, 4, 2, 13, 54, 247, DateTimeKind.Local).AddTicks(6631), "Sunt modi et pariatur dignissimos.", new DateTime(2020, 7, 5, 6, 51, 15, 246, DateTimeKind.Local).AddTicks(441), "overriding", 113, 38, 2 },
                    { 195, new DateTime(2019, 6, 18, 8, 43, 0, 747, DateTimeKind.Local).AddTicks(4334), "Consequuntur repellat voluptates perspiciatis.", null, "Manager Research Facilitator", 45, 38, 2 },
                    { 194, new DateTime(2019, 6, 23, 14, 35, 18, 310, DateTimeKind.Local).AddTicks(1999), "Aut qui et earum nemo necessitatibus quaerat cupiditate.", null, "cross-platform Principal", 31, 38, 2 },
                    { 183, new DateTime(2019, 3, 26, 7, 48, 27, 701, DateTimeKind.Local).AddTicks(100), "Voluptas doloremque nesciunt quis.", null, "1080p Director", 43, 36, 2 },
                    { 182, new DateTime(2017, 11, 28, 22, 58, 53, 961, DateTimeKind.Local).AddTicks(8051), "Cupiditate mollitia animi et aut qui delectus inventore.", null, "grid-enabled Intelligent hard drive", 34, 36, 2 },
                    { 181, new DateTime(2020, 2, 20, 21, 32, 21, 841, DateTimeKind.Local).AddTicks(1352), "Harum ipsa excepturi quibusdam.", null, "Common XML", 101, 36, 2 },
                    { 180, new DateTime(2019, 11, 5, 9, 27, 20, 608, DateTimeKind.Local).AddTicks(3820), "Deleniti dolorem ad harum doloremque.", null, "solution-oriented", 121, 36, 2 },
                    { 179, new DateTime(2019, 2, 23, 14, 23, 2, 256, DateTimeKind.Local).AddTicks(1909), "Dolor et velit esse nemo veritatis nobis.", null, "Buckinghamshire Licensed tan", 117, 36, 2 },
                    { 178, new DateTime(2017, 7, 7, 12, 32, 5, 76, DateTimeKind.Local).AddTicks(7201), "Est nam nemo occaecati inventore tenetur eum enim.", null, "intuitive", 119, 36, 2 },
                    { 177, new DateTime(2019, 2, 27, 4, 26, 58, 871, DateTimeKind.Local).AddTicks(7122), "Ut natus rerum quod.", new DateTime(2020, 7, 18, 8, 5, 22, 259, DateTimeKind.Local).AddTicks(8288), "Hollow", 43, 36, 2 },
                    { 176, new DateTime(2017, 7, 28, 0, 9, 27, 585, DateTimeKind.Local).AddTicks(7263), "Laborum sit tempore sunt deleniti consequuntur et.", null, "users alliance", 118, 36, 2 },
                    { 175, new DateTime(2020, 4, 1, 21, 37, 39, 87, DateTimeKind.Local).AddTicks(2225), "Expedita corporis optio laboriosam vel illum delectus autem.", null, "Loaf", 104, 36, 2 },
                    { 174, new DateTime(2018, 8, 18, 11, 37, 48, 2, DateTimeKind.Local).AddTicks(3948), "Minima placeat fugit.", null, "context-sensitive Illinois Future", 107, 36, 2 },
                    { 159, new DateTime(2019, 8, 29, 1, 23, 9, 791, DateTimeKind.Local).AddTicks(6352), "Doloremque possimus ea sint tempora officia.", null, "cross-platform", 122, 32, 2 },
                    { 158, new DateTime(2018, 2, 1, 10, 19, 49, 776, DateTimeKind.Local).AddTicks(3612), "Vel eaque vel.", null, "models Data Green", 20, 32, 2 },
                    { 173, new DateTime(2019, 6, 21, 11, 9, 55, 983, DateTimeKind.Local).AddTicks(8590), "Pariatur incidunt et deleniti doloremque error est dolorem.", new DateTime(2020, 10, 15, 23, 18, 39, 353, DateTimeKind.Local).AddTicks(6023), "Shores Montserrat", 21, 35, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 172, new DateTime(2017, 11, 9, 18, 20, 32, 74, DateTimeKind.Local).AddTicks(7465), "Ut sit explicabo.", null, "connecting", 79, 35, 2 },
                    { 171, new DateTime(2019, 10, 6, 1, 25, 46, 919, DateTimeKind.Local).AddTicks(211), "Maiores natus nostrum voluptatem dicta ex impedit numquam hic.", null, "bypassing Glen Communications", 39, 35, 2 },
                    { 170, new DateTime(2017, 12, 1, 8, 17, 15, 363, DateTimeKind.Local).AddTicks(538), "Rerum minus dolor quae eveniet.", null, "THX Circles Assimilated", 109, 35, 2 },
                    { 169, new DateTime(2019, 2, 18, 22, 32, 36, 988, DateTimeKind.Local).AddTicks(6581), "Suscipit ipsum quam possimus beatae autem asperiores est ipsum.", null, "Checking Account", 32, 34, 2 },
                    { 168, new DateTime(2018, 5, 29, 12, 35, 54, 63, DateTimeKind.Local).AddTicks(8599), "Quae sit maiores quo quo qui id similique nostrum.", null, "orchid black", 44, 34, 2 },
                    { 167, new DateTime(2019, 11, 5, 16, 26, 9, 804, DateTimeKind.Local).AddTicks(6507), "Dignissimos repudiandae earum assumenda inventore qui accusantium accusamus.", null, "solid state", 85, 34, 2 },
                    { 166, new DateTime(2018, 6, 8, 1, 55, 11, 420, DateTimeKind.Local).AddTicks(8607), "Aut incidunt accusamus repellendus rerum qui aut totam excepturi.", null, "invoice Public-key Handcrafted Steel Sausages", 63, 34, 2 },
                    { 165, new DateTime(2018, 10, 6, 18, 2, 52, 477, DateTimeKind.Local).AddTicks(1772), "Nostrum quas quisquam fugiat sapiente.", null, "functionalities deposit", 40, 33, 2 },
                    { 164, new DateTime(2017, 11, 6, 18, 39, 6, 920, DateTimeKind.Local).AddTicks(7849), "Molestias omnis fuga perferendis est quia aut voluptatum.", null, "Lithuania plug-and-play", 113, 33, 2 },
                    { 107, new DateTime(2017, 10, 24, 21, 15, 26, 59, DateTimeKind.Local).AddTicks(6376), "Corrupti optio doloribus aut iusto ut.", null, "Money Market Account", 56, 20, 2 },
                    { 501, new DateTime(2019, 9, 16, 0, 23, 31, 707, DateTimeKind.Local).AddTicks(4527), "Qui eos consectetur nam unde.", null, "Kids XSS Managed", 51, 93, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
