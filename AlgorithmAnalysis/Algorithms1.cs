﻿using System.Collections.Generic;

namespace AlgorithmAnalysis
{
    public static class Algorithms1
    {
        /* Problem: Create a function that returns whether or not a given growth rate table is valid
         * A table is valid if:
         *      It spans all weeks 1 through 53.
         *      Each row can have multiple weeks. 
         *      All rows cover a time period moving forward
         *      No overlapping weeks appear in the table. 
         *      The sum of all growth percentages in the table is equal to 1
         *  Example Valid Table:
         *      Row Index   StartWeek   EndWeek     GrowthPct
         *      1           1           4           .1
         *      2           8           10          .17
         *      3           5           7           .05
         *      4           11          53          .68
         *  Other notes:
         *      The table does not have a guaranteed order
         *      You may use any .NET functions available to you or build additional structures if necessary
         *      The order of priorities for the solution should be: Correctness, Elegance/Style, and Performance.
        */
        public static bool IsValid(GrowthTable t)
        {            
            return true;
        }
    }

    public class GrowthTable
    {
        public GrowthTable() { }
        public List<GrowthTableRow> Rows {get; set;}

        public GrowthTable (List<GrowthTableRow> rows)
        {
            Rows = rows;
        }
    }

    public class GrowthTableRow
    {
        public GrowthTableRow() { }
        public int StartWeek { get; set; }
        public int EndWeek { get; set; }
        public decimal GrowthPct { get; set; }

        public GrowthTableRow (int start, int end, decimal growth)
        {
            StartWeek = start;
            EndWeek = end;
            GrowthPct = growth;
        }
    }
}
