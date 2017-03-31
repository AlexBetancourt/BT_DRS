using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Mobile_DRS.Helpers;
using Mobile_DRS.Models;
using Mobile_DRS.Views;

using Xamarin.Forms;

namespace Mobile_DRS.ViewModels
{
	public class ItemsViewModel : BaseViewModel
	{
		public ObservableRangeCollection<Item> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		public ItemsViewModel()
		{
			Title = "Browse";
			Items = new ObservableRangeCollection<Item>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

			MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
			{
				var _item = item as Item;
				Items.Add(_item);
				await DataStore.AddItemAsync(_item);
			});
		}

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				Items.ReplaceRange(items);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				MessagingCenter.Send(new MessagingCenterAlert
				{
					Title = "Error",
					Message = "Unable to load items.",
					Cancel = "OK"
				}, "message");
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}