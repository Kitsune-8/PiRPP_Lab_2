using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                int task = taskList.SelectedIndex;
                if (task < 0)
                {
                    resultLabel.Text = "Выберите задачу!";
                    return;
                }

                switch (task)
                {
                    case 0: Task1(); break;
                    case 1: Task2(); break;
                    case 2: Task3(); break;
                    case 3: Task4(); break;
                    case 4: Task5(); break;
                    case 5: Task6(); break;
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Ошибка: " + ex.Message;
            }
        }

        // Задача 1: Сумма 10 чисел
        private void Task1()
        {
            int[] arr = GetNumbers(10);
            int sum = 0;
            for (int i = 0; i < 10; i++)
                sum += arr[i];

            resultLabel.Text = $"Сумма = {sum}";
        }

        // Задача 2: Максимум и минимум
        private void Task2()
        {
            if (!int.TryParse(inputBox.Text, out int n) || n <= 0)
            {
                resultLabel.Text = "Введите положительное число!";
                return;
            }

            Random rnd = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, 101);

            int max = arr[0], min = arr[0];
            int imax = 0, imin = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max) { max = arr[i]; imax = i; }
                if (arr[i] < min) { min = arr[i]; imin = i; }
            }

            resultLabel.Text = $"Массив: {string.Join(" ", arr)}\n" +
                              $"Макс: {max}[{imax}], Мин: {min}[{imin}]";
        }

        // Задача 3: Четные и нечетные
        private void Task3()
        {
            Random rnd = new Random();
            int[] arr = new int[15];
            int even = 0, odd = 0;

            for (int i = 0; i < 15; i++)
                arr[i] = rnd.Next(10, 51);

            foreach (int x in arr)
            {
                if (x % 2 == 0) even++;
                else odd++;
            }

            resultLabel.Text = $"Массив: {string.Join(" ", arr)}\n" +
                              $"Четных: {even}, Нечетных: {odd}";
        }

        // Задача 4: Реверс массива
        private void Task4()
        {
            int[] arr = GetNumbers();
            int[] rev = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                rev[i] = arr[arr.Length - 1 - i];

            resultLabel.Text = $"Было: {string.Join(" ", arr)}\n" +
                              $"Стало: {string.Join(" ", rev)}";
        }

        // Задача 5: Сдвиг вправо
        private void Task5()
        {
            int[] arr = GetNumbers();
            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];
            arr[0] = last;

            resultLabel.Text = $"Результат: {string.Join(" ", arr)}";
        }

        // Задача 6: Подсчет повторений
        private void Task6()
        {
            int[] arr = GetNumbers();
            bool[] counted = new bool[arr.Length];
            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (counted[i]) continue;

                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        counted[j] = true;
                    }
                }
                result += $"Число {arr[i]} - {count} раз(а)\n";
            }
            resultLabel.Text = result;
        }

        // Вспомогательный метод для ввода чисел
        private int[] GetNumbers(int needCount = 0)
        {
            string text = inputBox.Text.Trim();
            if (string.IsNullOrEmpty(text))
                throw new Exception("Введите числа!");

            string[] parts = text.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
                nums[i] = int.Parse(parts[i]);

            if (needCount > 0 && nums.Length != needCount)
                throw new Exception($"Нужно {needCount} чисел!");

            return nums;
        }
    }
}