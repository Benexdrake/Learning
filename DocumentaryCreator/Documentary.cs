using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentaryCreator
{
    public class Documentary
    {
        public void Start(int year)
        {
            

            int months = GetMonths(year);

            CreateYearDirectory(year);

            for (int i = 0; i < months; i++)
            {
                int month = i + 1;

                if(year == DateTime.Now.Year)
                    month = DateTime.Now.Month + i;
                int days = GetDays(year, month);

                CreateMonthDirectory(year,month);

                CreateDocumentarys(year,month,days);
            }
        }
        public int GetYear()
        {
            return DateTime.Now.Year;
        }

        public int GetMonths(int year)
        {
            int months = 12;

            if (year == DateTime.Now.Year)
            {
                months -= (DateTime.Now.Month - 1);
            }
            return months;
        }

        public int GetDays(int year,int month)
        {
            return DateTime.DaysInMonth(year,month);
        }

        private void CreateYearDirectory(int year)
        {
            string y = year.ToString();
            if (!Directory.Exists(y))
                Directory.CreateDirectory(y);
        }

        private void CreateMonthDirectory(int year, int month)
        {
            string y = year.ToString();
            string m = month.ToString();

            string path = $"{y}\\{m}";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void CreateDocumentarys(int year, int month, int days)
        {
            string y = year.ToString();
            string m = month.ToString();

            string path = $"{y}\\{m}";

            if (Directory.Exists(path))
            {
                for (int i = 1; i <= days; i++)
                {
                    if(i < 10)
                    {
                        StreamWriter sw = File.CreateText(path + $"\\{year}_{month}_0{i}.md");
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(path + $"\\{year}_{month}_{i}.md");
                    }
                }
            }
        }
    }
}
