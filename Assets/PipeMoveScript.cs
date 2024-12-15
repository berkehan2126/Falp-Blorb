using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public int deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        DeletePipe();

    }

    void DeletePipe()
    {
        if(transform.position.x< deadZone) {
            Debug.Log("pipe Deleted...");
            Destroy(gameObject);
        }

    }
}