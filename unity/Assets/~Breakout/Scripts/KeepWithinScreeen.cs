using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class NewBehaviourScript : MonoBehaviour
{
    private Renderer rend;
    private Camera cam;
    private Bounds camBounds;
    private float camWidth, camHeight;
	// Use this for initialization
	void Start ()
    {
        cam = Camera.main;
        rend = GetComponent<Renderer>();
	}


    void UpdateCamBounds()
    {
        
       
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
        camBounds = new Bounds(cam.transform.position, new Vector3(camWidth, camHeight));
    }
    Vector3 CheckBounds()
    {
        Vector3 pos = transform.position;
        Vector3 size = rend.bounds.size;
        float halfWidth = size.x * 0.5f;
        float halfHeight = size.y * 0.5f;
        float halfCamWidth = camWidth * 0.5f;
        float halfCamHeight = camHeight * 0.5f;
        if(pos.x - halfWidth < camBounds.min.x)
        {
            pos.x = camBounds.min.x + halfWidth;
        }
        if (pos.x - halfWidth < camBounds.min.x)
        {
            pos.x = camBounds.min.x - halfWidth;
        }
        if (pos.y - halfHeight < camBounds.min.y)
        {
            pos.y = camBounds.min.y + halfHeight;
        }
        if (pos.y - halfHeight < camBounds.min.y)
        {
            pos.y = camBounds.min.y - halfHeight;
        }
        return pos;
    }
	// Update is called once per frame
	void Update ()
    {
        UpdateCamBounds();
        transform.position = CheckBounds();
	}
}
