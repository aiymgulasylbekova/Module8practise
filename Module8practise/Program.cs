/*
using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace module8practise
{
    internal class program
    {
        static void main(string[] args)
        {
            console.write("начало: ");
            int startindex = int.parse(console.readline());
            console.write("конец: ");
            int endindex = int.parse(console.readline());

            rangeofarray customarray = new rangeofarray(startindex, endindex);

            console.writeline("введите массив:");

            for (int i = startindex; i <= endindex; i++)
            {
                console.write($"элемент: ");
                customarray[i] = int.parse(console.readline());
            }

            console.writeline("массив:");

            for (int i = startindex; i <= endindex; i++)
            {
                console.writeline($"элемент: {customarray[i]}");
                console.readkey();
            }


        }


        class rangeofarray
        {
            private int startindex;
            private int endindex;
            private int[] array;

            public rangeofarray(int start, int end)
            {
                if (end < start)
                {
                    throw new argumentexception("конечный индекс должен быть больше или равен начальному индексу.");
                }

                startindex = start;
                endindex = end;
                array = new int[end - start + 1];
            }

            public int this[int index]
            {
                get
                {
                    if (isindexvalid(index))
                    {
                        return array[converttointernalindex(index)];
                    }
                    else
                    {
                        throw new indexoutofrangeexception("индекс находится не в диапазоне массива");
                    }
                }
                set
                {
                    if (isindexvalid(index))
                    {
                        array[converttointernalindex(index)] = value;
                    }
                    else
                    {
                        throw new indexoutofrangeexception("индекс находится вне диапазона.");
                    }
                }
            }

            private bool isindexvalid(int index)
            {
                return index >= startindex && index <= endindex;
            }

            private int converttointernalindex(int index)
            {
                return index - startindex;
            }

        }

    }

}

2
using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace module8practise
{
    internal class program
    {
        static void main(string[] args)
        {
            datetime currenttime = datetime.now;

            bool sale = currenttime.hour >= 8 && currenttime.hour < 12;

            string[] products = { "яблоко", "бублик", "виноград", "йогурт", "торт" };
            double[] prices = { 450, 700, 400, 250, 2500 };

            console.writeline("продукты и цены");
            for (int i = 0; i < products.length; i++)
            {
                console.writeline($"{products[i]}: {prices[i]} тг");
            }

            console.writeline("выберите продукты для покупки");
            string input = console.readline();
            string[] prnumber = input.split(',');

            double totalcost = 0.0;

            foreach (string productnumber in prnumber)
            {
                int index = int.parse(productnumber.trim());
                if (index >= 0 && index < products.length)
                {
                    totalcost += prices[index];
                }
            }

            if (sale)
            {
                totalcost *= 0.95;
                console.writeline("скидка 5%!");
            }

            console.writeline($"итого: {totalcost} тг");

            console.writeline("вам начислены бонусы от покупок, приходите еще!");


        }
    }
}
*/

//3
using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace module8practise
{
    internal class program
    {
        static void main(string[] args)
        {

            double[] months = { 1, 2, 3, 4, 5 };
            double[] sales = { 5, 10, 15, 20, 25 };

            int n = months.length;

            double summ = 0, sums = 0, summsales = 0, summsquared = 0;
            for (int i = 0; i < n; i++)
            {
                summ += months[i];
                sums += sales[i];
                summsales += months[i] * sales[i];
                summsquared += months[i] * months[i];
            }

            double a = (n * summsales - summ * sums) / (n * summsquared - summ * summ);
            double b = (sums - a * summ) / n;

            for (int month = 6; month <= 8; month++)
            {
                double forecast = a * month + b;
                console.writeline($" продажа за месяц {month}: {forecast:f2}");
            }



            console.readline();
        }
    }
}
