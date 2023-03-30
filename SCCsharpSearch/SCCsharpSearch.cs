using NLog;
using NLog.Fluent;
using System.Xml.Linq;

namespace SCCsharpSearch
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

                int pos = low + ((high - low) * (iSearch - iList[low]) / (iList[high] - iList[low]  ));

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

    public class BFSNode
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public int Value { get; set; }
        public bool Visited { get; set;}
        public List<BFSNode> Neighbors { get; set; }

        public BFSNode(int value)
        {
            Logger.Info("Erstelle Knoten mit dem Wert " + value.ToString());
            this.Value = value;
            this.Visited = false;
            this.Neighbors = new();
        }

        public void AddNeighbor(ref BFSNode neighbor)
        {
            Logger.Info("Verbinde zwei Nachbarn mit den Werten " + this.Value.ToString() + " und " + neighbor.Value.ToString());
            neighbor.Neighbors.Add(this);
            this.Neighbors.Add(neighbor);
        }
    }

    public static class SearchBFS
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Search(ref SCCsharpSearch.BFSNode StartNode)
        {
            Logger.Info("Starte Durchlauf mit Knoten " + StartNode.Value.ToString());
            List<BFSNode> ToVisit = new() { StartNode };
            
            while(ToVisit.Count > 0)
            {
                SCCsharpSearch.BFSNode node = ToVisit[0];
                Logger.Info("Durchgang mit Knoten " + node.Value.ToString());
                node.Visited = true;
                ToVisit.RemoveAt(0);
                for(int i = 0; i < node.Neighbors.Count; i++)
                {
                    Logger.Info("Nachbarn prüfen ob besucht: " + node.Neighbors[i].Value.ToString());
                    if (!node.Neighbors[i].Visited)
                    {
                        Logger.Info("Nachbar noch nicht besucht");
                        ToVisit.Add(node.Neighbors[i]);
                    } else
                    {
                        Logger.Info("Nachbar schon besucht");
                    }
                }
            }
        }
    }

    public static class SearchDFS
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Search(ref SCCsharpSearch.BFSNode StartNode)
        {
            Logger.Info("Starte Durchlauf mit Knoten " + StartNode.Value.ToString());
            Logger.Info("Setze aktuellen Knoten als visited");
            StartNode.Visited = true;

            for (int i = 0; i < StartNode.Neighbors.Count; ++i)
            {
                Logger.Info("Nachbarn prüfen ob besucht: " + StartNode.Neighbors[i].Value.ToString());
                if (!StartNode.Neighbors[i].Visited)
                {
                    Logger.Info("Nachbar noch nicht besucht, besuche jetzt");
                    SCCsharpSearch.BFSNode node = StartNode.Neighbors[i];
                    SCCsharpSearch.SearchDFS.Search(ref node);
                }
                else
                {
                    Logger.Info("Nachbar schon besucht");
                }
            }
        }
    }
}