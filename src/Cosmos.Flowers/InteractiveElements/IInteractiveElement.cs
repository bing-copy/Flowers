using Cosmos.Abstractions.Workflow;

namespace Cosmos.Flowers.InteractiveElements {
    public interface IInteractiveElement : IDynamicElement {
        IDynamicElementDesign Design { get; }
        string Title { get; }
    }
}