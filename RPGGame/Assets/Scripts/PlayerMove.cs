using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour {
    float speed = 10;
    public GameObject cameraGameObject;
    void Start()
    {
        if (isLocalPlayer)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            cameraGameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (!isLocalPlayer)
            return;
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
    }
}
