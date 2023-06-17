﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LusoDataApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BemVindo : ContentPage
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private  async void ToEcradeRegistro(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EcradeRegistro());
        }
    }
}