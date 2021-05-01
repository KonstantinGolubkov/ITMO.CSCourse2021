using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab03_01.WhatDay1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class WhatDay
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;

            if (dayNum <= 31) // January
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 28) // February
            {
                goto End;
            }
            else
            {
                dayNum -= 28;
                monthNum++;
            }

            if (dayNum <= 31) // March
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30) // April
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31) // May
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30) // June
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31) // July
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 31) // August
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30) // September
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31) // October
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }

            if (dayNum <= 30) // November
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }

            if (dayNum <= 31) // December
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
        End:
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();

            Console.WriteLine("{0} {1}", dayNum, monthName);


            //string stringMonthNum = monthNum.ToString();
            //switch (monthNum)
            //{
            //    case 0:
            //        stringMonthNum = "January";
            //        break;
            //    case 1:
            //        stringMonthNum = "February";
            //        break;
            //    case 2:
            //        stringMonthNum = "March";
            //        break;
            //    case 3:
            //        stringMonthNum = "April";
            //        break;
            //    case 4:
            //        stringMonthNum = "May";
            //        break;
            //    case 5:
            //        stringMonthNum = "June";
            //        break;
            //    case 6:
            //        stringMonthNum = "July";
            //        break;
            //    case 7:
            //        stringMonthNum = "August";
            //        break;
            //    case 8:
            //        stringMonthNum = "September";
            //        break;
            //    case 9:
            //        stringMonthNum = "October";
            //        break;
            //    case 10:
            //        stringMonthNum = "November";
            //        break;
            //    case 11:
            //        stringMonthNum = "December";
            //        break;
            //    default:
            //        stringMonthNum = "not done yet";
            //        break;
            //}
            //Console.WriteLine("{0} {1}", dayNum, stringMonthNum);
        }
    }
}
