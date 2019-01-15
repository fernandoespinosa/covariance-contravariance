
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public interface IBasicTree
    {
        IBasicTreeNode Root { get; }
    }

    public interface IBasicTreeNode
    {
        IEnumerable<IBasicTreeNode> Children { get; }
        IBasicTreeNode Parent { get; }
    }

    class BasicTreeNode : IBasicTreeNode
    {
        public IEnumerable<IBasicTreeNode> Children { get; } = new List<BasicTreeNode>();
        public IBasicTreeNode Parent { get; }
    }
}