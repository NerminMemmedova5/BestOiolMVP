using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenters
{
    public class HomePresenter
    {
        private readonly PetrolContext _db;
        private IHomeWindow _view;

        public HomePresenter(IHomeWindow view)
        {
            _view= view;
            _db= new PetrolContext();
            
            var count= _db.Petrols.Count();
            if (count == 0)
            {
                _db.Petrols.AddRange(new List<Petrol>
                {
                    new Petrol
                    {
                        Name="A-92",
                        Price=1,
                    },
                    new Petrol
                    {
                        Name="A-95",
                        Price=2,
                    },
                    new Petrol
                    {
                        Name="A-98",
                        Price=2.30,
                    },
                    new Petrol
                    {
                        Name="Dizel",
                        Price=0.80,
                    }
                });
                _db.SaveChanges();


            }
                _view.PetrolChangeClicked += PetrolChangeClicked;
                _view.QuantityChangedClicked += QuantityChangeClicked;
                _view.MoneyChangingClicked += MoneyChangeClicked;
                _view.CheckClicked += CheckClicked;

                _view.WindowLoad += WindowLoad;
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            _view.Petrols = _db.Petrols.ToList();
        }

        private void CheckClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MoneyChangeClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void QuantityChangeClicked(object sender, EventArgs e)
        {
            _view.SetEnablePrice = !_view.SetEnablePrice;
        }

        private void PetrolChangeClicked(object sender, EventArgs e)
        {
            var selecteditem=(sender as ComboBox).SelectedItem as Petrol;
            _view.PriceText = selecteditem.Price.ToString();
        }
    }
}
