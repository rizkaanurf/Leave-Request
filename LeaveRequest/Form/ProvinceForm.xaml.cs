using LeaveRequest.Applications;
using LeaveRequest.Interfaces;
using LeaveRequest.Models;
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

namespace LeaveRequest
{
    /// <summary>
    /// Interaction logic for ProvinceForm.xaml
    /// </summary>
    public partial class ProvinceForm : Window
    {
        IProvince iProvince = new ProvinceController();
        TB_M_Province province = new TB_M_Province();
        public ProvinceForm()
        {
            InitializeComponent();
        }

        private void AddProvince_Btn_Click(object sender, RoutedEventArgs e)
        {
            province.Name = ProvinceName_Txt.Text;
            province.CreateDate = DateTimeOffset.Now.LocalDateTime;
            var result = iProvince.Insert(province);
            if (result)
            {
                MessageBox.Show("Add Province Success");
                ProvinceName_Txt.Clear();
                dataGridProvince.ItemsSource = iProvince.Get();
            }
            else
            {
                MessageBox.Show("Add Province Failed");
                ProvinceName_Txt.Clear();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridProvince.ItemsSource = iProvince.Get();
        }

        private void UpdateProvince_Btn_Click(object sender, RoutedEventArgs e)
        {
            province.Name = ProvinceName_Txt.Text;
            province.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            int Id = Convert.ToInt16(IdProvince_Txt.Text);
            var result = iProvince.Update(Id, province);
            if (result)
            {
                MessageBox.Show("Update Success");
                IdProvince_Txt.Clear();
                ProvinceName_Txt.Clear();
                dataGridProvince.ItemsSource = iProvince.Get();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void dataGridProvince_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = dataGridProvince.SelectedItem;
            if (selectedItem != null)
            {
                IdProvince_Txt.Text = (dataGridProvince.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ProvinceName_Txt.Text = (dataGridProvince.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
        }

        private void DeleteProvince_Btn_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt16(IdProvince_Txt.Text);
            province.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            var result = iProvince.Delete(Id);
            if (result)
            {
                MessageBox.Show("Delete Success");
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
