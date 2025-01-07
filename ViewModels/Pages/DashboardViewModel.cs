namespace Start_WPF.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? text = string.Empty;

        [ObservableProperty] // 어트리뷰트(Java 의 어노테이션과 비슷)
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            //++Counter;
            this.Text = "Clicked!!";
        }
    }
}
