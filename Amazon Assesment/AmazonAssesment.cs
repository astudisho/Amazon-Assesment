using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Emit;

namespace Amazon_Assesment
{
    public class Amazon
    {
        public static List<int> Scenes(List<string> labels)
        {
            var resultList = new List<int>();
            int startIndex = 0;
            int lastIndex = 0;
            int currentIndex = 0;
            var currentString = labels.First();

            while (currentIndex < labels.Count)
            {
                //var indexString = labels[currentIndex];

                // Last time the current letter appears.
                lastIndex = labels.LastIndexOf(currentString);

                // If last appear is the same as current index.
                if (lastIndex == currentIndex)
                {
                    resultList.Add(lastIndex - startIndex + 1);
                    currentIndex++;
                    startIndex = currentIndex;
                    if(currentIndex < labels.Count) currentString = labels[currentIndex];
                    continue;
                }

                // Get all different strings.
                var set = new HashSet<string>(labels.GetRange(startIndex, lastIndex - startIndex));

                // Initialize maxIndex
                var maxIndex = 0;
                foreach (var item in set)
                {
                    var index = labels.LastIndexOf(item);

                    if (index > maxIndex) maxIndex = index;
                }
                currentString = labels[maxIndex];
                currentIndex = maxIndex;
            }

            return resultList;
        }

    }
}
