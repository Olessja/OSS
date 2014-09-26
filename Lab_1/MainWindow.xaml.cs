using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnbutton4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnbutton3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void btnbutton1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
                if (tbN.Text.Length == 0)
                {
                    MessageBox.Show("Вы не ввели количество элементов!");
                    return;
                }
                bool flag = true;
                foreach (char c in tbN.Text)
                {
                    if (!char.IsDigit(c)) flag = false;
                }
                if (!flag)
                {
                    MessageBox.Show("Вы ввели недопустимые символы!");
                }
                else
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    Random rnd1 = new Random();
                    int number;
                    lbMain.Items.Clear();
                    for (index = 1; index <= itemCount; index++)
                    {
                        number = -100 + rnd1.Next(200);
                        myAL.Add(number);
                        lbMain.Items.Add(number);
                    }
                }
        }

        private void btnbutton2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы ввели недопустимые символы!");
                return;
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Вы ввели недопустимые символы!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив:");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                myAL.Sort();
                lbMain.Items.Add("Отсортированный массив:");
                foreach (int elem in myAL)
                {
                    lbMain.Items.Add(elem);
                }
            }
        }

        private void btnbutton5_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели количество элементов!");
                return;
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Вы ввели недопустимые символы!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив:");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                int count = 0;
                for (index = 1; index < myArr.Length - 1; index++)
                    if ((myArr[index - 1] < myArr[index]) && (myArr[index] > myArr[index + 1]))
                        count++;

                lbMain.Items.Add("Количество соседних элементов:");
                lbMain.Items.Add(count);
            }
        }

        private void btnbutton6_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int num = 25;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели количество элементов!");
                return;
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Вы ввели недопустимые символы!");
            }
            else
            {
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив:");
                for (index = 0; index < itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                int max = myArr[0];
                for (index = 0; index < itemCount; index++)
                {
                    if (myArr[index] > num)
                    {
                        lbMain.Items.Add("Номер элемента, который больше 25:");
                        lbMain.Items.Add(index);
                        break;
                    }
                }
                
            }
        }

        private void btnbutton7_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int summ = 0;
            if (tbN.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели количество элементов!");
                return;
            }
            bool flag = true;
            foreach (char c in tbN.Text)
            {
                if (!char.IsDigit(c)) flag = false;
            }
            if (!flag)
            {
                MessageBox.Show("Вы ввели недопустимые символы!");
            }
            else
            {
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив:");
                int itemCount = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                for (index = 0; index < itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }
                int[] myArr = new int[itemCount];
                myArr = (int[])myAL.ToArray(typeof(int));
                foreach (int a in myArr)
                {
                    if (a > myArr[1]) summ += a;
                }
                lbMain.Items.Add("Сумма элементов массива больших, чем второй элемент этого массива");
                lbMain.Items.Add(summ);
            } 
        }
    }
}
