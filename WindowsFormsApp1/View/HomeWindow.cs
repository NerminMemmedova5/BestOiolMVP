using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.View
{
    public partial class HomeWindow : Form,IHomeWindow
    {
        public HomeWindow()
        {
            InitializeComponent();
            petrolCombob.DisplayMember=nameof(Petrol.Name);

        }

        public EventHandler<EventArgs> PetrolChangeClicked { get ; set ; }
        public EventHandler<EventArgs> QuantityChangedClicked { get; set; }
        public EventHandler<EventArgs> MoneyChangingClicked { get; set ; }
        public EventHandler<EventArgs> CheckClicked { get ; set ; }
        public List<Petrol> Petrols { set
            {
                petrolCombob.DataSource = null;
                petrolCombob.DataSource = value;
                
            } }
        public List<Check> Checks { set { 
                chechListB.DataSource = null;
                chechListB.DataSource = value;
            } }
        public string PriceText { get => priceTxtb.Text; set => priceTxtb.Text=value; }
        public string QuantityText { get => quantityTxtb.Text; set => quantityTxtb.Text=value; }
        public string MoneyText { get => moneyTxtb.Text; set=> moneyTxtb.Text=value; }
        public string SumPriceText { get => sumpriceTxtb.Text; set => sumpriceTxtb.Text=value; }
        public EventHandler<EventArgs> WindowLoad { get ; set ; }
        public bool SetEnablePrice { get => quantityTxtb.Enabled; set => quantityTxtb.Enabled = value; }
        public bool SetEnableLiter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void petrolCombob_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetrolChangeClicked.Invoke(sender, e);
        }

        private void quantityTxtb_TextChanged(object sender, EventArgs e)
        {
           // QuantityChangedClicked.Invoke(sender, e);
        }

        private void moneyTxtb_TextChanged(object sender, EventArgs e)
        {
           // MoneyChangingClicked.Invoke(sender, e);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            CheckClicked.Invoke(sender, e);
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            WindowLoad.Invoke(sender, e);
        }

        private void quantityRadioB_CheckedChanged(object sender, EventArgs e)
        {
            QuantityChangedClicked.Invoke(sender, e);
        }

        private void moneyRadiob_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
