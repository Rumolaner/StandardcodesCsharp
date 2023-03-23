using NLog;

namespace SCCsharpSort
{
    public static class SortBubble
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            for (int i = iList.Count - 1; i > 1; i--)
            {
                Logger.Info("Outer loop Iteration " + (iList.Count - i).ToString());
                for (int j = 0; j < i; j++)
                {
                    Logger.Info("Inner loop Iteration " + (j + 1).ToString());
                    if (iList[j] > iList[j + 1])
                    {
                        Logger.Info("Change " + i.ToString() + "/" + iList[i].ToString() + " with " + j.ToString() + "/" + iList[j].ToString());
                        int temp = iList[j];
                        iList[j] = iList[j + 1];
                        iList[j + 1] = temp;
                    }
                }
            }

            return iList;
        }
    }

    public static class SortBubbleOpt
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            for (int i = iList.Count - 1; i > 1; i--)
            {
                Logger.Info("Outer loop Iteration " + (iList.Count - i).ToString());
                bool switched = false;
                for (int j = 0; j < i; j++)
                {
                    Logger.Info("Inner loop Iteration " + (j + 1).ToString());
                    if (iList[j] > iList[j + 1])
                    {
                        Logger.Info("Change " + i.ToString() + "/" + iList[i].ToString() + " with " + j.ToString() + "/" + iList[j].ToString());
                        int temp = iList[j];
                        iList[j] = iList[j + 1];
                        iList[j + 1] = temp;
                        switched = true;
                    }
                }

                if (!switched)
                {
                    Logger.Info("No switches for the last outer iterations, process finished");
                    return iList;
                }
            }

            return iList;
        }
    }

}