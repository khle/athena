﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Athena.ImagePicker.Pcl.Views
{	
	public partial class TestView : ContentPageBase
	{	
		public TestView ()
		{
			InitializeComponent ();

			ViewModel.View = this;
		}
	}
}

