using System;
namespace brew_track.Models
{
    public class Orders
    {
        public int ID { get; set; } // Auto-pop
        public string FirstName { get; set; } // Input Field
        public string Items { get; set; } // Add Value from List, like a to-do list application.
        public string TableNumber { get; set; } // Input Value
        public string CarType { get; set; } // Input Value
    }
}
