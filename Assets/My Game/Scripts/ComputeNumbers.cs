using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{ 
    public Text result;

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
        inputField1.text = "0";
        inputField2.text = "0";

        inputField1.interactable = true;
        inputField2.interactable = true;

        subtractButton.interactable = true;
        resetButton.interactable = false;

        result.text = "Result";
    }
    private int SubtractNumbers()
    {
        int tempResult = int.Parse(inputField1.text) - int.Parse(inputField2.text);
        return tempResult;
    }
}
