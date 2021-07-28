using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using XamApps.Models;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamApps.ViewModels
{
    public class ExpanderViewModel : INotifyPropertyChanged
    {

		public ICommand Command { get; }

		public Item[] Items { get; } = new Item[]
		{
			new Item
			{
				Name = "=> #1 <=",
				IsExpanded = true

			},
			new Item
			{
				Name = "=> #2 <=",
				IsExpanded = true
			},
			new Item
			{
				Name = "=> #3 <=",
				IsExpanded = true

			},
			new Item
			{
				Name = "=> #4 <=",
			},
			new Item
			{
				Name = "=> #5 <="
			},
		};

		public ExpanderViewModel()
        {
			//Command = CommandFactory.Create<Item>(sender =>
			//{
			//	if (!sender.IsExpanded)
			//		return;

			//	foreach (var item in Items)
			//		item.IsExpanded = sender == item;
			//});
		}


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
