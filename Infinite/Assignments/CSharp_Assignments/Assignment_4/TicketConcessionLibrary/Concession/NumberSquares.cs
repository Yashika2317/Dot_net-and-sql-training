using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberSquares
{
    public List<int> GetSquaresGreaterThan20(List<int> numbers)
    {
        return numbers
            .Where(n => n * n > 20)
            .Select(n => n * n)
            .ToList();
    }
}

