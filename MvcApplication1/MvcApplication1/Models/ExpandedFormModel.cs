using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ExpandedFormModel
    {
        private List<int> _digits = new List<int>();

        public ExpandedFormModel()
        {
            System.Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                _digits.Add(random.Next(101, 9999));
            }
        }

        public List<int> Digits
        {
            get
            {
                return _digits;
            }
        }

        public int UnderlinePlace
        {
            get
            {
                Random random = new Random();
                return random.Next(4);
            }
        }
    }
}