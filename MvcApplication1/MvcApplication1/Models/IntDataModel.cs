using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class IntDataModel
    {
        private List<int> _list;

        public IntDataModel()
        {
            _list = new List<int>();
        }

        public List<int> IntList
        {
            get
            {
                return _list;
            }
        }

        public void Add(int item)
        {
            _list.Add(item);
        }
    }
}