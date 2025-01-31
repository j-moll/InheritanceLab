
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList;

//practice how to inherit system classes //extending List<string> with additional functionality
public class RandomList : List<string>
{
    public string RandomString()
    {

        Random random = new();
        int index = random.Next(Count);
        string element = this[index];
        RemoveAt(index);
        return element;

    }
}
