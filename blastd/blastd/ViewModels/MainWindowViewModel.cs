using System.Collections.Generic;

namespace blastd.ViewModels
{
    public sealed class MainWindowViewModel : ViewModelBase
    {
        public string[] ListData { get; set; }
        private const string TAG = "MainWindowViewModel";

        public MainWindowViewModel()
        {
        }

        public override async void Initialize()
        {
            Requester r = new Requester();
            List<string> s = await r.GetValues();
            ListData = s.ToArray();
            OnPropertyChanged(nameof(ListData));
        }
    }
}