using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.robot_name
{
    public class Robot
    {
        public string Name { get; set; }
        public static Random randomizer = new Random();
        public static List<string> ExistingRobots = new List<string>();

        public Robot()
        {
            this.Reset();
        }

        private static char RandomLetter()
        {
            int num = randomizer.Next(0, 26);
            return (char)('A' + num);
        }

        internal void Reset()
        {
            var newName = new StringBuilder();
            newName.Append(RandomLetter()).Append(RandomLetter()).ToString();

            //string newNumber = String.Format("{0:000}", randomizer.Next(999).ToString());
            string finalName = newName + randomizer.Next(999).ToString("000");
            
            if (ExistingRobots.Contains(finalName))
                this.Reset();
            else
            {
                ExistingRobots.Add(finalName);
                Name = finalName;
            }
        }
    }
}