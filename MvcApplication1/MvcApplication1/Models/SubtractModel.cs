using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SubtractModel
    {
        private List<Equation> _equations = new List<Equation>();

        public SubtractModel()
        {
            System.Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                Equation e = new Equation();
                e.Lhs = random.Next(65);
                e.Rhs = random.Next(35);
                if (e.Lhs > e.Rhs)
                {
                    _equations.Add(e);
                }
                else
                {
                    --i;
                }
            }
        }

        public List<Equation> Equations
        {
            get
            {
                return _equations;
            }
        }
    }
}