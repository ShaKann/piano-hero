using Melanchall.DryWetMidi.MusicTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoHero.Infrastructure
{
    public interface IInputManager
    {
        void Start(Action<Note[]> callback);
    }

    public class InputManager : IInputManager
    {
        public void Start(Action<Note[]> callback)
        {
            
        }
    }
}
