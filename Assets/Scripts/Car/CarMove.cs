using UnityEngine;

public class CarMove : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 200.0f;
    [SerializeField] float timer = 0f;

    float timeSecond = 1f;

    int steerValue;

    void Start()
    {
        
    }


    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeSecond) 
        {
            timer = 0f;
            moveSpeed++;
        }

        transform.Rotate(0f, steerValue * rotateSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }
}

//DISCARDED FEATURE

/*public bool isDecreasing = true;}
 
...
 
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
...
*/

