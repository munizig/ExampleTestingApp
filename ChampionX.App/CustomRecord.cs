using System;

namespace ChampionX.App
{
    public class CustomRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public CustomRecord(int id, string name)
        {
            if (id <= 2)
                throw new ArgumentException("Id must be higher than 2.");

            if (string.IsNullOrEmpty(name?.Trim()))
                throw new ArgumentException("Name cannot be empty.");

            Id = id;
            Name = name;
            DateTime = DateTime.Now;
        }
    }

}
