using System;
using Cosmos.Abstractions.Workflow;

namespace Cosmos.Flowers.InteractiveElements {
    public class InputElement : IInteractiveElement {

        private readonly IDynamicElementDesign _design;

        public InputElement(IDynamicElementDesign design) {
            _design = design ?? throw new ArgumentNullException(nameof(design));
        }

        public IDynamicElementDesign Design => _design;

        public string Id => _design.Id;

        public string Title => _design.DisplayTitle;
    }
}