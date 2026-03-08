using System;
using UnityEngine;

public class Tail_script : MonoBehaviour
{

    Vector2 pos = new Vector2(0.5f, 0.5f);
    Vector2 last_pos;
    Vector2 local_pos;
    Vector2 next_pos;
    Vector2 out_pos;

    float size;
    float t=0f;

    void Start()
    {
        size = 1.28f * 0.275f;
    }

    void Update()
    {
        
        Move();
    }

    internal void get_loc(Vector2 temp) 
    {
        out_pos = temp;
    }

    public void Move()
    {
        Debug.Log("yyyy");
        if (t >= 1)
        {
            pos = next_pos;
            next_pos = out_pos;
            t = 0.05f;
            last_pos = pos;      
        }

        pos.x = Mathf.Lerp(last_pos.x, next_pos.x, t);
        pos.y = Mathf.Lerp(last_pos.y, next_pos.y, t);


        local_pos.x = pos.x * size;
        local_pos.y = pos.y * size;
        transform.position = local_pos;

        t += 0.05f;
    }


}
