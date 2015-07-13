using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ita
{
    public static class Scopa
    {
        private static List<int> check(int id, int val, List<int> tab, List<int> vall)
        {
            int k;
            if (tab.Count > 7)
            {
                k = 7;
            }
            else
            {
                k = tab.Count;
            }

            if (k >= 1)
            {
                try { if (vall[0] == val) { tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[1] == val) { tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[2] == val) { tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[3] == val) { tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[4] == val) { tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[5] == val) { tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[6] == val) { tab.RemoveAt(6); return tab; } } catch (Exception) { }
            }
            if (k >= 7)
            {
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
            }
            if (k >= 6)
            {
                try { if (vall[0] + vall[2] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); return tab; } } catch (Exception) { }
            }
            if (k >= 5)
            {
                try { if (vall[0] + vall[2] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[3] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
            }
            if (k >= 4)
            {
                try { if (vall[0] + vall[1] + vall[2] + vall[3] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[4] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[4] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[4] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
            }
            if (k >= 3)
            {
                try { if (vall[4] + vall[5] + vall[6] == val) { tab.RemoveAt(4); tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[2] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[5] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[4] + vall[5] == val) { tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[4] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(3); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[5] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[4] + vall[5] == val) { tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[4] + vall[6] == val) { tab.RemoveAt(3); tab.RemoveAt(3); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[5] + vall[6] == val) { tab.RemoveAt(3); tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[3] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[3] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[4] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(2); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[4] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[4] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(3); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] + vall[4] == val) { tab.RemoveAt(2); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[5] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[1] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(0); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(1); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[4] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[4] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(3); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[5] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[3] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[4] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
            }
            if (k >= 2)
            {
                try { if (vall[0] + vall[1] == val) { tab.RemoveAt(0); tab.RemoveAt(0); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[6] == val) { tab.RemoveAt(3); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[4] + vall[5] == val) { tab.RemoveAt(4); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[4] + vall[6] == val) { tab.RemoveAt(4); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[5] == val) { tab.RemoveAt(2); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[6] == val) { tab.RemoveAt(2); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[6] == val) { tab.RemoveAt(0); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[4] == val) { tab.RemoveAt(0); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[5] == val) { tab.RemoveAt(0); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[2] == val) { tab.RemoveAt(1); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[3] == val) { tab.RemoveAt(1); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[4] == val) { tab.RemoveAt(1); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[4] == val) { tab.RemoveAt(2); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[4] == val) { tab.RemoveAt(3); tab.RemoveAt(3); return tab; } } catch (Exception) { }
                try { if (vall[3] + vall[5] == val) { tab.RemoveAt(3); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[5] + vall[6] == val) { tab.RemoveAt(5); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[3] == val) { tab.RemoveAt(0); tab.RemoveAt(2); return tab; } } catch (Exception) { }
                try { if (vall[0] + vall[2] == val) { tab.RemoveAt(0); tab.RemoveAt(1); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[5] == val) { tab.RemoveAt(1); tab.RemoveAt(4); return tab; } } catch (Exception) { }
                try { if (vall[1] + vall[6] == val) { tab.RemoveAt(1); tab.RemoveAt(5); return tab; } } catch (Exception) { }
                try { if (vall[2] + vall[3] == val) { tab.RemoveAt(2); tab.RemoveAt(2); return tab; } } catch (Exception) { }
            }

            tab.Add(id);
            return tab;
        }

        private static void prinAll(List<int> lis, List<int> lis1, List<int> val, List<int> val1, List<int> tab, int num)
        {
            Console.Clear();
            prin(lis);
            Console.WriteLine("\n-------------------------------\n");
            prin(tab);
            Console.WriteLine("\n-------------------------------\n");

            List<int> i = new List<int>();
            try { i.Add(lis1[num]); } catch (ArgumentOutOfRangeException) { }
            for (int a = 0; a < lis1.Count; a++)
            {
                if (a != num)
                {
                    Console.WriteLine("{0}. ???????????????", a + 1);
                }
                else { prin(i); }
            }
            Console.WriteLine("\n\n");
        }

        private static void prin(List<int> lis)
        {
            for (int a = 0; a < lis.Count; a++)
            {
                StringBuilder str = new StringBuilder();
                str.Append((a + 1).ToString() + ". ");
                if (lis[a] % 10 == 7)
                {
                    str.Append("Alfiere");
                }
                else if (lis[a] % 10 == 8)
                {
                    str.Append("Cavallo");
                }
                else if (lis[a] % 10 == 9)
                {
                    str.Append("Re");
                }
                else
                {
                    str.Append((lis[a] % 10) + 1);
                }

                str.Append(" di ");
                if ((int)lis[a] / 10 == 0)
                {
                    str.Append("Denari ");
                }
                if ((int)lis[a] / 10 == 1)
                {
                    str.Append("Bastoni ");
                }
                if ((int)lis[a] / 10 == 2)
                {
                    str.Append("Spade ");
                }
                if ((int)lis[a] / 10 == 3)
                {
                    str.Append("Coppe ");
                }
                str.Append("(" + ((lis[a] % 10) + 1) + ").");
                Console.WriteLine(str);
            }
        }

        public static void scop1()
        {
            List<int> deck = new List<int>();
            for (int a = 0; a < 40; a++)
            {
                deck.Add(a);
            }
            List<int> val = new List<int>();
            for (int a = 0; a < 4; a++)
            {
                val.Add(1);
                val.Add(2);
                val.Add(3);
                val.Add(4);
                val.Add(5);
                val.Add(6);
                val.Add(7);
                val.Add(8);
                val.Add(9);
                val.Add(10);
            }
            List<int> vall = new List<int>();
            int scopa1 = 0, scopa2 = 0;
            for (int a = 0; a < 40; a++)
            {
                vall.Add(val[a]);
            }
            Random rnd = new Random();
            List<int> user = new List<int>();
            List<int> comp = new List<int>();
            List<int> deckuser = new List<int>();
            List<int> deckcomp = new List<int>();
            List<int> valuser = new List<int>();
            List<int> table = new List<int>();
            List<int> valtable = new List<int>();
            List<int> valcomp = new List<int>();
            for (int a = 0; a < 3; a++)
            {
                int l = rnd.Next(deck.Count);
                int k = deck[l];
                user.Add(k);
                valuser.Add(val[k]);
                deck.RemoveAt(l);
            }
            for (int a = 0; a < 3; a++)
            {
                int l = rnd.Next(deck.Count);
                int k = deck[l];
                comp.Add(k);
                valcomp.Add(val[k]);
                deck.RemoveAt(l);
            }
            for (int a = 0; a < 4; a++)
            {
                int l = rnd.Next(deck.Count);
                int k = deck[l];
                table.Add(k);
                valtable.Add(val[k]);
                deck.RemoveAt(l);
            }

            while (deck.Count > 0)
            {
                if (user.Count == 0 && comp.Count == 0)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        int l = rnd.Next(deck.Count);
                        int k = deck[l];
                        user.Add(k);
                        valuser.Add(val[k]);
                        deck.RemoveAt(l);
                    }
                    for (int a = 0; a < 3; a++)
                    {
                        int l = rnd.Next(deck.Count);
                        int k = deck[l];
                        comp.Add(k);
                        valcomp.Add(val[k]);
                        deck.RemoveAt(l);
                    }
                }

                prinAll(user, comp, valuser, valcomp, table, -1);
                int num = 0;
                while (true)
                {
                    try
                    {
                        Console.Write("Scegli la carta [1 : {0}]: ", user.Count);
                        num = int.Parse(Console.ReadLine());
                        if (num > 0 && num < user.Count + 1)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                num--;
                List<int> old = new List<int>(table);

                table = check(user[num], val[user[num]], table, valtable);
                valtable.Clear();
                for (int a = 0; a < table.Count; a++)
                {
                    valtable.Add(val[table[a]]);
                }
                if (old.Count > table.Count)
                {
                    for (int a = 0; a < table.Count; a++)
                    {
                        if (old.Contains(table[a]))
                        {
                            old.Remove(table[a]);
                        }
                    }
                }
                for (int a = 0; a < old.Count; a++)
                {
                    deckuser.Add(old[a]);
                }
                old.Clear();
                if (table.Count == 0) { scopa1++; }
                Console.Clear();
                user.RemoveAt(num);
                prinAll(user, comp, valuser, valcomp, table, -1);
                Console.Write("INVIO per continuare. ");
                Console.ReadLine();
                List<int> cache1 = new List<int>();
                List<int> cache2 = new List<int>();
                List<int> cache3 = new List<int>();
                cache1.Clear();
                cache2.Clear();
                cache3.Clear();
                try { cache1 = check(comp[0], val[comp[0]], table, valtable); } catch (Exception) { }
                try { cache2 = check(comp[1], val[comp[1]], table, valtable); } catch (Exception) { }
                try { cache3 = check(comp[2], val[comp[2]], table, valtable); } catch (Exception) { }
                int num1a;
                if (cache3.Count <= cache2.Count && cache3.Count <= cache1.Count)
                {
                    num1a = 2;
                }
                else if (cache2.Count <= cache1.Count && cache2.Count <= cache3.Count)
                {
                    num1a = 1;
                }
                else { num1a = 0; }
                try { int k = comp[num1a]; } catch (Exception) { num1a--; }
                try { int k = comp[num1a]; } catch (Exception) { num1a--; }

                prinAll(user, comp, valuser, valcomp, table, num1a);
                List<int> old1 = new List<int>(table);
                Console.WriteLine(num1a.ToString());
                Console.WriteLine(comp.Count.ToString());
                Console.WriteLine(comp[num1a].ToString());
                Console.WriteLine(" " + val[comp[num1a]]);
                Console.Write("INVIO per continuare. " + num1a.ToString());
                Console.ReadLine();
                bool oo = true;
                if (oo)
                {
                    table = check(comp[num1a], val[comp[num1a]], table, valtable); oo = false;
                }
                comp.RemoveAt(num1a);
                valtable.Clear();
                for (int a = 0; a < table.Count; a++)
                {
                    valtable.Add(val[table[a]]);
                }
                if (old1.Count > table.Count)
                {
                    for (int a = 0; a < table.Count; a++)
                    {
                        if (old1.Contains(table[a]))
                        {
                            old1.Remove(table[a]);
                        }
                    }
                }
                for (int a = 0; a < old1.Count; a++)
                {
                    deckcomp.Add(old1[a]);
                }
                old1.Clear();
                if (table.Count == 0) { scopa2++; }
                table = table.Distinct().ToList();
                prinAll(user, comp, valuser, valcomp, table, -1);
                Console.Write("INVIO per continuare. ");
                Console.ReadLine();
                Console.Clear();
            }
            if (deckuser.Count < deckcomp.Count) { Console.WriteLine("Il computer ha più carte."); }
            else if (deckuser.Count > deckcomp.Count) { Console.WriteLine("Il giocatore ha più carte."); }
            else { Console.WriteLine("I giocatore hanno lo stesso numero di carte."); }
            if (deckuser.Contains(6)) { Console.WriteLine("Il giocatore fa settebello."); }
            else { Console.WriteLine("Il computer fa settebello."); }
            Console.WriteLine("Scope giocatore: {0}" + scopa1);
            Console.WriteLine("Scope computer: {0}" + scopa2);
            int nu1 = 0, nu2 = 0;
            for (int a = 0; a < 10; a++)
            {
                if (deckuser.Contains(a)) { nu1++; } else { nu2++; }
            }
            if (nu1 < nu2) { Console.WriteLine("Il computer ha più carte denari."); }
            else if (nu1 > nu2) { Console.WriteLine("Il giocatore ha più carte denari."); }
            else { Console.WriteLine("I giocatore hanno lo stesso numero di carte denari."); }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void scop()
        {
            while (true) { Console.Clear(); scop1(); }
        }
    }
}