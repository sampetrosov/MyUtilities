// Copyright (c) 2017 Samvel Petrosov
// Created at 8/14/2017 5:15 PM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    public static class StringUtility
    {
        public static string SplitAndSort(this string str, bool desc = false,char splitChar=' ')
        {
            return desc? str.Split(splitChar).OrderByDescending(x => x).Aggregate((x, y) => x + y) : str.Split(splitChar).OrderBy(x => x).Aggregate((x, y) => x + splitChar + y);
        }
    }
}
