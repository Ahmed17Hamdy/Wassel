using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WasselApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPanel : ContentPage
	{
		public UserPanel ()
		{
			InitializeComponent ();
		}
	}
}