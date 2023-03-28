using NLog;
using System.Linq;

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
            Logger.Info("Start value: " + start.ToString());
            Logger.Info("End value: " + end.ToString());
            int parent = (end - 1) / 2;
            Logger.Info("Parent: " + parent.ToString());

            for (int i = parent; i >= start; i--)
            {
                int childL = (i + 1) * 2 - 1;
                int childR = (i + 1) * 2;
                int biggest = -1;
                Logger.Info("temp parent: " + i.ToString());
                Logger.Info("Left child: " + childL.ToString());
                Logger.Info("Right child: " + childR.ToString());
 
                if (childR <= end && childR >= start)
                {
                    biggest = childR;
                    Logger.Info("Biggest = ChildR: " + biggest.ToString());
                }

                if (childL <= end && childL >= start)
                {
                    if (biggest != childR || iList[biggest] < iList[childL])
                    {
                        biggest = childL;
                        Logger.Info("Biggest = ChildL: " + biggest.ToString());
                    }
                }

                if (biggest == childR || biggest == childL)
                {
                    Logger.Info("Biggest valid index: " + biggest.ToString());
                    if (iList[biggest] > iList[i])
                    {
                        Logger.Info("change parent and biggest child: " + iList[i].ToString() + "/" + iList[biggest].ToString());
                        (iList[biggest], iList[i]) = (iList[i], iList[biggest]);
                        iList = Heapify(iList, biggest, end);
                    }
                }
            }

            Logger.Info("Heapify call end");
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
                iList = Heapify(iList, 0, i-1);
            }

            Logger.Info("End insertion sort");
            return iList;
        }
    }

    public static class SortMerge
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static List<int> Sort(List<int> iList)
        {
            Logger.Info("Start merge sort");

            if (iList.Count == 1)
            {
                Logger.Info("List is 1 element, return list");
                return iList;
            }
            else
            {
                Logger.Info("Split list in left list and right list");
                List<int> iLinks = iList.GetRange(0, iList.Count / 2);
                Logger.Info("left list has " + iLinks.Count + " elements");
                List<int> iRechts = iList.GetRange(iList.Count / 2, iList.Count - iList.Count / 2);
                Logger.Info("right list has " + iRechts.Count + " elements");
                List<int> iRet = new();

                iLinks = SortMerge.Sort(iLinks);
                iRechts = SortMerge.Sort(iRechts);

                Logger.Info("mergin left and right list");
                while (iLinks.Count > 0 && iRechts.Count > 0)
                {
                    if (iLinks[0] > iRechts[0])
                    {
                        Logger.Info("1st element left list is bigger than 1st element right list");
                        iRet.Add(iLinks[0]);
                        iLinks.RemoveAt(0);
                    }
                    else
                    {
                        Logger.Info("1st element right list is bigger than 1st element left list");
                        iRet.Add(iRechts[0]);
                        iRechts.RemoveAt(0);
                    }
                }

                while (iLinks.Count > 0)
                {
                    Logger.Info("add another element from left list");
                    iRet.Add(iLinks[0]);
                    iLinks.RemoveAt(0);
                }

                while (iRechts.Count > 0) 
                {
                    Logger.Info("add another element from right list");
                    iRet.Add(iRechts[0]);
                    iRechts.RemoveAt(0);
                }

                return iRet;
            }

/*

            for (int i = 0; i < iList.Count - 1; i++)
            {
                Logger.Info("Outer loop Iteration " + (i + 1).ToString());
                int j = i + 1;
                int value = iList[j];
                Logger.Info("Finding insertion position for " + value.ToString());
                while (j > 0 && iList[j - 1] < value)
                {
                    Logger.Info("shifting right " + iList[j - 1].ToString());
                    iList[j] = iList[j - 1];
                    j--;
                }

                iList[j] = value;
            }

            Logger.Info("End insertion sort");
            return iList; */

        }
    }
}