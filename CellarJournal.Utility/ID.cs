using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellarJournal.Model
{
    public static class IDs
    {
        private static List<int> activeIDs;

        public static int ID()
        {
            if (activeIDs == null)
                activeIDs = new List<int>();

            for (int i = 1; i < Int32.MaxValue; i++)
            {
                if (!activeIDs.Contains(i))
                {
                    activeIDs.Add(i);
                    return i;
                }
            }
            throw new Exception();
        }
    }
}
