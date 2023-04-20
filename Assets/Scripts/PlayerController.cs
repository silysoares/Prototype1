using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizintalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        // Mover o veiculo para frente

        horizontalInput = Input.GetAxis("Horizontal");
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
