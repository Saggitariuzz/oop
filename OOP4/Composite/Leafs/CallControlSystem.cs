using System;
using System.Windows.Forms;

namespace OOP4.Composite.Leafs
{
    public class CallControlSystem: IATSComponent
    {
        public bool IsActive { get; set; }
        
        public int OperatorID { get; set; }

        public CallControlSystem() 
        { 
            Random rnd = new Random();
            IsActive = rnd.Next(2) == 1;
            OperatorID = rnd.Next(1, 10000);
        }

        public void Display(TreeNodeCollection treeNodeCollection)
        {
            TreeNode node = new TreeNode("Система контроля звонков");
            node.Tag = this;
            treeNodeCollection.Add(node);
        }

        public override string ToString()
        {
            return "Система контроля звонков" + Environment.NewLine +
                $"Система в данный момент: {(IsActive ? "Активна" : "Не активна")}" + Environment.NewLine +
                $"Идентификатор ответственного оператора: {OperatorID}";
        }
    }
}
