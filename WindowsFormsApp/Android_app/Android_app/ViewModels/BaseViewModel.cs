using Android_app.Helpers;
using Android_app.Models;
using Android_app.Services;

using Xamarin.Forms;

namespace Android_app.ViewModels
{
	public class BaseViewModel
	{
		/// <summary>
		/// Get the azure service instance
		/// </summary>
		

		bool isBusy = false;
		public bool IsBusy
		{
			get { return isBusy; }
			
		}
		/// <summary>
		/// Private backing field to hold the title
		/// </summary>
		string title = string.Empty;
		/// <summary>
		/// Public property to set and get the title of the item
		/// </summary>
		public string Title
		{
			get { return title; }
			
		}
	}
}

