using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_App.Model;

[INotifyPropertyChanged]
public partial class Order
{
    [ObservableProperty]
    private DateTime stateDateTime;

    [ObservableProperty]
    private double tip;

    public string Total
    {
        get
        {
            var tot = Currentitems.Sum(i => i.SubTotal);

            if (Tip != 0)
                tot = tot + (tot * Tip);

            return tot.ToString();
        }
    }

    [ObservableProperty]
    public List<Food> currentitems;

    [ObservableProperty]
    private string status;

}
