using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4.Composite
{
    public interface IATSComponent
    {
        void Display(TreeNodeCollection treeNodeCollection);
    }
}
