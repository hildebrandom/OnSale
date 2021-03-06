﻿using OnSale.Common.Entities;
using OnSale.Common.Responses;
using OnSale.Prism.Helpers;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OnSale.Prism.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase
    {
        public ProductResponse _product;
        private ObservableCollection<ProductImage> _images;



        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.Details;
        }

        public ObservableCollection<ProductImage> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }


        public ProductResponse Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("product"))
            {
                Product = parameters.GetValue<ProductResponse>("product");
                Title = Languages.Details;
                Images = new ObservableCollection<ProductImage>(Product.ProductImages);

            }
        }

    }
}
