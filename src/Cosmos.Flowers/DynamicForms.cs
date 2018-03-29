using System;
using Cosmos.Abstractions.Workflow;

namespace Cosmos.Flowers {
    public class DynamicForms : IDynamicForms {
        private readonly IDynamicFormsDesign _design;

        public DynamicForms(IDynamicFormsDesign design) {
            _design = design ?? throw new ArgumentNullException(nameof(design));
        }

        public IDynamicFormsDesign Design => _design;

        public string Title => Design.DisplayTitle;
    }
}