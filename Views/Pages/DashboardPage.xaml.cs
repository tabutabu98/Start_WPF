using System.ComponentModel;
using System.Windows.Media;
using Start_WPF.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace Start_WPF.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            // ViewModel 의 속성 변경 이벤트 함수 호출
            ViewModel.PropertyChanged += ViewModel_PropertyChanged; // 속성 변경 이벤트

            InitializeComponent();
        }

        /// <summary>
        /// DashboardViewModel 속성 변경 시 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Text":
                    this.clickmeBtn.Background = new SolidColorBrush(Colors.White);
                    break;
                default:
                    break;
            }
        }
    }
}
