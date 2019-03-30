using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUserController : MonoBehaviour
{
    [SerializeField] GameObject[] models;
    [SerializeField] Dropdown dropdown;
    private void Awake()
    {
        dropdown.onValueChanged.AddListener(SetModel);
        Debug.Log("Called####");
    }

    private void SetModel(int index)
    {
        for(int i = 0; i < models.Length; i++)
        {
            Debug.Log($"Called: {index}");
            if (i == index)
            {
                models[i].SetActive(true);

            }
            else
            {
                models[i].SetActive(false);
            }
        }
    }
}
