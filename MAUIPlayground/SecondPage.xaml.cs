using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPlayground;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
        LazyView.ParentPage = this;
    }
}