using System.Collections.Generic;
using Cosmos.Abstractions.Workflow;

namespace Cosmos.Flowers {
    public class DynamicFormsDesign : IDynamicFormsDesign {
        private readonly IList<IDynamicElementDesign> _elements;

        public DynamicFormsDesign() {
            _elements = new List<IDynamicElementDesign>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayTitle { get; set; }
        public IList<IDynamicElementDesign> Elements => _elements;
    }
}