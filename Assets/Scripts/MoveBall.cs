
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MoveBall : MonoBehaviour
{   public float speed;
    public float jumpspeed;
    bool istouching;
    public int score;
    public Text scoreText;
    public AudioSource asource;
    public AudioClip aclip;
    Rigidbody Rb;
    public GameObject pausePanel;
    void Start()
    {
        score = 14;
        Rb = GetComponent<Rigidbody>();
        scoreText.text = "Coins Left: " + score;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (pausePanel.active == false)
        {
            float Hmove = Input.GetAxis("Horizontal");
            float Vmove = Input.GetAxis("Vertical");
            Vector3 moveball = new Vector3(Hmove, 0, Vmove);
            Rb.AddForce(moveball * speed);

            if ((Input.GetKey(KeyCode.Space)) && (istouching == true))
            {
                Vector3 jumpball = new Vector3(0, 6, 0);
                Rb.AddForce(jumpball * jumpspeed);

            }
            istouching = false;
        }
        else
        {
            Rb.SetDensity(100000000);
            
        }
    }

    private void OnCollisionStay()
    {
        istouching = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            score--;
            if (score == 0)
            {
                FindObjectOfType<gamemanager>().LevelWon();
            }
            else
            {
                scoreText.text = "Coins Left: " + score;
                asource.PlayOneShot(aclip);
            }

        }
        else if (other.gameObject.CompareTag("space"))
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
        
    }

}
