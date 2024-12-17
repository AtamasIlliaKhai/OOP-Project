using System;

namespace LibrarySystemB
{
    public class Book : ICloneable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public object Clone()
        {
            return new Book
            {
                Title = this.Title,
                Author = this.Author,
                IsAvailable = this.IsAvailable
            };
        }
    }
}