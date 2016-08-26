using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
	public class ViewModel
	{
		public List<MenuItemModel> SomeCollection { get; set; }
		public ViewModel()
		{
			SomeCollection = new List<MenuItemModel>()
			{
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "長門" },
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "陸奥" },
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "金剛" },
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "比叡" },
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "榛名" },
				new MenuItemModel() {Command = new DelegateCommand(), DisplayName = "霧島" },
			};
		}
	}
}
