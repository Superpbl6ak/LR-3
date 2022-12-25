
using Laba3;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Laba3_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();  
        public MainWindow()
        {
            InitializeComponent();
        }
        
      private void Z1_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
              var z1 = db.Cars.Where(p => p.Name == "Alfa Romeo").Where(p => p.IsStock == true).ToList(); 
              Table1.ItemsSource = z1;
             }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void Z2_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var z2 = db.Cars.Where(p => p.Name.Contains("BMW")).Select(p => p.Stock).Distinct().ToList();
          Table1.ItemsSource = z2;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void Z3_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var z3 = db.Cars.Where(p => p.Cost < 10000).ToList();
          Table1.ItemsSource = z3;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void Z4_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var z4 = db.Cars.Where(p => p.Remark != "").OrderBy(p => p.Name).ToList();
          Table1.ItemsSource = z4;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }

      }

      private void Z5_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var z5 = db.Cars.Where(p => p.DataRelease >= 2000 && p.DataRelease <= 2005).GroupBy(c => c.Stock.Town).Select(g => new { Name = g.Key, Count = g.Count() }).ToList();
          Table1.ItemsSource = z5;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void Z6_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var z6 = db.Cars.Where(p => p.DataRelease < 2000).OrderBy(p => p.DataRelease).ToList();
          Table1.ItemsSource = z6;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void Z7_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          DbReport DBRep = new DbReport() { DateBase = db };
          DBRep.WriteAllReport();
          MessageBox.Show("Файл успешно создан");
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }

      private void CreateBD_OnClick(object sender, RoutedEventArgs e)
      {
          var stocks = new List<Stock>
          {
              new() { Town = "Барнаул" },
              new() { Town = "Калининград" },
              new() { Town = "с. Петропавловское" },
              new() { Town = "Москва" }
          };
          var cars = CarGenerator.GetCars(stocks);
          ApplicationContext db = new ApplicationContext();  
          
          db.Database.EnsureDeleted();
          db.Database.EnsureCreated();

          db.Cars.AddRange(cars);
          db.Stocks.AddRange(stocks);
          db.Cars.AddRange(cars);
          db.SaveChanges();
      }

      private void WriteBD_OnClick(object sender, RoutedEventArgs e)
      {
          if (db.Database.GetService<IRelationalDatabaseCreator>().HasTables())
          { 
          var WriteAllDB = db.Cars.Include(p => p.Stock).ToList();
          Table1.ItemsSource = WriteAllDB;
          }
          else
          {
              MessageBox.Show("БД не создана");
          }
      }
    }
    }