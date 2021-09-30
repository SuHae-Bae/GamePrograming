using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 클릭하면 회전 속도를 설정한다.
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = -10;
        }
        
        // 회전 속도만큼 긴바늘을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        // 긴바늘을 감속시킨다.
        this.rotSpeed *= 0.98f;
    }
}
