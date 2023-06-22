// See https://aka.ms/new-console-template for more information
using CSharpWorkshopDay4;

Console.WriteLine("Hello, World!");

Movie firstMovie = new Movie();

firstMovie.MovieTitle = "The FLash";
firstMovie.MovieReleaseStatus = true;
firstMovie.MovieReleaseYear = 2023;

string firstMovieStuff = $" The name of the movie is {firstMovie.MovieTitle} and it is being released in {firstMovie.MovieReleaseYear} " +
    $"and the current status of releasing is {firstMovie.MovieReleaseStatus}";
Console.WriteLine(firstMovieStuff);


Movie secondMovie = new Movie();
secondMovie.MovieTitle = "spider man";
secondMovie.MovieReleaseStatus = true;
secondMovie.MovieReleaseYear = 2023;

string secondMovieStuff = $" The name of the movie is {secondMovie.MovieTitle} and it is being released in {secondMovie.MovieReleaseYear} " +
    $"and the current status of releasing is {secondMovie.MovieReleaseStatus}";
Console.WriteLine(secondMovieStuff);


Movie thirdMovie = new Movie();
thirdMovie.MovieTitle = " barbie";
thirdMovie.MovieReleaseStatus = true;
thirdMovie.MovieReleaseYear = 2023;

string thirdMovieStuff = $" The name of the movie is {thirdMovie.MovieTitle} and it is being released in {thirdMovie.MovieReleaseYear} " +
    $"and the current status of releasing is {thirdMovie.MovieReleaseStatus}";
Console.WriteLine(thirdMovieStuff);




// Create cideo game onject as minecraft with the idea
VideoGames FirstVideoGame = new VideoGames();

FirstVideoGame.NameOVideoGame = "Minecraft";
FirstVideoGame.TypeOfGame = " online educational multiplayer sandbox ";
FirstVideoGame.TypeOfGamingDevice = " iphone, ipad, xbox, ps4, pc, android ";
FirstVideoGame.GameReleaseYear = 2011;
string FirstVideoGameOutput =   $"name : {FirstVideoGame.NameOVideoGame} Type of Video Game : {FirstVideoGame.TypeOfGame } where can you play this game : { FirstVideoGame.TypeOfGamingDevice}release year : { FirstVideoGame.GameReleaseYear}";
Console.WriteLine(FirstVideoGameOutput);