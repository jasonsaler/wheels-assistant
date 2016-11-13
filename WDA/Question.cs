using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WheelsDataAssistant
{
    interface Question<T>
    {
        bool Equals(T obj);
    }
}
