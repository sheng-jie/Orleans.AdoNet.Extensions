using System;
using System.Threading.Tasks;
using Orleans.Runtime;

namespace Orleans.AdoNet.SqlServer.Test.Grains
{
    public class InventoryGrain : Grain<InventoryState>, IInventoryGrain, IRemindable
    {
        public override Task OnActivateAsync()
        {
            this.State.SkuId = this.GetPrimaryKeyString();
            this.RegisterOrUpdateReminder("inventory update", TimeSpan.FromSeconds(1), TimeSpan.FromMinutes(1.1));
            return base.OnActivateAsync();
        }



        public async Task Set(int qty)
        {
            this.State.Qty = qty;
            await this.WriteStateAsync();
        }

        public async Task Add(int qty)
        {
            this.State.Qty += qty;
            await this.WriteStateAsync();
        }

        public async Task<bool> Decrease(int qty)
        {
            var isEnough = this.State.Qty >= qty;

            if (isEnough)
            {
                this.State.Qty -= qty; await this.WriteStateAsync();
            }

            return isEnough;
        }

        public Task<int> GetInventory()
        {
            return Task.FromResult(this.State.Qty);
        }

        public async Task ReceiveReminder(string reminderName, TickStatus status)
        {
            this.State.Qty -= 1;
            await this.WriteStateAsync();
        }
    }
}