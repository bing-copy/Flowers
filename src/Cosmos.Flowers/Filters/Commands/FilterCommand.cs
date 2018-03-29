namespace Cosmos.Flowers.Filters.Commands {
    public abstract class FilterCommand : IFilterCommand {
        protected FilterCommand(string key, string description) {
            DisplayKey = key;
            DisplayDescription = description;
        }

        public string DisplayKey { get; }
        public string DisplayDescription { get; }
    }
}