using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int selectedZombiePosition = 0;
    public Text ScoreText;
    private int score = 0;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    // Use this for initialization
    void Start() {

       PickZombie (selectedZombie);
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("left"))
        {
            GetZombieLeft();
        }

        if (Input.GetKeyDown("right"))
        {
            GetZombieRight();
        }

        if (Input.GetKeyDown("up"))
        {
            PushUp();
        }


    }

    void GetZombieLeft() {
        if (selectedZombiePosition == 0)
        {
            selectedZombiePosition = 3;
            PickZombie(zombies[3]);
        } else
        {
            selectedZombiePosition = selectedZombiePosition -1;
            GameObject newZombie = zombies[selectedZombiePosition];
            PickZombie(newZombie);
        }
    }

    void GetZombieRight()
    {
        if (selectedZombiePosition == 3)
        {
            selectedZombiePosition = 0;
            PickZombie(zombies[0]);
        }
        else
        {
            selectedZombiePosition = selectedZombiePosition + 1;
            GameObject newZombie = zombies[selectedZombiePosition];
            PickZombie(newZombie);
        }
    }

    void PushUp() {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    void PickZombie(GameObject newZombie) {
        selectedZombie.transform.localScale = defaultSize;
        selectedZombie = newZombie;
        newZombie.transform.localScale = selectedSize;
    }

    public void Addpoint()
    {
        score = score+ 1;
        ScoreText.text = "Score: "+ score;
    }
}
