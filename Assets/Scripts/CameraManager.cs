using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float minX = -2.5f;
    public float maxX = 1f;
    public float minY = -1.5f;
    public float maxY = 1f;
    private Transform cTransform;
    public Transform pTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        cTransform = this.GetComponent<Transform>();
        pTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        cTransform.position = new Vector3(
            Mathf.Clamp(pTransform.position.x, minX, maxX), 
            Mathf.Clamp(pTransform.position.y, minY, maxY),
            cTransform.position.z); 
    }
}
