using TMPro;
using UnityEngine;

public class CheckList : MonoBehaviour
{
    public bool isChecked { get; private set; } = false;
    [SerializeField] private TextMeshProUGUI checkTxt;

    void Start()
    {
        PressCheck();
    }

    public void PressCheck()
    {
        isChecked = !isChecked;
        if (isChecked)
        {
            checkTxt.text = "V";
        }
        else
        {
            checkTxt.text = "";
        }
    }

}
