using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class MathAPIController : ApiController
    {
        public IEnumerable<int> GetNumbers()
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                numberList.Add(i);
            }

            return numberList;
        }

        public IDictionary<int, List<string>> GetPatterns()
        {
            IDictionary<int, List<string>> dictionaryOfPatternList = new Dictionary<int, List<string>>();
            List<string> lists = new List<string>();
            List<int> patternNumbers = new List<int>();
            System.Random random = new Random();
            int j = 0;
            while(j < 5)
            {
                int patternNumber = random.Next(3, 12);
                if (!patternNumbers.Contains(patternNumber))
                {
                    patternNumbers.Add(patternNumber);
                    for (int i = 1; i <= 8; i++)
                    {
                        if (i % 4 == 0)
                        {
                            lists.Add("___");
                        }
                        else
                        {
                            lists.Add((patternNumber * i).ToString());
                        }
                    }
                    dictionaryOfPatternList.Add(patternNumber, lists);
                    j++;
                }
                
            }
            return dictionaryOfPatternList;
        }

    }
}