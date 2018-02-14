using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternV2
{
    public class Observable
    {

        public event EventHandler ColorChanged;
        public event EventHandler SizeChanged;

        private Thing thing = new Thing(12, Color.Black);

        public int Size
        {
            get => thing.Size;
            set
            {
                if(value != thing.Size)
                {
                    thing.Size = value;
                    OnSizeChange();
                }
            }
        }

        public Color Color
        {
            get => thing.Color;
            set
            {
                thing.Color = value;
                OnColorChange();
            }
        }

        public void OnColorChange()
        {
            if(ColorChanged != null)
                ColorChanged(thing, EventArgs.Empty);
        }

        public void OnSizeChange()
        {
            if(SizeChanged != null)
                SizeChanged(thing, EventArgs.Empty);
        }

        //public IDisposable Subscribe(IObserver<Font> observer)
        //{
        //    if (!observers.Contains(observer))
        //    {
        //        observers.Add(observer);
        //        observer.OnNext(font);
        //    }

        //    return new Unsubscriber<Font>(observers, observer);
        //}

        //public void ChangeFont(Font font)
        //{

        //    foreach(var observer in observers)
        //    {
        //        observer.OnNext(font);
        //    }

        //}

        //public void CleanUp()
        //{

        //    foreach(var observer in observers)
        //    {
        //        if(observers.Contains(observer))
        //        {
        //            observer.OnCompleted();
        //        }
        //        observers.Clear();
        //    }

        //}

        //internal class Unsubscriber<Item> : IDisposable
        //{

        //    private List<IObserver<Item>> observers;
        //    private IObserver<Item> observer;

        //    public Unsubscriber(List<IObserver<Item>> observers, IObserver<Item> observer)
        //    {
        //        this.observers = observers;
        //        this.observer = observer;
        //    }

        //    public void Dispose()
        //    {
        //        if (observers.Contains(observer))
        //        {
        //            observers.Remove(observer);
        //        }
        //    }
        //}
    }
}
