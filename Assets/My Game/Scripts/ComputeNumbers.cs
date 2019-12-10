using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{ 
    [SerializeField] private Text result;
    [SerializeField] private InputField inputField1;
    [SerializeField] private InputField inputField2;
    [SerializeField] private Button resetButton;
    [SerializeField] private Button subtractButton;

    private const string resultText = "Result";

    private void Start()
    {
        resetButton.interactable = false;
    }

    public void SetResult()
    {
        // set the result from the SubtractNumbers Method
        result.text = SubtractNumbers().ToString();

        // remove access from inputFields
        inputField1.interactable = false;
        inputField2.interactable = false;

        // activate the now needed buttons
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
    private float SubtractNumbers()
    {
        float tempResult = float.Parse(inputField1.text) - float.Parse(inputField2.text);
        return tempResult;
    }
}
