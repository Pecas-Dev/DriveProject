using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    [SerializeField] TMP_Text carSaved;

    CarSwitcher carSwitcher;

    void Start()
    {
        carSwitcher = FindObjectOfType<CarSwitcher>();
    }

    public void ChangeToModel1()
    {
        carSwitcher.ChangeModel(0);
        carSaved.text = "YOU CHOSE THE CAMARO!";
        StartCoroutine(ClearTextCar());
    }

    public void ChangeToModel2()
    {
        carSwitcher.ChangeModel(1);
        carSaved.text = "YOU CHOSE THE MUSTANG!";
        StartCoroutine(ClearTextCar());
    }

    public IEnumerator ClearTextCar()
    {
        yield return new WaitForSeconds(1.5f);

        carSaved.text = "";
    }


}
