using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//practice how to inherit system classes //extending List<string> with additional functionality

namespace CustomStack;

public class StackOfStrings : Stack<string>
{
    public bool IsEmpty()
    {
        return Count == 0;
    }
    public void AddRange(IEnumerable<string> items)
    {
        foreach (var item in items)
        {
            Push(item);
        }
    }


}
