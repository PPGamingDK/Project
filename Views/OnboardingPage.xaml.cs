﻿namespace UIMock;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
		BindingContext = new OnboardingPageViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Retrieve the saved selected tab index from the preferences
        if (Preferences.ContainsKey("SelectedTabIndex"))
        {
            int selectedIndex = Preferences.Get("SelectedTabIndex", 0);

            // Set the selected tab index of the TabHostView
            TabHost.SelectedIndex = selectedIndex;
        }
    }
}
