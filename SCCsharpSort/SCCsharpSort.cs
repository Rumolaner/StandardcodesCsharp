namespace SCCsharpSort
{
    public static class SortBubble
    {
        public static List<int> Sort(List<int> iList)
        {
            for (int i = iList.Count - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (iList[j] > iList[j + 1])
                    {
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
        public static List<int> Sort(List<int> iList)
        {
            for (int i = iList.Count - 1; i > 1; i--)
            {
                bool switched = false;
                for (int j = 0; j < i; j++)
                {
                    if (iList[j] > iList[j + 1])
                    {
                        int temp = iList[j];
                        iList[j] = iList[j + 1];
                        iList[j + 1] = temp;
                        switched = true;
                    }
                }

                if (!switched)
                {
                    return iList;
                }
            }

            return iList;
        }
    }

}