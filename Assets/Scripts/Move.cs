using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
[SerializeField] GameObject A;
public GameObject B;
//private vector3 vectorialA;
private Vector3 vectorialB;

float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = A.transform.position;
        float Bx = B.transform.position.x;

        float By = B.transform.position.y;
        float Bz = B.transform.position.z;
        vectorialB = new Vector3(Bx, By, Bz); 
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Transform", 2);
    }

    void Transform() 
    {
        
        transform.position = Vector3.MoveTowards(transform.position, vectorialB, 6 * Time.deltaTime);

    }
}
