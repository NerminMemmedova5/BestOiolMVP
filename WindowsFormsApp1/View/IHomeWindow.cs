using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.View
{
    public interface IHomeWindow
    {
        EventHandler<EventArgs> WindowLoad { get; set; }
        EventHandler<EventArgs> PetrolChangeClicked { get; set; }
        EventHandler<EventArgs> QuantityChangedClicked { get; set; }
        EventHandler<EventArgs> MoneyChangingClicked { get; set; }
        EventHandler<EventArgs> CheckClicked { get; set; }
        List<Petrol>Petrols { set; }
        List<Check> Checks {set; }
        string PriceText { get; set; }
        string QuantityText { get; set; }
        string MoneyText { get; set; }
        string SumPriceText { get; set; }

        bool SetEnablePrice { get; set; }
        bool SetEnableLiter { get; set; }


    }
}
