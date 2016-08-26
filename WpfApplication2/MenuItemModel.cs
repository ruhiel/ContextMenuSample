using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
	public class MenuItemModel
	{
		public string DisplayName { get; set; }
		public DelegateCommand Command { get; set; }
	}
}
