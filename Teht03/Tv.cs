using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03{
    class Tv{
        //properties
        public Boolean OnOff { get; set; }
        public int Volume { get; set; }
        public int Chanel { get; set; }
        public int Brightness { get; set; }
        public bool TextTv { get; set; }

        // constructors
        public Tv( bool on, int volume, int brightness, int chanel){
            OnOff = on;
            Volume = volume;
            Brightness = brightness;
            Chanel = chanel;
        }
        // methods
        public void ChangeChannel (int chanel){
            Chanel = chanel;
        } 
        public void VolumeUp(){
            Volume += 5;
        }
        public void VolumeDown(){
            Volume -= 5;
        }
        public void BrightnessUp(){
            Brightness += 5;
        }
        public void BrightnessDown()
        {
            Brightness -= 5;
        }
        public void SetTextTv(){
            if (TextTv == false){
                TextTv = true;
            }
            else { TextTv = false; }
        }
        public void Print(){
            Console.WriteLine("KANAVA: " + Chanel); // Tehtävän annossa sanottu Console....
            Console.WriteLine("VOLUME: " + Volume);
            Console.WriteLine("KIRKKAUS: " + Brightness);
            Console.WriteLine("TEKSTITV" + TextTv);
            Console.WriteLine("Kone on päällä: " + OnOff);
        }
    }
}
