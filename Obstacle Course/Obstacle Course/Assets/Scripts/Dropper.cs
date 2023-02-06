using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeElapsed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        // Turn meshrenderer and gravity to DISABLED so that we can´t see the object UNTIL the timeElapsed is true
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Turn meshrenderer and gravity to ENABLED so that we can see the object AFTER the timeElapsed is true 
        if(Time.time > timeElapsed) {
            Debug.Log("Stuff is falling! Beware!");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
