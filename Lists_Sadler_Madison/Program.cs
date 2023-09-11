// See https://aka.ms/new-console-template for more information
// Creates a string list called games
// Initializes games with game titles: Skyrim, Undertale, Minecraft, Bioshock, and Sly Cooper
List<string> games = new List<string>
{
    "Skyrim",
    "Undertale",
    "Minecraft",
    "Bioshock",
    "Sly Cooper"
};
// Creates a string array called otherGames
// Initializes otherGames with game titles: Don't Starve Together, Saiko No Sutoka, Deltarune, Goose Goose Duck, and Vampire: The Masquerade - Bloodlines
string[] otherGames = new string[]
      {
          "Don't Starve Together",
          "Saiko No Sutoka",
          "Deltarune",
          "Goose Goose Duck",
          "Vampire: The Masquerade - Bloodlines"
      };

// Creates a foreach loop that prints each game title in games
foreach (string game in games)
{
    Console.WriteLine(game);
}

// Prints to console the number of games in games
Console.WriteLine($"\nGames in list: {games.Count}");

// Adds a range to games using otherGames
games.AddRange(otherGames);

// Prints to console the new number of games in games
Console.WriteLine($"\nGames in list: {games.Count}");

// Creates an if else statement that prints "MASTER CHIEF IS IN THE HOUSE" if games contains Halo
// If games does not contain Halo, then the else statement adds Halo to games
if(games.Contains("Halo"))
{
    Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!");
}
else
{
    games.Add("Halo");
}

// Creates an integer called myInt and sets it to 6
int myInt = 6;

// Creates an if else statement that removes the game at index 6 if the number of games is greater than myInt's value
// If the number of games is less that myInt's value, then the else statement prints to the console "Game not found"
if(myInt < games.Count)
{
    games.RemoveAt(myInt);
}
else
{
    Console.WriteLine("\nGame not found!");
}

// Prints to console "All games in the list:"
Console.WriteLine("\nAll games in the list:");

// Creates a foreach loop that loops through the games list and prints each game to the console
foreach(string game in games)
{
    Console.WriteLine(game);
}

// Sorts the games list
games.Sort();

// Prints to console "Sorted games list:"
Console.WriteLine("\nSorted games list:");
// Creates a foreach loop that loops through the games list and prints each game to the console
foreach (string game in games)
{
    Console.WriteLine(game);
}

// Creates a string array called newList and initializes it to the same size as the games list
string[] newList = new string[games.Count];

// Copys the games list to newList
games.CopyTo(newList);

// Clears the games list
games.Clear();

// Prints to console "New List:"
Console.WriteLine("\nNew List:");
// Creates a foreach loop that loops through newList and prints each game in it to the console
foreach (string game in newList)
{
    Console.WriteLine(game);
}