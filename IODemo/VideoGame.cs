using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODemo
{
    public class VideoGame
    {
        public enum PlatformName
        {
            NONE,
            XBOX,
            PLAYSTATION
        }

        private int _id;
        private string _name;
        private PlatformName _platform;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public PlatformName Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }

    }
}
