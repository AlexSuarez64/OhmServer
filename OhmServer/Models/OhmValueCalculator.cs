using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OhmServer.Models
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public double CalculateOhmValue(
            string A, 
            string B, 
            string C, 
            string D,
            List<ResistorTable> rt)
        {
            ResistorTable first = rt.Find(r => r.RingName == A);
            ResistorTable second = rt.Find(r => r.RingName == B);
            ResistorTable multiplier = rt.Find(r => r.RingName == C);
            ResistorTable percent = rt.Find(r => r.RingName == D);

            string x = first.SignificantFigures + second.SignificantFigures;
            double y = multiplier.Multiplier;
            int z = 0;
            if (Int32.TryParse(x, out z))
            {
                return z * y;
            }
            return 0;
        }

        public List<ResistorTable> CreateTable()
        {
            List<ResistorTable> rt = new List<ResistorTable>()
            {
                new ResistorTable
                {   RingName = "None",
                    RingCode = "",
                    RingRAL = "",
                    SignificantFigures = "",
                    Multiplier = 0,
                    Percent = 0
                },
                new ResistorTable
                {
                    RingName = "Pink",
                    RingCode = "PK",
                    RingRAL = "3015",
                    SignificantFigures = "",
                    Multiplier = 0.001,
                    Percent = 0
                },
                new ResistorTable
                {
                    RingName = "Silver",
                    RingCode = "SR",
                    RingRAL = "",
                    SignificantFigures = "",
                    Multiplier = 0.01,
                    Percent = 0.1
                },
                new ResistorTable
                {
                    RingName = "Gold",
                    RingCode = "GD",
                    RingRAL = "",
                    SignificantFigures = "",
                    Multiplier = 0.1,
                    Percent = 0.05
                },
                new ResistorTable
                {
                    RingName = "Black",
                    RingCode = "BK",
                    RingRAL = "9005",
                    SignificantFigures = "0",
                    Multiplier = 1,
                    Percent = 0.0
                },
                new ResistorTable
                {
                    RingName = "Brown",
                    RingCode = "BN",
                    RingRAL = "8003",
                    SignificantFigures = "1",
                    Multiplier = 10,
                    Percent = 0.01
                },
                new ResistorTable
                {
                    RingName = "Red",
                    RingCode = "RD",
                    RingRAL = "3000",
                    SignificantFigures = "2",
                    Multiplier = 100,
                    Percent = 0.02
                },
                new ResistorTable
                {
                    RingName = "Orange",
                    RingCode = "OG",
                    RingRAL = "2003",
                    SignificantFigures = "3",
                    Multiplier = 1000,
                    Percent = 0.0
                },
                new ResistorTable
                {
                    RingName = "Yellow",
                    RingCode = "YE",
                    RingRAL = "1021",
                    SignificantFigures = "4",
                    Multiplier = 10000,
                    Percent = 0.05
                },
                new ResistorTable
                {
                    RingName = "Green",
                    RingCode = "GN",
                    RingRAL = "6018",
                    SignificantFigures = "5",
                    Multiplier = 100000,
                    Percent = 0.005
                },
                new ResistorTable
                {
                    RingName = "Blue",
                    RingCode = "BU",
                    RingRAL = "5015",
                    SignificantFigures = "6",
                    Multiplier = 1000000,
                    Percent = 0.0025
                },
                new ResistorTable
                {
                    RingName = "Violet",
                    RingCode = "VT",
                    RingRAL = "4005",
                    SignificantFigures = "7",
                    Multiplier = 10000000,
                    Percent = 0.001
                },
                new ResistorTable
                {
                    RingName = "Gray",
                    RingCode = "GY",
                    RingRAL = "7000",
                    SignificantFigures = "8",
                    Multiplier = 100000000,
                    Percent = 0.1
                },
                new ResistorTable
                {
                    RingName = "White",
                    RingCode = "WH",
                    RingRAL = "1013",
                    SignificantFigures = "9",
                    Multiplier = 1000000000,
                    Percent = 0.0
                }
            };
            return rt;
        }
    }
}

