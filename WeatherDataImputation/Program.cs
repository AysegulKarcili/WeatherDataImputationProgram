using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataImputation
{
    class Program
    {
        private static DateTime Date(string dataRow)
        {
            string year = dataRow.Split('|')[2];
            string month = dataRow.Split('|')[3];
            if (month.Length != 2)
            {
                month = '0' + month;
            }
            string day = dataRow.Split('|')[4];
            if (day.Length != 2)
            {
                day = '0' + day;
            }
            string hour = dataRow.Split('|')[5] + ":00:00";
            if (hour.Length != 8)
            {
                hour = "0" + hour;
            }

            string dateStr = year + '-' + month + '-' + day + ' ' + hour;
            DateTime date = DateTime.Parse(dateStr);
            return date;
        }

        static void Main(string[] args)
        {
            String path = @"..\..\..\elazig.txt";
            String[] data = File.ReadAllLines(path);

            String[] dataExt = new String[data.Length * 2];
            dataExt[0] = data[0]; // Check the first data row manually!
            int n = 1; //for data
            int m = 1; //for dataExt

            String[] dataCreated = new String[data.Length];
            int c = 0;

            while (n < data.Length)
            {
                if (Date(data[n]) == Date(dataExt[m - 1]).AddHours(1))
                {
                    dataExt[m] = data[n];
                    dataExt[m] = data[n];
                    n++;
                    m++;
                }
                else
                {
                    DateTime newDate = Date(dataExt[m - 1]).AddHours(1);
                    double degree = (Convert.ToDouble(data[n - 1].Split('|')[6]) + Convert.ToDouble(data[n].Split('|')[6])) / 2;
                    dataExt[m] += data[n].Split('|')[0] + '|' + data[n].Split('|')[1] + '|';
                    dataExt[m] += newDate.Year.ToString() + '|' + newDate.Month.ToString() + '|' + newDate.Day.ToString() + '|' + newDate.Hour.ToString() + '|';
                    dataExt[m] += degree.ToString();
                    m++;

                    dataCreated[c] = dataExt[m - 1];
                    c++;
                }
            }

            String[] dataExtS = new String[m];
            for (int i = 0; i < dataExtS.Length; i++)
            {
                dataExtS[i] = dataExt[i];
                //Console.WriteLine(dataExtS[i]);
            }
            String pathExt = @"..\..\..\elazigYeni.txt";
            File.WriteAllLines(pathExt, dataExtS);

            String[] dataCreatedS = new String[c];
            for (int i = 0; i < dataCreatedS.Length; i++)
            {
                dataCreatedS[i] = dataCreated[i];
                //Console.WriteLine(dataCreatedS[i]);
            }
            String pathCreated = @"..\..\..\elazigEklenenler.txt";
            File.WriteAllLines(pathCreated, dataCreatedS);

            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}