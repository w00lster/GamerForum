using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using GamerForum.Models;
using System.Collections.Generic;
using System.Web;

namespace GamerForum.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<GamerForumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GamerForum.DAL.GamerForumContext";
        }

        protected override void Seed(GamerForum.Models.GamerForumContext context)
        {
            var users = new List<AppUser>
            {
                new AppUser{UserName = "Lily", FirstName = "Lily", LastName = "A. Lop", Age=18, Email = "Lily@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Caz", FirstName = "Castiel", LastName = "Angel", Age=20, Email = "Cas@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Prinsesse", FirstName = "Ariel Tornerose", LastName = "Darling", Age=22, Email = "Prinsesse@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()},
                new AppUser{UserName = "Ellibelly", FirstName = "Elliot", LastName = "Fluff", Age=19, Email = "Elliot@gmail.com", DayCreated = DateTime.Now, Ratings = new List<Ratings>(), Status = new List<Status>(), Wanted_games = new List<Wanted_games>()}
            };
            foreach (AppUser user in users){
                context.Users.AddOrUpdate(p => p.Id);
            }
            //users.ForEach(u => context.User.AddOrUpdate(p => p.UserId, u));
            context.SaveChanges();

            var ratings = new List<Ratings>
            {
                new Ratings{Rating_value = 1.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 2.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 3.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 4.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 5.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 6.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 7.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 8.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 9.00, Game = new List<Games>(), AppUsers = new List<AppUser>()},
                new Ratings{Rating_value = 10.00, Game = new List<Games>(), AppUsers = new List<AppUser>()}
            };
            ratings.ForEach(r => context.Ratings.AddOrUpdate(p => p.Rating_value, r));
            context.SaveChanges();

            var genres = new List<Genres>
            {
                new Genres{Genre_name = "Card", Game = new List<Games>()},
                new Genres{Genre_name = "Adventure", Game = new List<Games>()},
                new Genres{Genre_name = "Party", Game = new List<Games>()},
                new Genres{Genre_name = "Deck building", Game = new List<Games>()},
                new Genres{Genre_name = "Dungeon Crawler", Game = new List<Games>()},
                new Genres{Genre_name = "Family", Game = new List<Games>()},
                new Genres{Genre_name = "Kids", Game = new List<Games>()}
            };
            genres.ForEach(g => context.Genres.AddOrUpdate(p => p.Genre_name, g));
            context.SaveChanges();

            var games = new List<Games>
            {
                new Games {Game_name= "Marvel Legendary", Game_time ="45-90 min", Description ="Lorem Ipsum", Number_of_Players ="1-5", Year_releashed = 2000, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Talisman", Game_time ="60-90 min", Description ="Dolor sit amet", Number_of_Players ="2-5", Year_releashed = 2017, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Det dårlige Selskab", Game_time ="30-60 min", Description ="Hab hab", Number_of_Players ="3-6", Year_releashed = 2003, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Fuld af løgn", Game_time ="45-60 min", Description ="løgn og latin", Number_of_Players ="2-6", Year_releashed = 2007, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {Game_name= "Uno", Game_time ="10-20 min", Description = "+4 kort", Number_of_Players ="2+", Year_releashed = 1900, Genre = new List<Genres>(), Rating = new List<Ratings>()},
                new Games {
                    Game_name= "Ambush!",
                    Game_time ="240 min",
                    Description = "Ambush! is the solitaire game of combat, adventure, and heroism in World War Two France. Using a ground-breaking development of the programmed paragraph solitaire system, Ambush! gives the player control of an American squad, faced with a variety of missions against an ever-changing, hidden German foe. The variable events, innumerable tactical options, and wealth of unexpected occurrences make Ambush! a solitaire gaming experience unlike any that has gone before. The easily learned rules are specially designed to get the player into the action within minutes. The player selects and arms his squad, providing each soldier with command and initiative ratings, perception, weapons skill, driving skill, and movement capability. After selecting one of the eight missions provided, the player sends his squad into a mission map to conduct operations called for in the mission. Soldiers move freely, as far as the player wishes, checking for events each time they move...until the sequenced action rounds are triggered by the whine of German bullets! " +
                    "Expansion(s): " +
                    "Ambush! Move Out! " +
                    "Traffic Control " +
                    "Ambush! Purple Heart " +
                    "Fallschirmjager " +
                    "Block Party " +
                    "Ambush! Silver Star " +
                    "Follow Me!: Mission #1 – Viva la resistance " +
                    "Follow Me!: Mission #2 - Verletzer Tieger " +
                    "Follow Me!: Mission #3 – Troll Bridge ",
                    Number_of_Players = "1",
                    Year_releashed = 1983,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },


                new Games
                {
                    Game_name = "B-17: Queen of the Skies",
                    Game_time = "20 min",
                    Description = "May 1943. Movement to targets is through zones. Die rolls and game tables determine appearance, type, and position of enemy fighters. Charts are used to determine if hits are made, where the damage is located, and how serious the damage is. Game tables and die rolls also determine everything from the bomber's target and formation position to weather, flak, and German fighter opposition as the B-17 makes its way over land and sea to its target. The game has a low complexity and typically, the playing time is generally less than one hour after your first few games. B - 17 is designed to be primarily a solitaire game.The player controls a B - 17F Flying Fortress bomber, trying to survive German fighter attacks and drop its load of bombs on the selected target, then return home safely.Optionally, a second player can control the German fighters(to some degree; their appearance is determined randomly, but successive attacks are under the control of the German player). If each player has their own copy of B - 17, then they can fly their bomber while playing the same mission as part of the formation. " +
                    "Expansion(s): None",
                    Number_of_Players = "1-2",
                    Year_releashed = 1981,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "Friday",
                    Game_time ="25 min",
                    Description ="Friday, the second game in the Friedemann Friese Freitag-Project, is about Robinson Crusoe and Friday (Freitag). You play as Friday and must help Robinson Crusoe survive the island and prepare him to defeat the pirates. Friday is a solitaire deck-building game in which you optimize your deck of fight cards to defeat the hazards of the island and two pirate ships. During a turn the player will attempt to defeat hazard cards by playing fight cards from their deck. If defeated, a hazard will become a fight card and is added to the players deck. If failed the player will lose life tokens but also get the opportunity to remove played cards from their fight deck. Finally, the player will use their optimized fight deck to defeat two evil pirate ships allowing Robinson Crusoe to escape the island! " +
                    "Expansion(s): None",
                    Number_of_Players = "1",
                    Year_releashed = 2011,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "1st & Goal",
                    Game_time ="120-150 min",
                    Description ="1st & Goal pits two football teams in a classic gridiron match. Players call plays using the cards available in their hands. Yardage gained or lost is determined by a roll of the dice, and strategic play-calling makes all the difference as to which dice you get to roll for each play. The right offensive play might gain you a lot of yardage – unless the defense sets up correctly to stop it. After that, it all comes down to the roll of the dice... Fumbles, interceptions, sacks, penalties, deep passes, breakaway runs – it's all here. 1st & Goal comes with three Running Dice, three Passing Dice, a Defense Die, a Play Die, a Referee Die, and a Penalty Die. The card decks include 60 Offense cards and 60 Defense cards. Six 'division' packs, each with four unique DFL (Dice Football League) expansion teams, are sold separately. " +
                    "Expansion(s): " +
                    "1st & Goal: Southwest Division " +
                    "1st & Goal: Southeast Division " +
                    "1st & Goal: Northwest Division " +
                    "1st & Goal: Northeast Division " +
                    "1st & Goal: Midwest Division " +
                    "1st & Goal: Mideast Division " +
                    "1st & Goal: Essen Eagles",
                    Number_of_Players = "2-4",
                    Year_releashed = 2011,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "7 Wonders Duel",
                    Game_time ="30 min",
                    Description ="In many ways 7 Wonders Duel resembles its parent game 7 Wonders as over three ages players acquire cards that provide resources or advance their military or scientific development in order to develop a civilization and complete wonders. What's different about 7 Wonders Duel is that, as the title suggests, the game is solely for two players, with the players not drafting cards simultaneously from hands of cards, but from a display of face-down and face-up cards arranged at the start of a round. A player can take a card only if it's not covered by any others, so timing comes into play as well as bonus moves that allow you to take a second card immediately. As in the original game, each card that you acquire can be built, discarded for coins, or used to construct a wonder. Each player starts with four wonder cards, and the construction of a wonder provides its owner with a special ability.Only seven wonders can be built, though, so one player will end up short. Players can purchase resources at any time from the bank, or they can gain cards during the game that provide them with resources for future building; as you acquire resources, the cost for those particular resources increases for your opponent, representing your dominance in this area. A player can win 7 Wonders Duel in one of three ways: each time you acquire a military card, you advance the military marker toward your opponent's capital, giving you a bonus at certain positions; if you reach the opponent's capital, you win the game immediately; similarly, if you acquire any six of seven different scientific symbols, you achieve scientific dominance and win immediately; if none of these situations occurs, then the player with the most points at the end of the game wins. " +
                    "Expansion(s): " +
                    "7 Wonders Duel: The Messe Essen " +
                    "7 Wonders Duel: Statue of Liberty " +
                    "7 Wonders Dule: Pantheon " +
                    "7 Wonders Duel: Stonehenge",
                    Number_of_Players = "2",
                    Year_releashed = 2015,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "Abalone",
                    Game_time ="30 min",
                    Description ="This beautiful and functional board has room for two teams of large marbles. Players take turns pushing the marbles around the board, with the goal of pushing six of the opposing player's marbles off the board. The central idea is that a column of marbles has weight given by the number of marbles in line. Someone will need to push with a heavier group of marbles in order to push the column along that axis. However, with six possible directions, it's difficult to defend yourself perfectly. Also, it's possible to play the game with up to six players when supplemental marble sets are purchased. " +
                    "Expansion(s): Abalone Extra Player Marbles",
                    Number_of_Players = "2",
                    Year_releashed = 1987 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "Agon (Queen’s Guard)",
                    Game_time ="30 min",
                    Description ="Queen's Guard, a.k.a. Agon, is played on a hexagonal board, comprised of 91 smaller hexagons, six to each side of the board. The central hex is known as the throne; most Agon boards feature alternating colors of hexes in rings, starting from the six hexes surrounding the throne. Each player has one queen piece and six guard pieces. These all have alternating starting positions on the board's outer ring. Players take turns moving their pieces forward (or laterally) towards the center of the board; pieces may be captured by an opponent, if they are surrounded on two sides in a straight line. The captured player must then relocate his piece to the outer ring of the board. To win the game, a player must have his queen on the throne and surrounded by all six of his guards. " +
                    "Expansion(s): None",
                    Number_of_Players = "2",
                    Year_releashed = 1843 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>()
                },

                new Games {
                    Game_name= "...and the, we held hands",
                    Game_time ="30-45 min",
                    Number_of_Players ="2",
                    Year_releashed =2015 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="...and then we held hands. is a co-operative game about finding balance. To win, the two players must complete objectives and reach the center of the board. The players take turns trying to fulfill the current common emotional objective by discarding emotion cards to move from node to node. They must do this without verbal communication, empathizing and always considering each other's situation when making a move. A player can use their own cards or their partner's, but if their move causes their partner to be unable to move, the players lose and the game ends. While moving from node to node, their balance shifts, and they are not able to refill their hand. The game features a card-splaying mechanism in which players change their 'perspective' to reveal a new set of options. The players win by meeting in the center while in a balanced state and within one turn of each other - something quite difficult, and therefore very rewarding when achieved. ...and then we held hands. features art by beloved French illustrator Marie Cardouat, known for the art found in beautiful games such as Dixit, Steam Park, and Marrakech. " +
                    "Expansion(s): none."
                },

                new Games {
                    Game_name= "Asalto",
                    Game_time ="20 min",
                    Number_of_Players ="2",
                    Year_releashed = 1803,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="This game evolved from (or alongside) Fox & Geese and seems to have appeared first in Germany at least as early as 1803, where it has been known as Belagerungsspiel (Siege Game) or Festungsspiel (Fortress Game.) In English speaking countries it was published as Siege, or German Tactics. Since it is played on essentially a Fox & Geese board with additional markings and pieces, it was often included in a set with rules for Fox & Geese and Solitaire. The markings outline one nine-point side of the cross as a distinct fortress or castle, typically in a different color from the rest of the board's points. Also, the horizontal lines of the board are in a different color than the rest, but for the few closest to the fortress. This is to indicate where the attacker may not move; in some editions these markings are absent and instead simply described by the player's rules of movement. The defending player has two pieces in the fortress, either on specific starting points or anywhere the player chooses, depending on the included rules. The other player has twenty-four pieces, one on each of the board's remaining points. The goal for the attacking player is to occupy all nine of the fortress points with one of his pieces. The goal for the defending player is to reduce the attacker to eight pieces, thereby preventing occupation of the fortress. Attackers may move along the vertical or diagonal lines towards the fortress only, except on the few marked horizontal lines near the fortress. They may not jump or capture any pieces. The defenders may move in any direction along any line, and may capture (remove from the board) an attacker's piece by jumping over it to a vacant opposite point. Siege evolved further into a larger edition with a sixty-seven point board, seventeen points for the fortress (and three defending pieces) and fifty points for the attackers. Sometimes published in Germany and continental Europe as Neues Belagerungsspiel (New Siege Game) or Grosses Festungs-Spiel (Big Fortress Game,)it was known in English-speaking countries as The Royal Garrison Game and has been published under many other names since then. " +
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Backgammon",
                    Game_time ="30 min",
                    Number_of_Players ="2",
                    Year_releashed = -3000,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Backgammon is a classic abstract strategy game dating back thousands of years. Each player has a set of 15 'men' that must be moved from their starting positions, around, and then off the board. Dice are thrown each turn, and each player must decide which of his men to move based on the outcome of the roll. Players can capture each other's men, forcing the captured men to restart their journey around the board. The winner is the first player to get all 15 men off the board. A more recent addition to the game is the 'doubling cube', which allows players to up the stakes of the game, as it is often played for money. Although the game relies on dice to determine movement, there is a large degree of strategy in deciding how to make the most effective moves given each dice roll as well as measuring the risk in terms of possible rolls the opponent may get. Backgammon may be the first game to be mentioned in written history, going back 5,000 years to the Sumerians of ancient Mesopotamia. During the 1920's, archaeologists unearthed five boards from a cemetery in the ancient town of Ur. At another location, pieces and dice were also found along with the board. Boards from ancient Egypt have also been recovered from the tomb of Tutankhamun, including a mechanical dice box, no doubt intended to stop cheaters. The names of the game were many. In Persia, Takhteh Nard> which means 'Battle on Wood'. In Egypt, Tau, which may be the ancestor of Senat. In Rome, Ludus Duodecim Scriptorum ('game of twelve marks'), later, Tabula ('table'), and by the sixth century, Alea ('dice'). In ancient China, T-shu-p-u and later in Japan, Sugoroko. The English name may derive from 'Bac gamen' meaning 'Back Game', referring to re-entry of taken stones back to the board. It was often enjoyed by the upper classes and is sometimes called 'The Aristocratic Game.' The Roman Emperor Claudius was known to be such a fan that he had a set built into his coach so he could play as he traveled (the world's first travel edition?). The rules in English were standardized in 1743 by Edmond Hoyle. These remained popular until the American innovations of the 1930's. " +
                    "Expansion(s): " +
                    "Whamgammon " +
                    "Gackgammon: Zombie Rush Dargammon"
                },

                new Games {
                    Game_name= "Battleship",
                    Game_time ="30 min",
                    Number_of_Players ="2",
                    Year_releashed =1931 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Battleship was originally a pencil-and-paper public domain game known by different names, but Milton Bradley made it into the well known board game in 1967. The pencil and paper grids were changed to plastic grids with holes that could hold plastic pegs used to record the guesses. Each player deploys his ships (of lengths varying from 2 to 5 squares) secretly on a square grid. Then each player shoots at the other's grid by calling a location. The defender responds by 'Hit!' or 'Miss!'. You try to deduce where the enemy ships are and sink them. First to do so wins. The Salvo variant listed in the rules allows each player to call out from 1 to 5 shots at a time depending on the amount of ships the player has left (IE: players each start off with 5 ships, so they start off with 5 shots. As ships are sunk, the players gets fewer shots). This version of the game is closer to the original pencil-and-paper public domain game. Many versions of the pencil-and-paper game have different amounts of shots based on the ship (IE: Battleship: 5 shots. Destroyer: 3 Shots, Etc.). " +
                    "In 2008, Hasbro 'reinvented' the game into Battleship (Revised). " +
                    "Some history of the published versions of the game: " +
                    "1931: Starex Novelty Co. of NY publishes Salvo. " +
                    "1933: The Strathmore Co. publishes Combat, The Battleship Game. " +
                    "1943: Milton Bradley publishes the pad-and-pencil game Broadsides, The Game of Naval Strategy. " +
                    "1943: Also published in 1943 Sink it by the L R Gebert Co. for distribution by G. Krueger Brewing Co. " +
                    "1940's: Maurice L. Freedman Co. of RI publishes Warfare Naval Combat. " +
                    "1961: Ideal publishes Salvo. Other titles over the years have included Swiss Navy, Sunk (Parker Bros.), Convoy (Transogram), Wings(Strategy Games Co. of California), and Naval Battle (3M Paper and Pencil Version). " +
                    "Expansion(s): Super Sea Battle"
                },

                new Games {
                    Game_name= "Blockade",
                    Game_time ="20 min",
                    Number_of_Players ="2",
                    Year_releashed = 1975 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Described on-box as 'the Beat the Barrier' strategy game. Players each have 2 pawns, 9 green walls (which are placed vertically), and 9 blue walls (placed horizontally). Pawns start on the color matching them, which are 4x4 squares in on each of the four corners of the 11x14 board. The object is simple: to get one of your pawns to a starting spot of your opponent. Each turn players can move one pawn up to two spaces, and also place one wall, useful for blocking off their opponent's move. Walls always cover two squares worth of area, and must be placed according to their color (vertically or horizontally). Once players are out of walls, they keep moving pawns until one wins. This game is one of a series of 2 player strategy games by Lakeside from the 1970s. " +
                    "Another version by the same Designer: " +
                    "Quoridor " +
                    "Re-implemented By: " +
                    "Pinko Pallino " +
                    "Expansion(s): None"
                },

                new Games {
                    Game_name= "Blood Bowl (first Editon)",
                    Game_time ="120 min",
                    Number_of_Players ="2",
                    Year_releashed = 1986,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="A Games Workshop Fantasy Football game that stood as something of a cross between American football, rugby and all out war. The first edition of Blood Bowl used cardboard figures to represent the teams and in game flow terms is actually a long way off the much slicker third edition. At the time it simply moved the then cumbersome Warhammer Fantasy Battle system onto a football pitch and was rather bogged down by the resultant tables and charts that dictated the flow of the game. It sowed the seeds however for the far more playable second and third editions and is now something of a collectible classic. " +
                    "Expansion(s): " +
                    "Blood Bowl (first edition): Skaven Team " +
                    "Blood Bowl (first edition): Death Zone"
                },

                new Games {
                    Game_name= "Blood Bowl (second Edition)",
                    Game_time ="180 min",
                    Number_of_Players ="2",
                    Year_releashed =1988 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Blood Bowl is a game of Fantasy Football. The basic game features a match between a human team and an orc team. Ostensibly the teams are playing football. In fact each team takes turns moving, blocking and advancing the football down the field. The game comes with plastic miniatures. This is the Second Edition Game in the Blood Bowl Series! " +
                    "Expansion(s): " +
                    "Blood Bowl Star Players Blood Bowl(Second Edition): " +
                    "Elves, Dwarfs and Dungeonbowl"
                },

                new Games {
                    Game_name= "Camelot",
                    Game_time ="15 min",
                    Number_of_Players ="2",
                    Year_releashed =1930 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Chivalry was first self-published by George S. Parker in 1888 and he called it his favorite game. In 1930 it was scaled down, re-named Camelot and published by Parker's company, Parker Brothers. Minor rules changes were implemented in 1931. The object is simple: move two pieces into your opponent's goal or eliminate all of your opponent's pieces. In a matter of minutes, you'll learn the moves. The Jump. The Capture. And the Power Play. The rest is up to you. Make your moves courageously or cautiously. But always be on guard. One move can quickly change the entire complexion of the game. Current World Camelot Federation rules of Camelot define one of the objects of the game as capturing ALL of the opponent's pieces while retaining two or more of your own. " +
                    "Re-implements " +
                    "Chivalry " +
                    "Re-implemented by: " +
                    "Cam " +
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Cave vs. Cave",
                    Game_time ="20-40 min",
                    Number_of_Players ="2",
                    Year_releashed = 2017,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="In the two-player game Caverna: Cave vs. Cave, each player starts the game with only two dwarves and a small excavation in the side of a mountain. Over the course of eight rounds, they'll double their workforce, open up new living space in the mountain, construct new buildings and rooms in which to live, and dig for precious metals. In more detail, each player starts the game with an individual player board that's covered with a random assortment of face-down building/room tiles and only one space. Some tiles are face up and available for purchase at the start of play. Four action tiles lie face up as well. At the start of each of the eight rounds, one new action tile is revealed, then players alternate taking actions, with the number of actions increasing from two up to four over the course of the game. As players excavate their mountainous player board, new building and room tiles are added to the pool; some rooms can be used immediately when acquired, whereas others require the use of an action tile. After eight rounds, players tally their points for buildings constructed and gold collected to see who wins. " +
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Checkers",
                    Game_time ="30 min",
                    Number_of_Players ="2",
                    Year_releashed = 1150,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Abstract strategy game where players move disc-shaped pieces across an 8 by 8 cross-hatched ('checker') board. Pieces only move diagonally, and only one space at a time. If a player can move one of his pieces so that it jumps over an adjacent piece of their opponent and into an empty space, that player captures the opponent's disc. Jumping moves must be taken when possible, thereby creating a strategy game where players offer up jumps in exchange for setting up the board so that they jump even more pieces on their turn. A player wins by removing all of his opponent's pieces from the board or by blocking the opponent so that he has no more moves. This game, also known as Draughts, is part of the Checkers family. The Official Checker Board to be used in tournaments and official matches of associations like international WCDF, ACF, and APCA usually shall be colored of green and off-white (buff). Board squares shall be not less than 2 inches nor more than 2½ inches wide. Tournament pieces are Red and White, but called Black and White in game related literature. "+
                    "Expansion(s): " +
                    "The Check Deck"
                },

                new Games {
                    Game_name= "Chaturanga",
                    Game_time ="30 min",
                    Number_of_Players ="2-4",
                    Year_releashed = 650,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Published in GAMES Magazine, January/February 1981 issue, page 22 (with original rules on page 68) as 'a gambling game 1,500 years ahead of its time.' R. Wayne Schmittberger adapted the rules for streamlined play. From GAMES Magazine: 'The oldest known form of chess, Chaturanga is a lively game in which moves are determined, as in backgammon, by a combination of dice rolls and player judgment.' "+
                    "Online Play " +
                    "Ludoteka (real-time) " +
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Chess",
                    Game_time ="60 min",
                    Number_of_Players ="2",
                    Year_releashed = 1475,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Chess is a two-player, abstract strategy board game that represents medieval warfare on an 8x8 board with alternating light and dark squares. Opposing pieces, traditionally designated White and Black, are initially lined up on either side. Each type of piece has a unique form of movement and capturing occurs when a piece, via its movement, occupies the square of an opposing piece. Players take turns moving one of their pieces in an attempt to capture, attack, defend, or develop their positions. Chess games can end in checkmate, resignation, or one of several types of draws. Chess is one of the most popular games in the world, played by millions of people worldwide at home, in clubs, online, by correspondence, and in tournaments. Between two highly skilled players, chess can be a beautiful thing to watch, and a game can provide great entertainment even for novices. There is also a large literature of books and periodicals about chess, typically featuring games and commentary by chess masters. The current form of the game emerged in Southern Europe during the second half of the 15th century after evolving from a similar, much older game of Indian origin. The tradition of organized competitive chess began in the 16th century. The first official World Chess Champion, Wilhelm Steinitz, claimed his title in 1886. The current World Champion is Magnus Carlsen, Norway. Chess is also a recognized sport of the International Olympic Committee. "+
                    "Expansion(s): " +
                    "Royal Chess " +
                    "Knightmare Chess " +
                    "Knightmare Chess 2 " +
                    "Chess Empire " +
                    "Chess Mixer " +
                    "Meta Chess " +
                    "Economy Chess " +
                    "Spell Chess: an expansion to Chess " +
                    "Rogue Chess " +
                    "Knightmare Chess (third edition) " +
                    "Epic Chess " +
                    "Kingdom of Elbrandt " +
                    "Fairy Tale Chess " +
                    "Heretik Chess " +
                    "Castle-Mate " +
                    "Etchessera",
                },

                new Games {
                    Game_name= "Connect 4 (Revised Edition)",
                    Game_time ="15 min",
                    Number_of_Players ="2",
                    Year_releashed =2008 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="From Hasbro.com: 'Challenge a friend to checker-dropping fun with CONNECT 4! There are three ways to play, so choose your game: Original: Drop in your checkers and be the first to get 4-in-a-row to win. Pop Out: Get 4 in a row by popping a checker out instead of dropping one in! Pop 10: Pop checkers out of the grid. If your checker is part of a 4-in-a-row, you get to keep it. The first player to get 10 checkers wins. When you're done playing, tote your game around with a convenient carrying handle. The checkers store inside the grid so you're ready to play anytime!' "+
                    "Contents: " +
                    "42 checkers(21 yellow, 21 red) " +
                    "Grid with checker catcher " +
                    "Base / handle " +
                    "Instructions " +
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Dark Is The Night",
                    Game_time ="1-15 min",
                    Number_of_Players ="2",
                    Year_releashed =2015 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="A Hunter has set up camp in a dark and dangerous forest. In the middle of the night she is awakened by a sound in the darkness, just outside the light of her small fire. Again! A guttural growl informs the Hunter that she is not alone. To survive this night, the Hunter will need keen wits and sharp aim with her crossbow. Dark is the Night is a two-player game of hunt-or-be-hunted. One player takes the role of the hunter and can move in the lighted spaces surrounding the campfire while the other player is the monster, secretly moving through the darkness.With only limited tools at their disposal, each player tries to eliminate the other before daybreak. "+
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Daldøs",
                    Game_time ="20 min",
                    Number_of_Players ="2",
                    Year_releashed =1900 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="An old scandinavian game, played in certain parts of Denmark and Norway. Two players take turns rolling the dice to try and free their pegs for movement, then try to capture the opponents pegs before they can ambush your starting pieces. The board consists of three lines of holes for the pegs, the middle one being one hole longer than the two sides.The two side lines are filled with each player's pegs. The number of pegs vary according to local tradition, typically 16 in Denmark and 12 in Norway. The game uses a pair of special four sided dice marked A, II, III and IV.You need to roll an A to free one of your pieces, the other rolls are used to move the pegs once freed.A peg may never overtake your other pegs, but must keep their place in the line. Once freed the pieces move down the middle aisle and if they manage to avoid being captured they move into the opponent's starting line, capturing the unfree pegs. The origins of the game are unknown but it is believed to be inspired by certain middle - eastern and north african games, brought back by either vikings or crusaders. "+
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Diamond",
                    Game_time ="30 min",
                    Number_of_Players ="2",
                    Year_releashed = 2012,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="Another connection game by Larry Back uses a unique, diamond-shaped board made of interlocking squares and triangles. Equipment: 12 black and 12 white pieces for two players, with a neutral set of 15 red pieces.These will be played onto the points of the squares and triangles, and there is a total of 62 playable points on the board.Goal: to occupy the the four corners of any square with your pieces. Game play: during the first phase, players take turns placing their pieces onto any point of the board.If the winning configuration hasn't been achieved yet, then the second phase begins, in which pieces can be moved to an adjacent point in any direction. Capturing: a piece can only be captured if it is on a corner of a triangle and is the only piece an opponent has on that triangle or pair thereof. This means that only one piece can be captured at a time; if a move causes you to corner two of an opponent's pieces nothing happens. A captured piece is replaced with a red one. Red pieces: once placed, they cannot be moved around, but must remain next to at least one black or white piece.If they become isolated, then during a player's turn, he or she may decide to remove such an isolate instead of moving one of his or her pieces. "+
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Down Fall ",
                    Game_time ="30 min",
                    Number_of_Players ="2",
                    Year_releashed =1970 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="The players have between them a screen with five knobs in it. These knobs link chutes running from the top of the game to its base. The top chutes are loaded with your coloured discs in sequence (1 through 5). On your turn, you twist one of the knobs so as to move one of your discs down. The knobs don't have the same indentations for either player, so you're never sure if you're helping the opponent or not. First one to get his discs down to the base in sequence wins. You also win if you force the opponent's discs to get to the base out of sequence. Several variants are offered in the rules. "+
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Ghosts!",
                    Game_time ="15 min",
                    Number_of_Players ="2",
                    Year_releashed =1980 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="In Ghosts!, each player has four good ghosts and four evil ghosts – but only the player who owns a ghost can see whether it's good or evil (as with the pieces in Stratego). These ghosts start the game in the back rows of a 6x6 game board with the corners removed. Each turn, a player moves one of his ghosts one square orthogonally. Moving into an opponent's ghost kills that ghost. To win, you must get rid of your own evil ghosts, kill your opponent's good ghosts, or move one of your good ghosts off the board from one of your opponent's corner squares. "+
                    "Expansion(s): none"
                },

                new Games {
                    Game_name= "Go",
                    Game_time ="30-180 min",
                    Number_of_Players ="2",
                    Year_releashed =-2000 ,
                    Genre = new List<Genres>(),
                    Rating = new List<Ratings>(),
                    Images = new List<Images>(),
                    Description ="By all appearances, it's just two players taking turns laying stones on a 19×19 (or smaller) grid of intersections. But once its basic rules are understood, Go shows its staggering depth. One can see why many people say it's one of the most elegant brain-burning abstract games in history, with players trying to claim territory by walling off sections of the board and surrounding each other's stones. The game doesn't end until the board fills up, or, more often, when both players agree to end it, at which time whoever controls the most territory wins. The earliest mention of Go (?? (wéi qí)- 'surrounding game') appears in the 'ects' of Confucius (551-479 BC), while the earliest physical evidence is a 17×17 Go board discovered in 1952 in a tomb of the former Han dynasty(206 BC - 9 AD).There is a tangle of conflicting popular and scholarly anecdotes attributing its invention to two Chinese emperors, an imperial vassal and court astrologers. One story has it that Go was invented by the legendary Emperor Yao(ruled 2357 - 2256 BC) as an amusement for his idiot son.A second claims that the Emperor Shun(ruled 2255 - 2205 BC) created the game in hopes of improving his weak - minded son's mental prowess. A third says the person named Wu, a vassal of the Emperor Jie (ruled 1818-1766 BC), inveted Go (as well as games of cards). Finally, a fourth story suggests that Go was developed by court astrologers during the Zhou dynasty (1045-255 BC). A Go set, consisting of a very general - purpose grid and colored stones, can also be used to play a variety of other abstract strategy games, such as Connect6, Go-Moku, Pente, and others. "+
                    "Expansion(s): " +
                    "Poker-Go"
                }
            };

            games.ForEach(ga => context.Games.AddOrUpdate(p => p.Game_name, ga));
            context.SaveChanges();

            var rights = new List<Rights>
            {
                new Rights {Rights_name = "Create", Status = new List<Status>()},
                new Rights {Rights_name = "Read", Status = new List<Status>()},
                new Rights {Rights_name = "Update", Status = new List<Status>()},
                new Rights {Rights_name = "Delete", Status = new List<Status>()}
            };
            rights.ForEach(ri => context.Rights.AddOrUpdate(p => p.Rights_name, ri));
            context.SaveChanges();

            var status = new List<Status>
            {
                new Status {Status_name = "Moderator", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "Super User", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "User", Right = new List<Rights>(), AppUsers = new List<AppUser>()},
                new Status {Status_name = "Guest", Right = new List<Rights>(), AppUsers = new List<AppUser>()}
            };
            status.ForEach(s => context.Status.AddOrUpdate(p => p.Status_name, s));
            context.SaveChanges();

            var wanted_games = new List<Wanted_games>
            {
                new Wanted_games{Wanted_Game_Name= "Touché", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Tokaido", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Monopoly", AppUsers = new List<AppUser>()},
                new Wanted_games{Wanted_Game_Name= "Munchkin", AppUsers = new List<AppUser>()}
            };
            wanted_games.ForEach(w => context.Wanted_game.AddOrUpdate(p => p.Wanted_Game_Name, w));
            context.SaveChanges();

            var images = new List<Images>{
                new Images{Image_path = "/Content/Image/descent.png", GameId = 1},

                new Images{Image_path = "/Content/Image/Ambush/frontpic.jpg", GameId = 6},
                new Images{Image_path = "/Content/Image/Ambush/ambush1.jpg", GameId = 6},
                new Images{Image_path = "/Content/Image/Ambush/ambush2.jpg", GameId = 6},

                new Images{Image_path = "/Content/Image/B17QueenOfTheSkies/frontpic.jpg", GameId = 7},
                new Images{Image_path = "/Content/Image/B17QueenOfTheSkies/b17queenoftheskies1.jpg", GameId = 7},
                new Images{Image_path = "/Content/Image/B17QueenOfTheSkies/b17queenoftheskies2.jpg", GameId = 7},
                new Images{Image_path = "/Content/Image/B17QueenOfTheSkies/b17queenoftheskies3.jpg", GameId = 7},

                new Images{Image_path = "/Content/Image/Friday/frontpic.jpg", GameId = 8},
                new Images{Image_path = "/Content/Image/Friday/friday1.jpg", GameId = 8},
                new Images{Image_path = "/Content/Image/Friday/friday2.jpg", GameId = 8},
                new Images{Image_path = "/Content/Image/Friday/friday3.jpg", GameId = 8},

                new Images{Image_path = "/Content/Image/1st & Goal/frontpic.jpg", GameId = 9},
                new Images{Image_path = "/Content/Image/1st & Goal/1st&goal1.jpg", GameId = 9},
                new Images{Image_path = "/Content/Image/1st & Goal/1st&goal2.jpg", GameId = 9},
                new Images{Image_path = "/Content/Image/1st & Goal/1st&goal3.jpg", GameId = 9},

                new Images{Image_path = "/Content/Image/7 Wonders Duel/frontpic.jpg", GameId = 10},
                new Images{Image_path = "/Content/Image/7 Wonders Duel/7wondersduel1.jpg", GameId = 10},
                new Images{Image_path = "/Content/Image/7 Wonders Duel/7wondersduel2.jpg", GameId = 10},
                new Images{Image_path = "/Content/Image/7 Wonders Duel/7wondersduel3.jpg", GameId = 10},

                new Images{Image_path = "/Content/Image/Abalone/frontpic.jpg", GameId = 11},
                new Images{Image_path = "/Content/Image/Abalone/abalone1.jpg", GameId = 11},
                new Images{Image_path = "/Content/Image/Abalone/abalone2.jpg", GameId = 11},

                new Images{Image_path = "/Content/Image/Agon/frontpic.jpg", GameId = 12},
                new Images{Image_path = "/Content/Image/Agon/agon1.jpg", GameId = 12},
                new Images{Image_path = "/Content/Image/Agon/agon2.jpg", GameId = 12},

                new Images{Image_path = "/Content/Image/and then, we held hands/frontpic.jpg", GameId = 13},
                new Images{Image_path = "/Content/Image/and then, we held hands/heldhand1.jpg", GameId = 13},
                new Images{Image_path = "/Content/Image/and then, we held hands/heldhand2.jpg", GameId = 13},
                new Images{Image_path = "/Content/Image/and then, we held hands/heldhand3.jpg", GameId = 13},

                new Images{Image_path = "/Content/Image/Asalto/frontpic.jpg", GameId = 14},
                new Images{Image_path = "/Content/Image/Asalto/asalto1.jpg", GameId = 14},

                new Images{Image_path = "/Content/Image/Backgammon/frontpic.jpg", GameId = 15},
                new Images{Image_path = "/Content/Image/Backgammon/backgammon1.jpg", GameId = 15},

                new Images{Image_path = "/Content/Image/Battleship/frontpic.jpg", GameId = 16},
                new Images{Image_path = "/Content/Image/Battleship/battleship1.jpg", GameId = 16},
                new Images{Image_path = "/Content/Image/Battleship/battleship2.jpg", GameId = 16},

                new Images{Image_path = "/Content/Image/Blockade/frontpic.jpg", GameId = 17},

                new Images{Image_path = "/Content/Image/Bloodbowl 1st edition/frontpic.jpg", GameId = 18},
                new Images{Image_path = "/Content/Image/Bloodbowl 1st edition/bloodbowl1.jpg", GameId = 18},

                new Images{Image_path = "/Content/Image/Bloodbowl 2nd edition/frontpic.jpg", GameId = 19},
                new Images{Image_path = "/Content/Image/Bloodbowl 2nd edition/bloodbowl2nd1.jpg", GameId = 19},
                new Images{Image_path = "/Content/Image/Bloodbowl 2nd edition/bloodbowl2nd2.jpg", GameId = 19},

                new Images{Image_path = "/Content/Image/Camelot/frontpic.jpg", GameId = 20},
                new Images{Image_path = "/Content/Image/Camelot/camelot1.jpg", GameId = 20},
                new Images{Image_path = "/Content/Image/Camelot/camelot2.jpg", GameId = 20},

                new Images{Image_path = "/Content/Image/Caverna cave vs cave/frontpic.jpg", GameId = 21},
                new Images{Image_path = "/Content/Image/Caverna cave vs cave/caverna1.jpg", GameId = 21},
                new Images{Image_path = "/Content/Image/Caverna cave vs cave/caverna2.jpg", GameId = 21},
                new Images{Image_path = "/Content/Image/Caverna cave vs cave/caverna3.jpg", GameId = 21},

                new Images{Image_path = "/Content/Image/Checkers/frontpic.jpg", GameId = 22},
                new Images{Image_path = "/Content/Image/Checkers/checkers1.jpg", GameId = 22},
                new Images{Image_path = "/Content/Image/Checkers/checkers2.jpg", GameId = 22},

                new Images{Image_path = "/Content/Image/Chaturanga/frontpic.jpg", GameId = 23},
                new Images{Image_path = "/Content/Image/Chaturanga/chaturanga1.jpg", GameId = 23},
                new Images{Image_path = "/Content/Image/Chaturanga/chaturanga2.jpg", GameId = 23},

                new Images{Image_path = "/Content/Image/Chess/frontpic.jpg", GameId = 24},
                new Images{Image_path = "/Content/Image/Chess/Chess1.jpg", GameId = 24},
                new Images{Image_path = "/Content/Image/Chess/Chess2.jpg", GameId = 24},

                new Images{Image_path = "/Content/Image/Connect4/frontpic.jpg", GameId = 25},
                new Images{Image_path = "/Content/Image/Connect4/connect1.jpg", GameId = 25},
                new Images{Image_path = "/Content/Image/Connect4/connect2.jpg", GameId = 25},

                new Images{Image_path = "/Content/Image/Dark Is The Night/frontpic.jpg", GameId = 26},
                new Images{Image_path = "/Content/Image/Dark Is The Night/darksithenight1.jpg", GameId = 26},

                new Images{Image_path = "/Content/Image/Daldos/frontpic.jpg", GameId = 27},
                new Images{Image_path = "/Content/Image/Daldos/daldos1.jpg", GameId = 27},
                new Images{Image_path = "/Content/Image/Daldos/daldos2.jpg", GameId = 27},

                new Images{Image_path = "/Content/Image/Diamond/frontpic.jpg", GameId = 28},

                new Images{Image_path = "/Content/Image/Dowl Fall/frontpic.jpg", GameId = 29},
                new Images{Image_path = "/Content/Image/Dowl Fall/dowlfall1.jpg", GameId = 29},

                new Images{Image_path = "/Content/Image/Ghosts/frontpic.jpg", GameId = 30},
                new Images{Image_path = "/Content/Image/Ghosts/ghosts1.jpg", GameId = 30},
                new Images{Image_path = "/Content/Image/Ghosts/ghosts2.jpg", GameId = 30},

                new Images{Image_path = "/Content/Image/Go/frontpic.jpg", GameId = 31},
                new Images{Image_path = "/Content/Image/Go/go1.jpg", GameId = 31},

            };

            images.ForEach(i => context.Images.AddOrUpdate(p => p.ImageId, i));
            context.SaveChanges();


        }

        void AddOrUpdateGenre(GamerForumContext context, string genre, string game_name)
        {
            var gen = context.Genres.SingleOrDefault(g => g.Genre_name == genre);
            var gam = context.Games.SingleOrDefault(ga => ga.Game_name == game_name);

            if (gam == null)
                gen.Game.Add(context.Games.SingleOrDefault(g => g.Game_name == game_name));
        }
    }
}

