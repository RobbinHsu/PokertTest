using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PokerTest
{
    public static class Helper
    {
        //隨時可以抽換實作
        public static void MySort(this List<int> source)
        {
            source.Sort();
        }
    }
}