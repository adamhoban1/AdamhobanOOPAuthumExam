using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdamhobanOOPAuthumExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// https://github.com/adamhoban1/AdamhobanOOPAuthumExam
    public partial class MainWindow : Window
    {
        public List<Bike> bikedata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bikedata = new List<Bike>();
            {
                var motorBike1 = new MotorBike("Yamaha", "FZ", new DateTime(2020, 5, 10), new Engine(BikeType.Petrol, 150), 15, 180);
                var motorBike2 = new MotorBike("Harley-Davidson", "Iron 883", new DateTime(2021, 7, 15), new Engine(BikeType.Petrol, 100), 12, 160);

                // Creating 2 ElectricBike objects
                var electricBike1 = new ElectricBike("Tesla", "Model S Electric Bike", new DateTime(2022, 3, 20), new Engine(BikeType.Electric, 50), 3, 80);
                var electricBike2 = new ElectricBike("Rad Power Bikes", "RadRover 6 Plus", new DateTime(2023, 2, 5), new Engine(BikeType.Electric, 60), 4, 90);

                // Creating 2 TraditionalBike objects
                var traditionalBike1 = new TraditionalBike("Schwinn", "Classic Cruiser", new DateTime(2019, 8, 12), true, true);
                var traditionalBike2 = new TraditionalBike("Trek", "Marlin 7", new DateTime(2020, 4, 10), false, true);

                // Adding all bikes to the list
                bikedata.Add(motorBike1);
                bikedata.Add(motorBike2);
                bikedata.Add(electricBike1);
                bikedata.Add(electricBike2);
                bikedata.Add(traditionalBike1);
                bikedata.Add(traditionalBike2);

            }
            // Displaying the bikes in the ListBox
            bikeListBx.ItemsSource = bikedata;




        }

        private void bikeListBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bikeListBx.SelectedItem != null)
            {
                Bike selectedBike = (Bike)bikeListBx.SelectedItem;
                // Displaying the selected bike's information in the TextBox
                bikediscBox.Text = $"Make: {selectedBike.Make}\n" + $"Model: {selectedBike.Model}\n" + $"year: {selectedBike.DateOfManufacture.ToShortDateString()}\n" +
                                     $"Fuel: {selectedBike.Engine?.Fuel} ({selectedBike.Engine?.HorsePower} HP)\n" + $"Hoursepower: {selectedBike.Engine?.HorsePower}\n" +
                                     $"Tank Capacity: {selectedBike.TankCapacity} L\n" + $"Max Speed: {selectedBike.MaxSpeed} km/h\n";

            }
        }
    }
}
