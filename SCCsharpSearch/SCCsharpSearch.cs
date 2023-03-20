namespace SCCsharpSearch
{
    public static class SearchLinear
    {
        public static int search(List<int> iList, int iSearch)
        {
            for (int i = 0; i < iList.Count; i++)
            {
                if (iSearch == iList[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }

    public static class SearchBinary
    {
        public static int search(List<int> iList, int iSearch)
        {
            int start = 0, end = iList.Count - 1;
            while (start <= end)
            {
                int medium = (end - start) / 2;
                if (iSearch == iList[medium])
                {
                    return medium;
                }

                if (iSearch > iList[medium])
                {
                    start = medium;
                }

                if (iSearch < iList[medium])
                {
                    end = medium;
                }
            }

            return -1;
        }
    }

}