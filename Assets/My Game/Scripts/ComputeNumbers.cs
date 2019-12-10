using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{ 
    public Text result;

    private const string resultText = "Result";
    public InputField inputField1;
    public InputField inputField2;

    public Button resetButton;
    public Button subtractButton;

    private void Start()
    {
        resetButton.interactable = false;
    }

    public void SetResult()
    {
        result.text = SubtractNumbers().ToString();

        inputField1.interactable = false;
        inputField2.interactable = false;

        subtractButton.interactable = false;
        resetButton.interactable = true;
    }

    public void Reset()
    {
        // reset the all texts
        inputField1.text = "";
        inputField2.text = "";
        result.text = resultText;

        // give access to the inputfields again
        inputField1.interactable = true;
        inputField2.interactable = true;

        // activate the now needed buttons
        subtractButton.interactable = true;
        resetButton.interactable = false;


    }
    private int SubtractNumbers()
    {
        int tempResult = int.Parse(inputField1.text) - int.Parse(inputField2.text);
        return tempResult;
    }
}
