using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        private string cdName;
        private string band;
        public List<Song> Songs;
        
        // properties
        public string CdName
        {
            get { return cdName; }
            set { cdName = value; }
        }
        public string Band
        {
            get { return band; }
            set { band = value; }
        }
        //constructor
        public CD (string _name,string _band)
        {
            CdName = _name;
            Band = _band;
            Songs = new List<Song>();

        }
        // Methods
        public void AddSong (Song _song)
        {
            Songs.Add(_song);
        }

        public override string ToString()
        {   string str= "Yhtye: "+ Band+" Levy: "+CdName;
            str += "\n Biisit";

            foreach (Song song in Songs)
            {
                str += "\n" + song.ToString();
            }

            return str;
        }
    }
}
