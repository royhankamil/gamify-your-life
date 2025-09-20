using TMPro;
using UnityEngine;

public class OneTask : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI taskText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SetTaskText(string text)
    {
        taskText.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
