using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Memento.MyExample
{
    interface IMemento
    {
        void restor();
    }
    interface IOriginator
    {
        IMemento Save();
    }

    class Originator : IOriginator
    {
        string _state;
        public IMemento Save()
        {
            throw new NotImplementedException();
        }
        public void SetState(string state)
        {
            _state = state;

        }
    }
 
    // as snapshot
    class Memento : IMemento
    {
        Originator _origin;
        string _state;
        public void restor()
        {
            _origin.SetState(_state);
        }
        public void MementoTo(Originator orig, string state)
        {
            _origin = orig;
            state = this._state;
        }
    }

    class CareTaker
    {
        List<IMemento> _history;
        Originator _originator;
        public void Undo()
        {
            _history.Remove(_history[_history.Count - 1]);
       
        }
        public void backup()
        {

        }
       
    }
}
