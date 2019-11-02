using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDir : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed =20f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir= new Vector3(0f,0f,0f);
        dir.y+=speed*Input.GetAxis("Mouse X");
        dir.x-=speed*Input.GetAxis("Mouse Y");
        transform.rotation=dir;
    }
}
