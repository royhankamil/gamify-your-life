using TMPro;
using UnityEngine;

public class TaskSystem : MonoBehaviour
{
    [SerializeField] private Transform taskParent;
    [SerializeField] private TMP_InputField taskInput;
    [SerializeField] private GameObject taskPrefab;

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
            newTask.GetComponent<OneTask>().SetTaskText(taskInput.text);
            taskInput.text = "";
        }
    }
}
