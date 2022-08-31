
using UnityEngine;

public class coin_rotate : MonoBehaviour
{

    Vector3 rotatecoins; 
    void FixedUpdate()
    {

        rotatecoins = new Vector3(5, 0, 0);
        transform.Rotate(rotatecoins);
    }
}
