using PokeDo.Battle;
using PokeDo.Declarations;
using PokeDo.Menu;
using PokeDo.Pokemon;
using PokeDo.Quest;
using System.Runtime.InteropServices;
using System.Text;
using static PokeDo.Menu.Texts;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
// Type combination chart 1st generation => https://img.pokemondb.net/images/typechart-gen1.png
// PokeName translator => C:\Users\shino\OneDrive - TechnofuturTIC\JavaScript\JavascriptCode\Exo\Exo10_API

// property = UpperCamelCase
// private property (attribute) = _lowerCamelCase
// variables & parameters = lowerCamelCase
// method's name = UpperCamelCase
// class's name = UpperCamelCase

//Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = Encoding.UTF8;

#region Variables and instances

// General
int answer;
int userInput;
int isContinueGame_int = 1;
Pokemon myPokemon = new Pokemon();
QuestGestion gestionQuest = new QuestGestion();
GymGestion gestionGym = new GymGestion();
Menu1 menu1 = new Menu1();
Menu2 menu2 = new Menu2();
Menu3 menu3 = new Menu3();

// Type caracteristics
TypeDeclarations typeDeclaration = new TypeDeclarations();
PokeType grass = typeDeclaration.grass();
PokeType fire = typeDeclaration.fire();
PokeType water = typeDeclaration.water();
PokeType rock = typeDeclaration.rock();

// Gym pokemons
GymPokeDeclarations pokeDeclaration = new GymPokeDeclarations();
Pokemon geodude = pokeDeclaration.Geodude(rock);

// Gyms
GymDeclarations gymDeclaration = new GymDeclarations();
Gym pewter = gymDeclaration.Pewter(geodude);
gestionGym._gymList.Add(pewter);

myPokemonDeclarations introChoice = new myPokemonDeclarations();

ClassToSerialize classToSerialize = new ClassToSerialize();

#endregion

#region Intro

if (File.Exists("jsonText.json"))
{
    Tools.DeSerialization(ref classToSerialize);

    gestionQuest._pass = classToSerialize._pass;
    myPokemon = classToSerialize._myPokemon;
    myPokemon._name = classToSerialize._name;
    gestionGym._gymList = classToSerialize._gymList;
    gestionQuest._questList = classToSerialize._questList;
}


if (gestionQuest._pass == null)
{
    gestionQuest.SetPass();

    myPokemon = introChoice.ChoosePokemon(grass, fire, water);
}

myPokemon.CreateLevelTable();

#endregion

#region Main Menu

while (isContinueGame_int == 1)
{
    answer = 2;
    Console.WriteLine("Please choose by number");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1 : MY POKEMON");
    Console.WriteLine();
    Console.WriteLine("2 : QUESTS");
    Console.WriteLine();
    Console.WriteLine("3 : BATTLE");
    Console.WriteLine();
    Console.WriteLine();

    int menuChoice = Tools.newUserInput(3);
    Console.WriteLine();

    switch (menuChoice)
    {
        case 1:
            menu1.MenuPokemon(myPokemon);
            break;

        case 2:
            menu2.MenuQuest(myPokemon);

            break;

        case 3:
            menu3.MenuBattle(myPokemon, gestionGym);
            break;
    }

    Console.WriteLine("Do you want to continue the game?");
    Console.WriteLine("Please answer by number => 1 : YES / 2 : NO");
    Console.WriteLine();

    isContinueGame_int = Tools.newUserInput(2);
    Thread.Sleep(1000);
    Console.Clear();

    classToSerialize.ParameterToSerialize(gestionQuest._pass, myPokemon, myPokemon._name, gestionGym._gymList, gestionQuest._questList);
    Tools.Serialization(classToSerialize);
}

#endregion

