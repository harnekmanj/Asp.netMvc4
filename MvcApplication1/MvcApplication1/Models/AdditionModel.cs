using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AdditionModel
    {
        private List<Equation> _equations = new List<Equation>();

        public AdditionModel()
        {
            System.Random random = new Random();
            for (int i = 0; i <= 15; i++)
            {
                Equation e = new Equation();
                e.Lhs = random.Next(100, 999);
                e.Rhs = random.Next(100, 999);
                _equations.Add(e);
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