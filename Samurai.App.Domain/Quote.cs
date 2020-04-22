using System;
namespace Samurai.App.Domain
{
    public class Quote
    {
        public Quote()
        {
        }
        public int  Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}
