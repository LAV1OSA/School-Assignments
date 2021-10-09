using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dahuyag_JK_CIRCLES_AND_CURVED_SHAPES_Project
{
    class SummaryList //This code is for the summary screen, it lists all iterations made so far
    {
        public int iteration { get; set; }
        public string shapeChoice { get; set; }
        public string nameOfGiven { get; set; }
        public string valueOfGiven { get; set; }
        public string unitOfGiven { get; set; }
        public string nameOfGiven2 { get; set; }
        public string valueOfGiven2 { get; set; }
        public string unitOfGiven2 { get; set; }
        public string required { get; set; }
        public double requiredvalue { get; set; }
        public string requiredunit { get; set; }
        public override string ToString()
        {
            if(valueOfGiven2 == "null")
                return "Computation " + iteration + "\nShape of Choice: "+ shapeChoice + "\nGiven:\n" + nameOfGiven + " = " + valueOfGiven + " " + unitOfGiven +"units\n\nComputed Value:\n" + required + " = " + requiredvalue + requiredunit + " units\n\n************************************************************************************************************************";
            else
                return "Computation " + iteration + "\nShape of Choice: " + shapeChoice + "\nGiven:\n" + nameOfGiven + " = " + valueOfGiven + " " + unitOfGiven + "units\n" + nameOfGiven2 + " = " + valueOfGiven2 + " " + unitOfGiven2 +  " units\n\nComputed Value:\n" + required + " = " + requiredvalue + requiredunit + "units\n\n************************************************************************************************************************";
        }
    }
}
