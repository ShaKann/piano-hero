using Melanchall.DryWetMidi.MusicTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoHero
{
    public class NoteManager
    {
        private Dictionary<string, int>  intervals = new Dictionary<string, int> {
            { "Oct", 12},
            { "P5", 7},
            { "M3", 4},
            { "m3", 3}
        };

        private List<NoteName> possibleNotes = new List<NoteName> { 
            NoteName.C,
            NoteName.D,
            NoteName.E
        };
    }
}
