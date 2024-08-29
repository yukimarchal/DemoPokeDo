using PokeDo.Battle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokeDo.Menu
{
    internal static class Tools
    {
        public static int newUserInput(int nmbOfOptions)
        {
            int userInput = -1;
            Boolean isValid = false;
            while (!isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out userInput);

                if (userInput > 0 && userInput <= nmbOfOptions)
                {
                    return userInput;
                }
                else
                {
                    isValid = false;
                    Console.WriteLine($"Invalid number. Please select by numbers between 1-{nmbOfOptions}");
                    Console.WriteLine();
                }
            }
            return userInput;
        }
        
        public static void Serialization(ClassToSerialize classToSerialize)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(classToSerialize);
            File.WriteAllText("jsonText.json", jsonString);
            
            //File.WriteAllText(path: "SavedData.txt", contents: jsonString);
            //string jasonText = File.ReadAllText(path: "SavedData.txt", contents: jsonString);


            //jsonString = JsonSerializer.Deserialize("SavedData.txt", contents: jsonString);
        }
        public static void DeSerialization(ref ClassToSerialize classToSerialize)
        {
            string jsonString = File.ReadAllText("jsonText.json");
            classToSerialize = JsonSerializer.Deserialize<ClassToSerialize>(jsonString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
