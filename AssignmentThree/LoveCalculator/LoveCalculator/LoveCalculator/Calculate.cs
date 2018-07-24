using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LoveCalculator
{
	public class Calculate : ContentPage
	{
        private int CalculateFlamesCount(string s1, string s2)
        {
            List<char> lst1 = s1.ToList();
            List<char> lst2 = s2.ToList();

            int count = 0;
            int j = 0;
            while (j < lst2.Count)
            {

                if (lst1.Contains(lst2[j]))
                {
                    lst1.Remove(lst2[j]);
                    lst2.Remove(lst2[j]);
                    if (j == 0)
                        j = 0;
                    else
                        j--;

                }
                else
                    j++;
            }
            count = lst1.Count + lst2.Count;
            return count;
        }
    }
}