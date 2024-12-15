using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrengthg;
    public LogicScript logic;
    bool birdIsAlive = true;
    public Text HighscoreText;
    public double lowerBound = -12.78;
    public double upperBound = 13.89;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        //if (PlayerPrefs.GetInt("HighScore").Equals(0))
        //{

        //    HighscoreText.text = "High Score: 0";
        //}
        //else
        //{
        //    HighscoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrengthg;
        }
        if(transform.position.y<lowerBound || transform.position.y > upperBound)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }

}
