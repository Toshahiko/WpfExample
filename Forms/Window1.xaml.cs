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
using System.Windows.Shapes;
using WpfExample.ViewModels;

namespace WpfExample.Forms
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        private int _row = -1 ;
        public Window1( Window1ViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            int a = 0;
            var comboBox = sender as ComboBox;
            var dataGridCell= GetParentDataGridCell(comboBox) as DataGridCell;
            dataGridCell.Focus();
            dataGrid.CurrentCell = new DataGridCellInfo(dataGridCell);
            var item = dataGrid.CurrentItem;
            _row = dataGrid.Items.IndexOf(comboBox.DataContext);
            dataGridCell.IsSelected = true;
        }

        private DependencyObject GetParentDataGridCell( DependencyObject dependencyObject)
        {
            if (dependencyObject is DataGridCell cell) return cell;
            var visualParent = VisualTreeHelper.GetParent(dependencyObject);

            return GetParentDataGridCell(visualParent);
        }

        private void ComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
        }

        private void ComboBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _row = -1;

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void dataGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            _row = -1;
        }
    }
}
