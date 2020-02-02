using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Animator _animator;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = .5f;
        float ts = Time.fixedDeltaTime;
        Vector3 p = transform.position;
        Vector3 s = transform.localScale;
        s.x = 1.0f;
        _animator.SetBool("walkUp", Input.GetKey(KeyCode.UpArrow));
        _animator.SetBool("walkDown", Input.GetKey(KeyCode.DownArrow));
        _animator.SetBool("walkLeft", Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow));
        if (Input.GetKey(KeyCode.LeftArrow))
		{
			p.x -= speed * ts;
            
		}
        if (Input.GetKey(KeyCode.RightArrow))
        {
            p.x += speed * ts;
            s.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            p.y += speed * ts;
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
			p.y -= speed * ts;
        }
        transform.position = p;
        transform.localScale = s;

    }
}
