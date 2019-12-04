using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4.0f;
    void Start()
    {
        
    }

    private void OnMouseDown() {
        Destroy(this.gameObject);
        Player.instance.score += 1;
            
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y >= 6){
            Destroy(this.gameObject);
        }
    }
}
