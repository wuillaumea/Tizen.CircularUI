﻿using System;
using Xamarin.Forms;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms.Xaml;
using UIComponents.Extensions;

namespace UIComponents.Samples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CircleScrollerList : CirclePage
    {
        public CircleScrollerList()
        {
            InitializeComponent();
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            if (args.Item == null) return;

            var desc = args.Item as Sample;
            Console.WriteLine($"OnItemTapped desc.Class:{desc.Class}");
            if (desc != null && desc.Class != null)
            {
                Type pageType = desc.Class;

                var page = Activator.CreateInstance(pageType) as Page;
                NavigationPage.SetHasNavigationBar(page, false);
                Navigation.PushAsync(page as Page);
            }
        }
    }
}
