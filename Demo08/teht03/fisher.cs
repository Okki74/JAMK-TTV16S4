using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class fisher
    {
        private string name;
        private string teleNum;

        public List<fish> fishes;
        public string Name { get { return name; } set { name = value; } }
        public string TeleNum { get { return teleNum; } set { teleNum = value; } }

        public fisher(string _name, string _teleNum)
        {
            Name = _name;
            TeleNum = _teleNum;
            fishes = new List<fish>();
        }
        public string AddFish(fish _fish)
        {
            fishes.Add(_fish);
            return ("Fisherman: "  + Name + " get a new fish "+_fish.ToString());
        }
        public string PrintData()
        {
            string str="Fisherman " + Name + "has got following fishes:\n";
            
            foreach(fish f in fishes)
            {
                str +=(f.ToString());
            }
            return str;
        }
    }  
}
