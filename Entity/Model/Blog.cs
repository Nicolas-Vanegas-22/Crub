using System;

namespace Entity.Model
{
    public class Blog
    {
        public int Idblog { get; set; }
        public int Iduser { get; set; }
        public string qualification { get; set; }
        public string content { get; set; }
        public DateTime publicationdate { get; set; }
        public string featuredimage { get; set; }
        public bool asset { get; set; }
        public int visits { get; set; }



   }
}
