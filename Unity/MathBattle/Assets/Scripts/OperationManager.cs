using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperationManager : MonoBehaviour
{
    System.Random rnd = new System.Random();
    Button[] buttons;
    public Text operation;
    public Text score;

    private int scoreValue = 0;
    private int x;
    private int y;

    // Start is called before the first frame update
    void Start()
    {
        buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => CheckAnswer(button));
        }

        GenerateRandomOperation();
    }

    public void GenerateRandomOperation()
    {
        foreach (Button button in buttons)
        {
            x = rnd.Next(0, 12);
            y = rnd.Next(0, 12);
            button.GetComponentInChildren<Text>().text = (x * y).ToString();
        }

        x = rnd.Next(0, 12);
        y = rnd.Next(0, 12);
        operation.text = x + " x " + y;
        buttons[rnd.Next(0, buttons.Length)].GetComponentInChildren<Text>().text = (x * y).ToString();
    }

    public void CheckAnswer(Button button)
    {
        if ((x * y).ToString() == button.GetComponentInChildren<Text>().text)
        {
            scoreValue++;
        }
        else
        {
            scoreValue--;
        }
        score.text = "Score: " + scoreValue.ToString();

        GenerateRandomOperation();
    }
}
