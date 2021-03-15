using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.bob
{
    public class Bob
    {
        private string formattedSentence;

        public string Hey(string sentence)
        {
            formattedSentence = sentence.TrimEnd();

            if (formattedSentence == string.Empty)
            {
                return "Fine. Be that way!";
            }
            else if (isYelling())
            {
                return "Whoa, chill out!";
            }
            else if (isQuestioning())
            {
                return "Sure.";
            }
            else
            {
                return "Whatever.";
            }
        }


        private bool isYelling()
        {
            bool _isExclamation = false;
            bool _isUpperOnly = true;

            _isExclamation = (formattedSentence[formattedSentence.Length - 1] == '!');
            _isUpperOnly = isUpperOnly(formattedSentence);

            return _isUpperOnly || (_isUpperOnly && _isExclamation);
        }

        private bool isQuestioning()
        {
            return (formattedSentence[formattedSentence.Length - 1] == '?');
           
        }

        private bool isUpperOnly(string stringToTest)
        {
            bool hasLetter = false;

            foreach (char item in stringToTest)
            {
                if (Char.IsLower(item))
                    return false;

                if (Char.IsLetter(item))
                    hasLetter = true;
            }

            if (hasLetter)
                return true;
            else
                return false;
        }
    }
}