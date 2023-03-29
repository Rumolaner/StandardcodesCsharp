﻿namespace SCCsharpSearch
{
    public static class SearchLinear
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static int Search(List<int> iList, int iSearch)
        {
            for (int i = 0; i < iList.Count; i++)
            {
                Logger.Info("Loop Iteration " + (i + 1).ToString());
                Logger.Info("Comparing search value (" + iSearch.ToString() + ") with position " + i.ToString() + " (" + iList[i].ToString() + ")");
                if (iSearch == iList[i])
                {
                    Logger.Info("Search value found at iteration " + (i + 1).ToString());
                    return i;
                }
            }

            Logger.Info("Search value not found");
            return -1;
        }
    }

    public static class SearchBinary
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static int Search(List<int> iList, int iSearch)
        {
            int start = 0, end = iList.Count - 1;
            int i = 1;
            while (start < end)
            {
                Logger.Info("Loop Iteration " + i.ToString());
                int medium = start + (end - start) / 2;
                Logger.Info("Comparing search value (" + iSearch.ToString() + ") with position " + medium.ToString() + " (" + iList[medium].ToString() + ")");
                if (iSearch == iList[medium])
                {
                    Logger.Info("Search value found at iteration " + i.ToString());
                    return medium;
                }

                if (iSearch > iList[medium])
                {
                    Logger.Info("Search value bigger than comparative value");
                    Logger.Info("New start value: " + medium.ToString());
                    Logger.Info("Old end value: " + end.ToString());
                    start = medium;
                }

                if (iSearch < iList[medium])
                {
                    Logger.Info("Search value bigger than comparative value");
                    Logger.Info("New end value: " + medium.ToString());
                    Logger.Info("Old start value: " + start.ToString());
                    end = medium;
                }

                i++;
            }

            Logger.Info("Search value not found");
            return -1;
        }
    }

    public static class SearchInterpol
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static int Search(List<int> iList, int iSearch)
        {
            Logger.Info("Start Interpolation Search");
            int low = 0, high = iList.Count - 1;

            while (low < high && iList[low] < iSearch && iList[high] > iSearch)
            {
                Logger.Info("Low: " + low.ToString());
                Logger.Info("High: " + high.ToString());

                int pos = low += ((high - low) * (iSearch - iList[low]) / (iList[high] - iList[low]  ));

                Logger.Info("pos: " + pos.ToString());

                if (iSearch == iList[pos])
                {
                    Logger.Info("End Interpolation Search with pos = " + pos.ToString());
                    return pos;
                }

                if (iSearch < iList[pos])
                {
                    high = pos;
                }

                if (iSearch > iList[pos])
                {
                    low = pos;
                }
            }

            Logger.Info("End Interpolation Search without success");
            return -1;
        }
    }
}