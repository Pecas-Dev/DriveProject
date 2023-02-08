using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitcher : MonoBehaviour
{
    public GameObject[] models;

    void Start()
    {
        int selectedModel = PlayerPrefs.GetInt("SelectedModel", 0);
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(i == selectedModel);
        }
    }

    public void ChangeModel(int modelIndex)
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(i == modelIndex);
        }
        PlayerPrefs.SetInt("SelectedModel", modelIndex);
    }
}
