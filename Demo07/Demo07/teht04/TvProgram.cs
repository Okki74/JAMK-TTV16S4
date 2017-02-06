using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    [Serializable]
    class TvProgram
    {
        private string name;
        private int channel;
        private string begingTime;
        private string endTime;
        private string infoText;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Channel
        {
            get { return channel; }
            set { channel = value; }
        }
        public string BegingTime
        {
            get { return begingTime; }
            set { begingTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public string InfoText
        {
            get { return infoText; }
            set { infoText = value; }
        }
        public TvProgram (string _name, int _channel,string _beging, string _end, string _infoText)
        {
            Name = _name;
            Channel = _channel;
            BegingTime = _beging;
            EndTime = _end;
            InfoText = _infoText;
        }
    }
}
