using UnityEngine;

public class spwanManager : MonoBehaviour
{public GameObject obstaclePrefab;
private Vector3 spawnPos = new Vector3(25, 0, 0);
private float startDelay = 2;
private float repeatRate = 2;
private controlodoJogador playerControllerScript;
// Start is called before the first frame update
void Start()
{
        playerControllerScript = GameObject.Find("Player").GetComponent<controlodoJogador>();

    InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
}

// Update is called once per frame
void Update()
{
}

void SpawnObstacle()
{
    if(playerControllerScript.gameOver == false){


            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}
}
