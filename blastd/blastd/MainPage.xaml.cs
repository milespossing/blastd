using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blastd.ViewModels;
using blastd.Views;
using Xamarin.Forms;

namespace blastd
{
    public partial class MainPage : MyContentPage<MainWindowViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
