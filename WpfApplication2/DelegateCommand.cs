using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApplication2
{
	public class DelegateCommand : ICommand
	{
		public bool CanExecute(object parameter)
		{
			return true;
		}
		public event EventHandler CanExecuteChanged;
		public void Execute(object parameter)
		{
			MessageBox.Show(string.Format("コマンドが実行されました: {0}", parameter.ToString()));
		}
	}
}