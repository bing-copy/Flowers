namespace Cosmos.Flowers.Filters {
    public interface IFilterCommand {
        string DisplayKey { get; }
        string DisplayDescription { get; }
    }
}