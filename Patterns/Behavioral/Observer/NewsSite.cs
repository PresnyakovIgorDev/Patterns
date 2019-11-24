using System.Collections.Generic;

namespace Patterns.Behavioral.Observer
{
    public class NewsSite : IObservable<NewsUnit>
    {
        private List<NewsUnit> _units = new List<NewsUnit>();
        private List<IObserver<NewsUnit>> _observers = new List<IObserver<NewsUnit>>();

        
        public void AddObserver(IObserver<NewsUnit> observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver<NewsUnit> observer)
        {
            _observers.Remove(observer);
        }

        public void AddNews(NewsUnit unit)
        {
            _units.Add(unit);
            NotifyAll(unit);
        }

        private void NotifyAll(NewsUnit unit)
        {
            foreach (var observer in _observers)
                observer.Update(unit);
        }
    }
}