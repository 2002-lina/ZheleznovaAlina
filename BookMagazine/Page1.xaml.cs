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

namespace BookMagazine
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<Книги> КнигиList = Base.E.Книги.ToList();
        List<Авторы> АвторыList = Base.E.Авторы .ToList();
        public Page1()
        {
            InitializeComponent();
            Book.ItemsSource = КнигиList;

        }
        int i = -1;
        int indexChange;
        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                i++;
                MediaElement ME = (MediaElement)sender;
                Книги SE = КнигиList[i];
                Uri U = new Uri(SE.Обложка, UriKind.RelativeOrAbsolute);
                ME.Source = U;
            }
        }

        private void Title_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги SE = КнигиList[i];
                TB.Text = SE.Название;
            }
        }

        private void Avtor_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги SE = КнигиList[i];
                TB.Text = SE.Авторы.Автор;
            }
        }

        private void Cost_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги SE = КнигиList[i];
               
                TB.Text = Convert.ToString(SE.Цена);
            }
        }

        private void Nal_mag_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги SE = КнигиList[i];
                if (SE.Количество_магазин >= 5)
                {
                    TB.Text = "много";
                }
                else
                {
                    TB.Text = Convert.ToString(SE.Количество_магазин);
                }       
            }
        }

        private void Nal_skl_Initialized(object sender, EventArgs e)
        {
            if (i < КнигиList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги SE = КнигиList[i];
                if (SE.Количество_склад >= 5)
                {
                    TB.Text = "много";
                }
                else
                {
                    TB.Text = Convert.ToString(SE.Количество_склад);
                }

            }
        }

        private void DGDobav_Initialized(object sender, EventArgs e)
        {
            Button DGDobav = (Button)sender;
            if (DGDobav != null)
            {
                DGDobav.Uid = Convert.ToString(i);
            }

        }
        int k = 0;
        private void DGDobav_Click(object sender, RoutedEventArgs e)
        {
            Button DGDobav = (Button)sender;
            int ind = Convert.ToInt32(DGDobav.Uid);
            indexChange = Convert.ToInt32(DGDobav.Uid);
            Книги S = КнигиList[ind];
            Pokupka.Visibility = Visibility.Visible;
            k++;
            coun_book.Text = Convert.ToString( + k) ;
            coun_book_pok.Text = Convert.ToString(S.Цена+S.Цена) + " руб";
        }

        }

    }



 