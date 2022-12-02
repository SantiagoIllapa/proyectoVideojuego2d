using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float velocidad = 0.125f;
    public Vector3 offset;
    

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 cameraPos=target.position;
        cameraPos.y = transform.position.y;
        
        if(target.position.x>0.15 && target.position.x<23.83)
        transform.position=cameraPos + offset;
        
        
    }
}
