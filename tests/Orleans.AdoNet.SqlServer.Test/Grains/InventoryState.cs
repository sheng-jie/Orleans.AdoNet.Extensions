namespace Orleans.AdoNet.SqlServer.Test.Grains
{
    public class InventoryState
    {
        public string SkuId { get; set; }
        public int Qty { get; set; }
    }
}