using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManage : MonoBehaviour
{
    [SerializeField] TMP_Text difficultySaved;

    CarMove carSettings;

    void Start()
    {
        carSettings = FindObjectOfType<CarMove>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ChooseDifficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }

    public void CarChoice()
    {
        SceneManager.LoadScene("Car");
    }

    public void EasyDifficulty()
    {
        float easyMultiplier = 0.5f;
        float easySpeed = 10f;

        carSettings.moveSpeed = easySpeed;
        carSettings.multilpier = easyMultiplier;

        PlayerPrefs.SetFloat("moveSpeed", carSettings.moveSpeed);
        PlayerPrefs.SetFloat("multilpier", carSettings.multilpier);

        difficultySaved.text = "YOUR DIFFICULTY HAS BEEN SETTED!";
        StartCoroutine(ClearText());
    }

    public void IntermediateDifficulty()
    {
        float intermediateMultiplier = 1f;
        float intermediateSpeed = 20f;

        carSettings.moveSpeed = intermediateSpeed;
        carSettings.multilpier = intermediateMultiplier;

        PlayerPrefs.SetFloat("moveSpeed", carSettings.moveSpeed);
        PlayerPrefs.SetFloat("multilpier", carSettings.multilpier);

        difficultySaved.text = "YOUR DIFFICULTY HAS BEEN SETTED!";
        StartCoroutine(ClearText());
    }

    public void HardDifficulty()
    {
        float hardMultiplier = 1.5f;
        float hardSpeed = 25f;

        carSettings.moveSpeed = hardSpeed;
        carSettings.multilpier = hardMultiplier;

        PlayerPrefs.SetFloat("moveSpeed", carSettings.moveSpeed);
        PlayerPrefs.SetFloat("multilpier", carSettings.multilpier);

        difficultySaved.text = "YOUR DIFFICULTY HAS BEEN SETTED!";
        StartCoroutine(ClearText());
    }

    public IEnumerator ClearText()
    {
        yield return new WaitForSeconds(1f);

        difficultySaved.text = "";
    }

}
