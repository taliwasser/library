using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace library
{
    internal class Student
    {
        public static void CulcTotal(List<string[]> row)
        {
            int total = 0;

            for (int i = 0; i < row.Count; i++)
            {
                for (int j = 0; j < row.Count; j++)
                {
                    if (row[i][2]=="student")
                    {
                        if (row[i][4] - row[i][3] > 14)
                        {

                        }
                    }
                    
                }

            }
            

        }
    }
}
