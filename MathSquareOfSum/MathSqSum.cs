using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace MathSquareOfSum
{
    [Category("Category.Where.Your.Activity.Appears.In.Toolbox")]
    [DisplayName("Human readable name instead of class name")]
    [Description("The text of the tooltip")]
    public class MathSqSum : CodeActivity
    {
        //Note that these attributes are localized so you need to localize this attribute for Studio languages other than English
        [Category("Input")]
        [DisplayName("First Number")]
        [Description("Enter the first number")]
        [RequiredArgument]
        public InArgument<int> FirstNumber { get; set; }
        [Category("Input")]
        [DisplayName("Second Number")]
        [Description("Enter the second number")]
        [RequiredArgument]
        public InArgument<int> SecondNumber { get; set; }
        [Category("Output")]
        public OutArgument<int> ResultNumber { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);

            var result = (int)Math.Pow(firstNumber + secondNumber, 2);
            ResultNumber.Set(context, result);
        }
    }
}
