using UnityEngine;

public class repitirfundo : MonoBehaviour
{private Vector3 startPos;
private float repeatWidth;

// Start is called before the first frame update
void Start()
{
    startPos = transform.position;
    repeatWidth = GetComponent<BoxCollider>().size.x / 2;
}

// Update is called once per frame
void Update()
{
    if (transform.position.x < startPos.x - repeatWidth)
    {
        transform.position = startPos;
    }
}
}
