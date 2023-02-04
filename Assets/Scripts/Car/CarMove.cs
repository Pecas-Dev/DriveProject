using UnityEngine;

public class CarMove : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float timer = 0f;

    float timeSecond = 1f;
    public bool isDecreasing = true;

    void Start()
    {
        //Time.timeScale = 3.5f;
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeSecond)
        {
            timer = 0f;

            if (isDecreasing)
            {
                moveSpeed--;

                if (moveSpeed <= -10f)
                {
                    isDecreasing = false;
                }
            }
            else
            {
                moveSpeed++;

                if (moveSpeed >= 10f)
                {
                    isDecreasing = true;
                }
            }
        }

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
