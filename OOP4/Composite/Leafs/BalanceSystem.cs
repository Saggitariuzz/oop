using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4.Composite.Leafs
{
    public class BalanceSystem: IATSComponent
    {
        public int CurrentLoad { get; set; }

        public int MaxLoad { get; set; }

        public BalanceSystem()
        {
            Random rnd = new Random();
            CurrentLoad = rnd.Next(1, 100000);
            MaxLoad = rnd.Next(1, 1000000);
        }

        public void Display(TreeNodeCollection treeNodeCollection)
        {
            TreeNode node = new TreeNode("Система распределения нагрузки");
            node.Tag = this;
            treeNodeCollection.Add(node);
        }

        public override string ToString()
        {
            return "Система распределения нагрузки" + Environment.NewLine +
                $"Текущая загруженность: {CurrentLoad} клиентов" + Environment.NewLine +
                $"Предельная загруженность: {MaxLoad} клиентов" + Environment.NewLine +
                $"{(CurrentLoad >= MaxLoad ?"!!!ПЕРЕГРУЗКА!!!":"")}";
        }
    }
}
