using COVID19.Models;
using COVID19.services;
using MvvmHelpers;
using MvvmHelpers.commands;


namespace COVID19.ViewModels
{
    internal class Covid19ListViewModel
    {
        public ICovidDataStore<Covid> DataStore => DependencyService.Get<ICovidDataStore<Covid>>();
        public ObservableRangeCollection<Covid> Covid { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public Covid19ListViewModel()
        {
            Covid = new ObservableRangeCollection<Covid>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var employees = await DataStore.GetCovidAsync(20);

            Covid.AddRange(Covid);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }

    internal class ObservableRangeCollection<T>
    {
        public ObservableRangeCollection()
        {
        }

        internal void AddRange(object covid)
        {
            throw new NotImplementedException();
        }
    }
}

