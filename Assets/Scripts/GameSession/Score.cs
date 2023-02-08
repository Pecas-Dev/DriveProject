using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] public TMP_Text speed;
    [SerializeField] float scoreMultiplier;

    CarMove car;

    float score;
   
    void Start()
    {
        car = FindObjectOfType<CarMove>();
    }

    
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        speed.text = "Speed: " + car.moveSpeed.ToString();
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
