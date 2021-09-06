using System;
using System.Linq;


public class Group
{
    public Student [] GroupAkaArr;
    public int[] Ind;
    public int MaxValue = 0;
    public Group(Student[] students)
    {
        if (students.Length < 5)
        {
            throw new ArgumentException("Incorrect group");
        }
        else
        {
            GroupAkaArr = students;
        }
    }
    public object this[int newInd]
    {
        get 
        { 
            return GroupAkaArr[newInd]; 
        }
    }

    public int IndexOfMaxGrade()
    {
        Ind = new int [GroupAkaArr.Length];
        int maxInd;
        for(int i = 0; i < GroupAkaArr.Length; i++)
        {
            Ind[i] = GroupAkaArr[i].Grade;
        }
        for(int j = 0; j < Ind.Length; j++)
        {
            if (Ind[j] > MaxValue)
            {
                MaxValue = Ind[j];
            }
        }
        maxInd = Array.IndexOf(Ind, MaxValue);
        return maxInd;
    }

    public int IndexOfMinGrade()
    {
        IndexOfMaxGrade();
        int minValue = MaxValue;
        for(int k = 0; k < Ind.Length; k++)
        {
            if(Ind[k] < minValue)
            {
                minValue = Ind[k];
            }
        }
        int minInd = Array.IndexOf(Ind, minValue);
        return minInd;
    }
}