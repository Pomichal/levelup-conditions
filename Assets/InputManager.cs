﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;
    public TextMeshProUGUI resultText;

    // exercise 1
    public void PasswordCheck()
    {
        string inputText = input1.text;
        // TODO: check the string, print "correct" if the string is "secretPassword", else print "try again"
    }

    // exercise 2
    public void WhichIsBigger()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print "{X} is bigger than {Y}" according to the input numbers

    }

    // exercise 3
    public void WhichIsBiggerAgain()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);
        int inputNumber3 = int.Parse(input3.text);
        // TODO: print out, which number is the biggest (+ order of numbers)

    }

    // exercise 4
    public void IsEven()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out, whether the even or odd
    }

    // exercise 5
    public void IsItWater()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out according the temprerature, whether the water is on liquid, solid or gase state
    }

    // exercise 6
    public void EvaulateTheExam()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out the result of exam according to the number of points (use switch)
    }

    // exercise 7
    public void Division()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print out, whether A can be divided by B (consider only integers)
    }

    // exercise 8
    public void WhichYearIsIt()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO print out whether year X is a gap year
    }

    // exercise 9
    public void IsItATriangle()
    {
        float inputNumber1 = float.Parse(input1.text);
        float inputNumber2 = float.Parse(input2.text);
        float inputNumber3 = float.Parse(input3.text);

        // TODO:print out, whether a triangle with sides X,Y,Z can exist
    }

    public void IWantMoreExercises()
    {
        // TODO: ask for more exercises, if you are done with everything
    }

    // a helper method to show the result in the console and in resultText
    public void PrintAnswer(string solution)
    {
        Debug.Log(solution);
        resultText.text = solution;
    }
}
