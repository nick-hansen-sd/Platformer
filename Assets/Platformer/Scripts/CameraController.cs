using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform target;

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x;
        transform.position = pos;
    }
}
