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

namespace vlwForms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum Province
    {
        QC,
        ON,
        BC

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GetControlValues();
        }
        private void GetControlValues()
        {
            if (province.SelectedItem != null)
            {
                var selectedComboBoxItem = (ComboBoxItem)province.SelectedItem;
                string value = selectedComboBoxItem.Content.ToString(); // Patate (string)

                // Il est suggere d'utiliser des enums au lieu de string pour manipuler des choix
                // Le bout de code ci-dessous n'est pas a retenir par coeur, il converti une string and sa valeur Enum
                Province p = (Province)Enum.Parse(typeof(Province), value);
            }

            UpdateUI();
        }
        private void UpdateUI()
        {
      
        }

      
    }
}
