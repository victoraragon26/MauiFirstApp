﻿using MauiFirstApp.ViewModel;

namespace MauiFirstApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

