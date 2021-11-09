using Melanchall.DryWetMidi.MusicTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoHero.Infrastructure
{
    public interface IOutputManager
    {
        void SendNote(params Note[] notes);
    }

    public class StringOutputManager : IOutputManager
    {
        private readonly Action<string> printAction;

        public StringOutputManager(Action<string> printAction)
        {
            this.printAction = printAction;
        }

        public void SendNote(params Note[] notes)
        {
            var noteString = $"{string.Join(" ", notes.Select(x => x.ToString()))}";
            this.printAction(noteString);
        }
    }
}
