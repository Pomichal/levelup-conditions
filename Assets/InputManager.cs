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

        if(inputText == "secretPassword")
        {
            PrintAnswer("correct");
        }
        else
        {
            PrintAnswer("try again");
        }

    }

    // exercise 2
    public void WhichIsBigger()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print "{X} is bigger than {Y}" according to the input numbers
        // or print "the numbers are equal" if they are equal

        if(inputNumber1 > inputNumber2)
        {
            PrintAnswer(inputNumber1 + " is bigger than " + inputNumber2);
        }
        else if(inputNumber1 < inputNumber2)
        {
            PrintAnswer(inputNumber2 + " is bigger than " + inputNumber1);
        }
        else
        {
            PrintAnswer("the numbers are equal");
        }
    }

    // exercise 3
    public void WhichIsBiggerAgain()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);
        int inputNumber3 = int.Parse(input3.text);

        // TODO: print out, which number is the biggest,
        // consider all numbers are different.
        // (bonus: print out the order of numbers)

        if(inputNumber1 > inputNumber2 && inputNumber1 > inputNumber3)
        {
            if(inputNumber2 > inputNumber3)
            {
                PrintAnswer("The order of numbers: " + inputNumber1 + " > " + inputNumber2 + " > " + inputNumber3);
            }
            else
            {
                PrintAnswer("The order of numbers: " + inputNumber1 + " > " + inputNumber3 + " > " + inputNumber2);
            }
        }
        else if(inputNumber2 > inputNumber3)
        {
            if(inputNumber1 > inputNumber3)
            {
                PrintAnswer("The order of numbers: " + inputNumber2 + " > " + inputNumber1 + " > " + inputNumber3);
            }
            else
            {
                PrintAnswer("The order of numbers: " + inputNumber2 + " > " + inputNumber3 + " > " + inputNumber1);
            }
        }
        else
        {
            if(inputNumber1 > inputNumber2)
            {
                PrintAnswer("The order of numbers: " + inputNumber3 + " > " + inputNumber1 + " > " + inputNumber2);
            }
            else
            {
                PrintAnswer("The order of numbers: " + inputNumber3 + " > " + inputNumber2 + " > " + inputNumber1);
            }
        }
    }

    // exercise 4
    public void IsEven()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out, whether the number is even or odd

        if(inputNumber1 % 2 == 0)
        {
            PrintAnswer(inputNumber1 + " is even");
        }
        else
        {
            PrintAnswer(inputNumber1 + " is odd");
        }
    }

    // exercise 5
    public void IsItWater()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out whether the water is on liquid, solid or gase state
        // according to temperature

        if(inputNumber1 < 0)
        {
            PrintAnswer("it's solid");
        }
        else if(inputNumber1 < 100)
        {
            PrintAnswer("it's liquid");
        }
        else
        {
            PrintAnswer("it's gase");
        }
    }

    // exercise 6
    public void EvaulateTheExam()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO: print out the result of exam according to the number of points (use switch)
        // 1 - excelent, 2 - very good, 3 - good, 4 - good enough, 5 - see you next year

        switch(inputNumber1)
        {
            case 1:
                PrintAnswer("excelent");
                break;
            case 2:
                PrintAnswer("very good");
                break;
            case 3:
                PrintAnswer("good");
                break;
            case 4:
                PrintAnswer("good enough");
                break;
            case 5:
                PrintAnswer("see you next year");
                break;
            default:
                PrintAnswer("Invalid number");
                break;
        }
    }

    // exercise 7
    public void Division()
    {
        int inputNumber1 = int.Parse(input1.text);
        int inputNumber2 = int.Parse(input2.text);

        // TODO: print out, whether A can be divided by B (consider only integers)
        // (bonus: if B is 0, print out "cannot divide by zero")

        if(inputNumber2 <= 0)
        {
            PrintAnswer("Cannot divide by zero");
        }
        else
        {
            if(inputNumber1 % inputNumber2 == 0)
            {
                PrintAnswer(inputNumber1 + " can by divided by " + inputNumber2);
            }
            else
            {
                PrintAnswer(inputNumber1 + " cannot by divided by " + inputNumber2);
            }
        }
    }

    // exercise 8
    public void WhichYearIsIt()
    {
        int inputNumber1 = int.Parse(input1.text);

        // TODO print out whether year X is a leap year
        // (hint: https://en.wikipedia.org/wiki/Leap_year#Algorithm )

        if((inputNumber1 % 4 == 0 && inputNumber1 % 100 != 0) || inputNumber1 % 400 == 0)
        {
            PrintAnswer(inputNumber1 + " is a leap year");
        }
        else
        {
            PrintAnswer(inputNumber1 + " is not a leap year");
        }
    }

    // exercise 9
    public void IsItATriangle()
    {
        float inputNumber1 = float.Parse(input1.text);
        float inputNumber2 = float.Parse(input2.text);
        float inputNumber3 = float.Parse(input3.text);

        // TODO:print out, whether a triangle with sides X,Y,Z can exist
        if(inputNumber1 + inputNumber2 > inputNumber3 &&
                inputNumber2 + inputNumber3 > inputNumber1 &&
                inputNumber1 + inputNumber3 > inputNumber2)
        {
            PrintAnswer("Is a triangle");
        }
        else
        {
            PrintAnswer("Is not a triangle");
        }
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
