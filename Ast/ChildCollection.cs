using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ast
{
    public class ChildCollection : ObservableCollection<AstElement>
    {
        private AstElement _parent;

        public ChildCollection(AstElement parent)
        {
            _parent = parent;
        }

        protected override void InsertItem(int index, AstElement item)
        {
            item.Parent = _parent;
            base.InsertItem(index, item);
        }
    }
}
