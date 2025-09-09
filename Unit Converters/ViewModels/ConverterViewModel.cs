using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UnitsNet;

namespace Unit_Converters.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {
        public string QuantityName { get; set; } = "";
        public ObservableCollection<string> FromMesaures { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> ToMesaures { get; set; } = new ObservableCollection<string>();
        public string CurrentValueFromMeasure { get; set; } = "";
        public string CurrentValueToMeasure { get; set; } = "";
        public double FromValue { get; set; } = 1;
        public double ToValue { get; set; }
        public ICommand ReturnCommand =>
            new Command(() =>
            {
                Convert();
            });

        public ConverterViewModel()
        {
            QuantityName = "Length";
            FromMesaures = LoadMesaures();
            ToMesaures = LoadMesaures();
            CurrentValueFromMeasure = "Meter";
            CurrentValueToMeasure = "Centimeter";
            Convert();
        }

        public void Convert()
        {
            var result = UnitConverter.ConvertByName(FromValue, QuantityName, CurrentValueFromMeasure, CurrentValueToMeasure);
            ToValue = result;
        }

        private ObservableCollection<string> LoadMesaures()
        {
            var type = Quantity.Infos.First(q => q.Name == QuantityName)
                .UnitInfos.Select(u => u.Name).ToList();

            return new ObservableCollection<string>(type);
        }

    }
}
