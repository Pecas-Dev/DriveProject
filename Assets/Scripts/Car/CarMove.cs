using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove : MonoBehaviour
{

    [SerializeField] public float moveSpeed = 10f;
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacles")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void Ontrigger()
    {
        Invoke(nameof(OnTriggerEnter), 0.5f);
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

