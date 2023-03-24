using NLog;

namespace SCCsharpSort
{
    public static class SortBubble
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start bubble sort");
            for (int i = iList.Count - 1; i > 1; i--)
            {
                Logger.Info("Outer loop Iteration " + (iList.Count - i).ToString());
                for (int j = 0; j < i; j++)
                {
                    Logger.Info("Inner loop Iteration " + (j + 1).ToString());
                    if (iList[j] > iList[j + 1])
                    {
                        Logger.Info("Change " + i.ToString() + "/" + iList[i].ToString() + " with " + j.ToString() + "/" + iList[j].ToString());
                        (iList[j], iList[i]) = (iList[j], iList[i]);
                    }
                }
            }
            Logger.Info("End bubble sort");

            return iList;
        }
    }

    public static class SortBubbleOpt
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start optimized bubble sort");
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
                        (iList[i], iList[j]) = (iList[j], iList[j]);
                        switched = true;
                    }
                }

                if (!switched)
                {
                    Logger.Info("No switches for the last outer iterations, process finished");
                    return iList;
                }
            }

            Logger.Info("End optimized bubble sort");
            return iList;
        }
    }

    public static class SortSelect
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start selection sort");
            int temp;

            for (int i = 0; i < iList.Count - 1; i++)
            {
                Logger.Info("Outer loop Iteration " + (i + 1).ToString());
                temp = i + 1;

                for (int j = i + 1; j < iList.Count; j++)
                {
                    Logger.Info("Inner loop Iteration " + j.ToString());
                    if (iList[j] > iList[temp])
                    {
                        Logger.Info("New biggest number found " + j.ToString() + "/" + iList[j].ToString());
                        temp = j;
                    }

                }

                if (iList[i] < iList[temp])
                {
                    Logger.Info("Change " + i.ToString() + "/" + iList[i].ToString() + " with " + temp.ToString() + "/" + iList[temp].ToString());
                    (iList[i], iList[temp]) = (iList[temp], iList[i]);
                }

            }

            Logger.Info("End selection sort");
            return iList;
        }
    }

    public static class SortInsert
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start insertion sort");

            for (int i = 0; i < iList.Count-1; i++)
            {
                Logger.Info("Outer loop Iteration " + (i + 1).ToString());
                int j = i + 1;
                int value = iList[j];
                Logger.Info("Finding insertion position for " + value.ToString());
                while (j > 0 && iList[j - 1] < value)
                {
                    Logger.Info("shifting right " + iList[j-1].ToString());
                    iList[j] = iList[j - 1];
                    j--;
                }

                iList[j] = value;
            }

            Logger.Info("End insertion sort");
            return iList;
        }
    }

    public static class SortHeap
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Heapify(List<int> iList, int start, int end)
        {
            int parent = (end - 1) / 2;
            int childL = 


            return iList;
        }

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start heap sort");
            Logger.Info("Initialise Heap");
            iList = Heapify(iList, 0, iList.Count-1);

            Logger.Info("start iteration");
            for (int i = iList.Count-1; i > 0; i--)
            {
                Logger.Info("Loop Iteration " + (i + 1).ToString());
                (iList[i], iList[0]) = (iList[0], iList[i]);
                iList = Heapify(iList, 0, i);
            }

            Logger.Info("End insertion sort");
            return iList;
        }
    }
}