﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenelUi.Ui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageButton : ContentPage
    {
        public ImageButton()
        {
            InitializeComponent();
        }
        private void ImageButtonTospik_OnClicked(object sender, EventArgs e)
        {
            image_button_label.IsVisible = true;
        }
    }
}