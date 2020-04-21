namespace Nest
{
	[MapsApi("reindex_rethrottle.json")]
	public partial interface IReindexRethrottleRequest { }

	public partial class ReindexRethrottleRequest : IReindexRethrottleRequest { }

	public partial class ReindexRethrottleDescriptor : IReindexRethrottleRequest { }
}
