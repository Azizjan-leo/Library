using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Web.Data.Migrations
{
    public partial class SeedBooksAndWriters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pushkin" },
                    { 2, "Turgenev" },
                    { 3, "Dostoevsky" },
                    { 4, "James Chase" },
                    { 5, "J. K. Rowling" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, null, 1, "Eugene Onegin is the master work of the poet whom Russians regard as the fountainhead of their literature. Set in 1820s Russia, Pushkin's verse novel follows the fates of three men and three women. Engaging, full of suspense, and varied in tone, it also portrays a large cast of other characters and offers the reader many literary, philosophical, and autobiographical digressions, often in a highly satirical vein.", "Eugene Onegin" },
                    { 2, null, 1, "Pushkin's version of the historical novel in the style of Walter Scott, this final prose work also reflects his fascination with and research into Russian history of the 18th century. During the reign of Catherine the Great, the young Grinev sets out for his new career in the army and en route performs an act of kindness by giving his warm coat to a man freezing in a blizzard. This action reaps its reward when he subsequently finds himself caught up in the rebellion headed by the infamous, and strangely familiar, Pugachev. Rivalry with a fellow officer for the affections of Captain Mironov's daughter further complicates Grinev's affairs, and ultimately it is only an appeal by Masha Mironova, the eponymous captain's daughter, to the Empress herself that can unravel a tangled web.", "The Captain's Daughter" },
                    { 3, null, 1, "The Queen of Spades (Russian: Pikovaya dama) is an acclaimed short story by Alexander Pushkin about human avariciousness. Pushkin wrote the story in autumn 1833 in Boldino and it was first published in literary magazine Biblioteka dlya chteniya in 1834. It was turned into the opera The Queen of Spades by Tchaikovsky.", "The Queen of Spades" },
                    { 4, null, 2, "TheBazarov—a gifted, impatient, and caustic young man—has journeyed from school to the home of his friend Arkady Kirsanov. But soon Bazarov’s outspoken rejection of authority and social conventions touches off quarrels, misunderstandings, and romantic entanglements that will utterly transform the Kirsanov household and reflect the changes taking place across all of nineteenth-century Russia.", "Fathers and Sons" },
                    { 5, null, 2, "This vivid, sensitive tale of adolescent love follows a 16-year-old boy who falls in love with a beautiful, older woman and experiences a whirlwind of changing emotions, from exaltation and jealousy to despair and devotion. This beautifully packaged series of classic novellas includes the works of masterful writers. Inexpensive and collectible, they are the first single-volume publications of these classic tales, offering a closer look at this underappreciated literary form and providing a fresh take on the world's most celebrated authors.", "First Love" },
                    { 6, null, 2, "Mumu (Russian: «Муму») is a short story by Ivan Turgenev, a Russian novelist and story writer, written in 1854. The story of Gerasim, a deaf and mute serf whose life of poverty is brought into sharp relief by his connection with Mumu, a dog he rescued, brought greater national attention to the cruelties of serfdom, and received praise for its brutal portrayal of this institution in Russian society.", "Mumu" },
                    { 7, null, 3, "Raskolnikov, a destitute and desperate former student, wanders through the slums of St Petersburg and commits a random murder without remorse or regret. He imagines himself to be a great man, a Napoleon: acting for a higher purpose beyond conventional moral law. But as he embarks on a dangerous game of cat and mouse with a suspicious police investigator, Raskolnikov is pursued by the growing voice of his conscience and finds the noose of his own guilt tightening around his neck. Only Sonya, a downtrodden sex worker, can offer the chance of redemption.", "Crime and Punishment" },
                    { 8, null, 3, "The Brothers Karamazov is a murder mystery, a courtroom drama, and an exploration of erotic rivalry in a series of triangular love affairs involving the “wicked and sentimental” Fyodor Pavlovich Karamazov and his three sons―the impulsive and sensual Dmitri; the coldly rational Ivan; and the healthy, red-cheeked young novice Alyosha. Through the gripping events of their story, Dostoevsky portrays the whole of Russian life, is social and spiritual striving, in what was both the golden age and a tragic turning point in Russian culture.", "The Brothers Karamazov" },
                    { 9, null, 3, "Returning to Russia from a sanitarium in Switzerland, the Christ-like epileptic Prince Myshkin finds himself enmeshed in a tangle of love, torn between two women—the notorious kept woman Nastasya and the pure Aglaia—both involved, in turn, with the corrupt, money-hungry Ganya. In the end, Myshkin’s honesty, goodness, and integrity are shown to be unequal to the moral emptiness of those around him. In her revision of the Garnett translation, Anna Brailovsky has corrected inaccuracies wrought by Garnett’s drastic anglicization of the novel, restoring as much as possible the syntactical structure of the original story.", "The Idiot" },
                    { 10, null, 4, "Miss Blandish - innocent, exquisite, vulnerable heiress - is kidnapped by a gang of ruthless hoods who've never tried big-time crime. Foiled by their own vicious ineptitude and the greed of a superior mob, the kidnappers lose their million dollar prize. Blandish, terrified and broken, is now the captive of Ma' Grisson and her sadistic, sexually deviant son Slim.", "No Orchids for Miss Blandish" },
                    { 11, null, 4, "It was the easiest three grand Nelson Ryan had ever made - but suddenly he realized he was being played for a sucker. A telephone call, seemingly innocent enough, led him to the murder of a Chinese call-girl who'd talked too much. It also pitched him straight into the teeming, sordid night life of colourful Hong Kong.", "A Coffin from Hong Kong" },
                    { 12, null, 4, "Kahlenberg, millionaire and a compulsive collector of art treasures steals a famous poison ring, once owned by Caesar Borgia, from a rival collector. Kahlenberg's museum is hidden in the Drakensberg range and can only be reached through the dangerous swamps and the steamy heat of the Basutoland jungle.", "The Vulture Is a Patient Bird" },
                    { 13, null, 5, "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.", "Harry Potter and the Sorcerer's Stone" },
                    { 14, null, 5, "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.", "Harry Potter and the Chamber of Secrets" },
                    { 15, null, 5, "During his third year at Hogwarts School for Witchcraft and Wizardry, Harry Potter must confront the devious and dangerous wizard responsible for his parents' deaths. ", "Harry Potter and the Prisoner of Azkaban" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Writers_Name",
                table: "Writers",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title",
                table: "Books",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Writers_Name",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Books_Title",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
