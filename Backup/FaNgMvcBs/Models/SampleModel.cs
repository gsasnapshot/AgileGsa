using System;
using System.Collections.Generic;

namespace FaNgMvcBs.Models
{
    public class SampleModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public List<SampleModel> Children { get; set; }

        private Random rand;
        private readonly string[] firstNames = new string[] { "Bruce", "Scott", "James", "Jean", "Diana", "Ororo" };
        private readonly string[] lastNames = new string[] { "Banner", "Summers", "Howlett", "Grey", "Smith", "Munroe" };

        public SampleModel(int id)
        {
            rand = new Random(id);
            Id = id;
            ParentId = 0;
            Name = randomName();
            Created = DateTime.UtcNow;
            Children = new List<SampleModel>();
        }

        private string randomName()
        {
            return string.Format("{0} {1}", firstNames[rand.Next(0, firstNames.Length)],
                lastNames[rand.Next(0, lastNames.Length)]);
        }

        public static List<SampleModel> BuildModels()
        {
            var result = new List<SampleModel>();
            var random = new Random();
            for (var i = 0; i < random.Next(5, 10); i++)
            {
                result.Add(new SampleModel(i + 1));
            }
            return result;
        }
    }
}