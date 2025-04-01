using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[5] { 60, 80, 100, 90, 70 };
        int max = 0;
        for (int i = 0; i < students.Length; i++)
        {
            char grade = hakjum(students[i]);

            Debug.Log((i + 1) + "번 학생의 학점은 " + grade + "입니다.");

            max = Max(max, students[i]);
        }
        Debug.Log("최고점수는 " + max);

    }

    char hakjum(int jumsu)
    {
        if (jumsu >= 90)
            return 'A';
        else if (jumsu >= 80)
            return 'B';
        else if (jumsu >= 70)
            return 'C';
        else if (jumsu >= 60)
            return 'D';
        else
            return 'F';
    }

    int Max(int max, int jumsu)
    {
        if (jumsu > max)
            return jumsu;
        else
            return max;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}