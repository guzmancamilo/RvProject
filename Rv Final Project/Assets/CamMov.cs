
using UnityEngine;

public class CamMov : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 20f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos =transform.position;
        if(Input.GetKey("w")){
            pos.z += Speed * Time.deltaTime;
        }
        if(Input.GetKey("s")){
            pos.z += -Speed * Time.deltaTime;
        }
        if(Input.GetKey("a")){
            pos.x += -Speed * Time.deltaTime;
        }
        if(Input.GetKey("d")){
            pos.x += Speed * Time.deltaTime;
        }
        transform.position=pos;
    }
}
