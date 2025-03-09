using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4.Composite.Composites
{
    public class TelephoneExchange: IATSComponent
    {

        public string ID { get; set; }

        private List<IATSComponent> components = new List<IATSComponent>();

        public TelephoneExchange()
        {
            ID = Guid.NewGuid().ToString();
        }

        public void Add(IATSComponent component)
        {
            components.Add(component);
        }

        public void Remove(IATSComponent component)
        {
            components.Remove(component);
        }

        public void Display(TreeNodeCollection treeNodeCollection)
        {
            TreeNode nodes = new TreeNode($"АТС: {ID}");
            nodes.Tag = this;
            treeNodeCollection.Add(nodes);
            foreach(IATSComponent component in components)
            {
                component.Display(nodes.Nodes);
            }
            nodes.Expand();
        }

        public override string ToString()
        {
            return "Автоматическая телефонная станция" + Environment.NewLine +
                $"Идентификатор: {ID}" + Environment.NewLine +
                $"Зарегистрированных компонентов: {components.Count}";
        }
    }
}
