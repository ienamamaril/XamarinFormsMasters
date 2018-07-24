using System.Collections.Generic;
using System.Linq;

namespace LoveCalculator
{
    public class CalculateResult
    {
        public static int CalculateFlamesCount(string s1, string s2)
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

        //RELATIONSHIP CALCULATION  : It return the Flame result in single char like (F,L,A,M,E or S)
        public static char CalculateRelation(int count)
        {
            bool gameover = true;
            string list = "FLAMES";
            var list1 = list.ToList();
            int runcount;
            int traversing;
            while (gameover)
            {
                runcount = 0;
                traversing = 0;

                while (traversing < list1.Count)
                {
                    if (runcount == count)
                    {
                        if (traversing != 0)
                            list1.Remove(list1[--traversing]);// = '*';  
                        else
                        {
                            list1.Remove(list1[list1.Count - 1]);
                            traversing = 0;
                        }

                        runcount = 0;

                    }
                    else
                    {
                        runcount++;


                        if (traversing < list1.Count - 1)
                        {
                            traversing++;
                        }
                        else
                        {
                            traversing = 0;
                        }
                    }


                    if (list1.Count == 1)
                        traversing = list1.Count;
                }

                gameover = false;
            }

            return list1[0];
        }
        //Relation  : It takes the output of just above method as input letter and return the relation type in word like Friend, Lover or other
        public static string ShowRelationshipResult(char flamesChar)
        {
            string relation = string.Empty;
            string meaning = string.Empty;

            switch (flamesChar)
            {
                case 'F':
                    relation = "Friends";
                    meaning = "Kesa wala, friends naman kayo..";
                    break;
                case 'L':
                    relation = "Lovers";
                    meaning = "Magiging JOWA mo daw bes..";
                    break;
                case 'A':
                    relation = "Attraction";
                    meaning = "M.U. daw.. M.U.";
                    break;
                case 'M':
                    relation = "Married";
                    meaning = "Happily Ever After bes, this is it!!";
                    break;
                case 'E':
                    relation = "Enemies";
                    meaning = "Negatib bes, WARLA daw kayo..";
                    break;
                case 'S':
                    relation = "Siblings";
                    meaning = "Nakababatang KAPATID lang ang tingin sayo.. There, There...";
                    break;
                default:
                    break;
            }
            return relation;

        }
        public static string ShowMeaningResult(char flamesChar)
        {
            string meaning = string.Empty;

            switch (flamesChar)
            {
                case 'F':
                    meaning = "Kesa wala, friends naman kayo..";
                    break;
                case 'L':
                    meaning = "Magiging JOWA mo daw bes..";
                    break;
                case 'A':
                    meaning = "M.U. daw.. M.U.";
                    break;
                case 'M':
                    meaning = "Happily Ever After bes, this is it!!";
                    break;
                case 'E':
                    meaning = "Negatib bes, WARLA daw kayo..";
                    break;
                case 'S':
                    meaning = "Nakababatang KAPATID lang ang tingin sayo.. There, There...";
                    break;
                default:
                    break;
            }
            return meaning;

        }
    }
}