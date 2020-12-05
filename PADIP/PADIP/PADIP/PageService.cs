﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PADIP
{
    class PageService : IPageService
    {
        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
          return await  Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }
    }
}
