using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class GenerateMathEquation : Interface.IGenerateMathEquation
    {
        public SubtractModel GetSubtractEquations()
        {
            SubtractModel subtractModel = new SubtractModel();
            List<Equation> _equations = new List<Equation>();
            System.Random random = new Random();
            for (int i = 0; i <= 20; i++)
            {
                Equation e = new Equation();
                e.Lhs = random.Next(47, 111);
                e.Rhs = random.Next(21, 45);
                if (e.Lhs > e.Rhs)
                {
                    _equations.Add(e);
                }
                else
                {
                    --i;
                }
            }

            subtractModel.Equations = _equations;
            return subtractModel;
        }
    }
}