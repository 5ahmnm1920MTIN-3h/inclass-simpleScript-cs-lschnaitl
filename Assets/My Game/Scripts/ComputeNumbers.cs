using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{ 
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_subtract_Numbers;

    private void Start()
    {
        btn_reset.interactable = false;
    }

    public void SetResult()
    {
        result.text = SubtractNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_subtract_Numbers.interactable = false;
        btn_reset.interactable = true;
    }

    public void Reset()
    {
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_subtract_Numbers.interactable = true;
        btn_reset.interactable = false;
        result.text = "Result";
    }
    private int SubtractNumbers()
    {
        int tempResult = int.Parse(varA.text) - int.Parse(varB.text);
        return tempResult;
    }
}
