using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class WasingMa
    {
        //properties
        public int WatherTemp { get; set; }
        public int Speed { get; set; }
        public int Time { get; set; }
        public int ProgNum { get; set; }
        public bool OnOff { get; set; }
        // constructors
        public WasingMa(int temp, int speed, int progNum, bool on)
        {
            WatherTemp = temp;
            Speed = speed;
            ProgNum = progNum;
            OnOff = on;
        }
        public WasingMa(int temp, int speed, int time)
        {
            WatherTemp = temp;
            Speed = speed;
            Time = time;
        }
        public WasingMa(int progNum, int speed)
        {

            Speed = speed;
            ProgNum = progNum;
        }
        // methods
        public void StarProgram(){
            OnOff = true;
        }
        public void StopProgram(){
            OnOff = false;
        }
        public void SetTemp(int temp){
            WatherTemp = temp;
        }
        public void SetSpeed(int speed){
            Speed = speed;
        }
        public void SetProg(int num){
            ProgNum = num;
        } 
        public void Print()
        {
            Console.WriteLine("Vedenlämpötila: " + WatherTemp); // Tehtävän annossa sanottu Console....
            Console.WriteLine("Linkous: " + Speed);
            Console.WriteLine("Ajastin : " + Time);
            Console.WriteLine("Ohjelma numero " + ProgNum);
            Console.WriteLine("Kone on päällä: " + OnOff);

        }
      



    }
}
