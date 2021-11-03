using Melanchall.DryWetMidi.MusicTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoHero.Chellenges
{
    public class ChellengeManager
    {
        private Queue<ChellengeTask> tasks;

        public ChellengeManager(ChellengeDefinition definition)
        {
            Definition = definition;
            this.tasks = new Queue<ChellengeTask>(this.Definition.GetTasks());
        }

        public ChellengeDefinition Definition { get; }
 
    }

    public class ChellengeTask
    {
        public Note[] ExpectedNotes { get; set; }
    }

    public abstract class ChellengeDefinition
    {
        internal ChellengeTask[] GetTasks()
        {
            throw new NotImplementedException();
        }
    }
}
