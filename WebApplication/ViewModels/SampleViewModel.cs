namespace WebApplication.ViewModels
{
    public class SampleViewModel : BindableBase
    {
        private int _value1;

        public int Value1
        {
            get => _value1;
            set
            {
                SetProperty(ref _value1, value);
                OnPropertyChanged(nameof(Result));
            }
        }

        private int _value2;

        public int Value2
        {
            get => _value2;
            set
            {
                SetProperty(ref _value2, value);
                OnPropertyChanged(nameof(Result));
            }
        }

        public int Result => Value1 + Value2;
    }
}
