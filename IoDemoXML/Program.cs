using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame videoGame;
            videoGame = InitializeVideoGame();
            WriteXmlFile(videoGame);
        }

        public static VideoGame InitializeVideoGame()
        {
            VideoGame videoGame = new VideoGame()
            {
                Id = 1,
                Name = "Mario",
                Platform = VideoGame.PlatformName.XBOX
            };

            return videoGame;
        }

        public static void WriteXmlFile(VideoGame videoGame)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VideoGame));
            {
                StreamWriter sWriter = new StreamWriter("Data.xml");

                using (sWriter)
                {
                    serializer.Serialize(sWriter, videoGame);
                }
            };
        }

        public static VideoGame ReadXmlFile()
        {
            VideoGame videoGame;

            StreamReader sReader = new StreamReader("Data.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(VideoGame));

            using (sReader)
            {
                object xmlObject = serializer.Deserialize(sReader);
                videoGame = xmlObject as VideoGame;

                videoGame = serializer.Deserialize(sReader) as VideoGame;
            }

            return videoGame;
        }
    }
}
