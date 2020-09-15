using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace Lab_09.Model
{
    public class Sound
    {
        public String Name { get; set; }
        public SoundCategory Category { get; set; }
        public String AudioFile { get; set; }
        public String ImageFile { get; set; }

        public Sound(String name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImageFile = String.Format("/Assets/Audio/{0}/{1}.png", category, name);
        }


    }


    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }


}
