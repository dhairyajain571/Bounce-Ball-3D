using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_check : MonoBehaviour
{
    // Start is called before the first frame update
    bool isfell;
    void Update()
    {
        if(isfell==true)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }

    private void OnCollisionStay()
    {
        isfell = true;
    }
}
