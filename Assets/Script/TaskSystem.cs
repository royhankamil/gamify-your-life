using TMPro;
using UnityEngine;

public class TaskSystem : MonoBehaviour
{
    [SerializeField] private RectTransform taskParent;
    [SerializeField] private TMP_InputField taskInput;
    [SerializeField] private GameObject taskPrefab;
    // [SerializeField] private float gap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddTask()
    {
        if (taskInput.text != "")
        {
            GameObject newTask = Instantiate(taskPrefab, taskParent);
            taskParent.sizeDelta = new Vector2(taskParent.sizeDelta.x, 125 * (taskParent.childCount - 1) + 100);
            newTask.GetComponent<OneTask>().SetTaskText(taskInput.text);
            taskInput.text = "";
        }
    }
}
