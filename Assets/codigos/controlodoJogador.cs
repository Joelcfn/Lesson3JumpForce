using UnityEngine;

public class controlodoJogador : MonoBehaviour
{   
    private Rigidbody playerRb;
    private Animator PlayerAnim;
public float jumpForce = 10;
public float gravityModifier;
public bool isOnGround = true;
public bool gameOver;
// Start is called before the first frame update
void Start()
{
    playerRb = GetComponent<Rigidbody>();
    PlayerAnim = GetComponent<Animator>();
    Physics.gravity *= gravityModifier;
}

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
    {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
        PlayerAnim.SetTrigger("Jump_trig");
    }
}

private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Ground"))
{
    isOnGround = true;
}
else if (collision.gameObject.CompareTag("obstaculo"))
{
    Debug.Log("Game Over");
    gameOver = true;
    PlayerAnim.SetBool("Death_b", true);
    PlayerAnim.SetInteger("DeathType_int", 1);
}
}

}