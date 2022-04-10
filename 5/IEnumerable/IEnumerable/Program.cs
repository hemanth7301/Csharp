using System;
using System.Collections;
namespace ienum
{
    class Program
    {

        public class Player 
        {
            public string name;
            public int runs;
            public Player(string fName, int runs)
            {
                this.name = fName;
                this.runs = runs;
            }

            
        }
        public class Team : IEnumerable
        {
            private Player[] _members;
            public Team(Player[] pArray)
            {
                _members = new Player[pArray.Length];

                for (int i = 0; i < pArray.Length; i++)
                {
                    _members[i] = pArray[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }
            public PeopleEnum GetEnumerator()
            {
                return new PeopleEnum(_members);
            }
        }
        public class PeopleEnum : IEnumerator
        {
            public Player[] _people;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;

            public PeopleEnum(Player[] list)
            {
                _people = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _people.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Player Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Player[] peopleArray = new Player[3]
        {
            new Player("hemanth", 50),
            new Player("phani", 100),
            new Player("mohan", 150),
        };

            Team peopleList = new Team(peopleArray);
            foreach (Player p in peopleList) { 
                Console.WriteLine(p.name + " " + p.runs);
        }
    }
    }
}
