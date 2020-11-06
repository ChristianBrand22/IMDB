//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleClassification.Model
{
    public class ModelInput
    {
        [ColumnName("review"), LoadColumn(0)]
        public string Review { get; set; }


        [ColumnName("sentiment"), LoadColumn(1)]
        public string Sentiment { get; set; }


    }
}
