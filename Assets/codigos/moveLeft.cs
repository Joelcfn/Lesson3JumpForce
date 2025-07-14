using UnityEngine;

public class moveLeft : MonoBehaviour
{       
   private float speed = 30;
private controlodoJogador playerControllerScript;

// Start is called before the first frame update
void Start()
{
    playerControllerScript = GameObject.Find("Player").GetComponent<controlodoJogador>();
}

// Update is called once per frame
void Update()
{
    if (playerControllerScript.gameOver == false)
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
}