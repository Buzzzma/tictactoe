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

namespace TicTacToeWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private bool CheckForWin()
        {
            string[,] symbols = new string[3, 3];

            // Получаем из кнопок символы
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    symbols[i, j] = ((Button)grid.Children[i * 3 + j]).Content as string;
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                //Проверяем строки
                if (symbols[i, 0] == symbols[i, 1] && symbols[i, 1] == symbols[i, 2] && symbols[i, 0] != null)
                {
                    return true;
                }
                //Проверяем столбцы
                if (symbols[0, i] == symbols[1, i] && symbols[1, i] == symbols[2, i] && symbols[0, i] != null)
                {
                    return true;
                }
            }

            //Проверяем диагональ 1
            if (symbols[0, 0] == symbols[1, 1] && symbols[1, 1] == symbols[2, 2] && symbols[0, 0] != null)
            {
                return true;
            }
            //Проверяем диагональ 2
            if (symbols[0, 2] == symbols[1, 1] && symbols[1, 1] == symbols[2, 0] && symbols[0, 2] != null)
            {
                return true;
            }

            return false;
        }
        private void Reset()
        {
            foreach (var control in grid.Children)
            {
                if (control is Button button)
                {
                    button.Content = null;
                }
            }
            Singleton.cellState = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content == null)
            {
                button.Content = Singleton.cellState ? "X" : "O";
                Singleton.cellState = !Singleton.cellState;
            }

            if (CheckForWin())
            {
                MessageBox.Show($"Игрок {(Singleton.cellState ? "O" : "X")} победил!");
                Reset();
            }/*else
            {
                MessageBox.Show($"Победила дружба");
            }*/
        }
    }
}
