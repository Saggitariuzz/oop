using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4.Composite.Leafs
{
    public class SwitchingSubsystem: IATSComponent
    {
        public string Type { get;set; }

        public int PortCount { get;set; }

        public SwitchingSubsystem()
        {
            Random rnd = new Random();
            string[] types = { "TDM", "VoIP", "Hybrid" };
            Type = types[rnd.Next(types.Length)];
            PortCount = rnd.Next(16, 65);
        }

        public void Display(TreeNodeCollection treeNodeCollection)
        {
            TreeNode node = new TreeNode("Коммутационная система");
            node.Tag = this;
            treeNodeCollection.Add(node);
        }

        public override string ToString()
        {
            return "Система коммутации" + Environment.NewLine +
                $"Тип системы: {Type}" + Environment.NewLine +
                $"Количество активных портов: {PortCount}";
        }
    }
}
