using System.Collections.Generic;
using System.Linq;

namespace Exercism.grade_school
{
    public class School
    {
        public List<List<string>> Roster;

        public School()
        {
            Roster = new List<List<string>>();
        }

        internal void Add(string name, int grade)
        {
            InitRoster();
            if (Roster[grade].Count == 0)
            {
                Roster[grade] = new List<string>();
            }

            Roster[grade].Add(name);
            Roster[grade].Sort();
        }

        internal List<string> Grade(int level)
        {
            InitRoster();
            if (Roster[level] == null)
            {
                Roster[level] = new List<string>();
            }

            return Roster[level].ToList();
        }

        internal void InitRoster()
        {
            if (Roster.Count == 0)
            {
                for (int i = 0; i <= 12; i++)
                {
                    Roster.Add(new List<string>());
                }
            }
        }
    }
}