using System;

namespace Patterns.Behavioral.Observer
{
    public class RssObserver : IObserver<NewsUnit>
    {
        public void Update(NewsUnit value)
        {
            Console.WriteLine(value.Title);
        }
    }
}