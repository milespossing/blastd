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

        public override void Initialize()
        {
            Requester r = new Requester();
            List<string> s = r.GetValues().Result;
            ListData = new []{"Test 1","Test 2"};
            OnPropertyChanged(nameof(ListData));
        }
    }
}