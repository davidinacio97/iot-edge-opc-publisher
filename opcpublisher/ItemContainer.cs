using System.Collections.Generic;

namespace OpcPublisher
{
    public class ItemContainer
    {
        public string NodeId { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public IList<ItemContainer> Children { get; set; }

        public override string ToString() => $"{nameof(NodeId)}: {NodeId}, {nameof(DisplayName)}: {DisplayName}, {nameof(Description)}: {Description}";
    }
}