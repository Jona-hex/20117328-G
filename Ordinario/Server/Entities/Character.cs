using System;
namespace ExamenParcial2.Server.Entities
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set;} 
        public string birthday { get; set; }
        public string nickname { get; set; }
        public string portrayed { get; set; }
        
        public Array[] occupation { get; set; }
    }
}