using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPI_Server.Models;

namespace WebAPI_Server.Repositories
{
    public static class PersonRepository
    {
        public static IList<Person> GetPeople()
        {
            var appDataPath = GetAppDataPath();
            if (File.Exists(appDataPath))
            {
                var rawContent = File.ReadAllText(appDataPath);
                var people = JsonSerializer.Deserialize<IList<Person>>(rawContent);
                return people;
            }
            return new List<Person>();
        }

        public static void StorePeople(IList<Person> people)
        {
            var appDataPath = GetAppDataPath();
            var rawContent = JsonSerializer.Serialize(people);
            File.WriteAllText(appDataPath, rawContent);
        }

        public static string GetAppDataPath()
        {
            var localAppFolder = GetLocalFolder();
            var appDataPath = Path.Combine(localAppFolder, "People.json");
            return appDataPath;
        }

        public static string GetLocalFolder()
        {
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localAppFolder = Path.Combine(localAppData, "WebAPI_Server");
            if (!Directory.Exists(localAppFolder))
            {
                Directory.CreateDirectory(localAppFolder);
            }
            return localAppFolder;
        }
    }
}
