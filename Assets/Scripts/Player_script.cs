using UnityEngine;

public class Player_script : MonoBehaviour
{ 
    Vector2 head_diraction = new Vector2(0,-1);
    Vector2 moving_diraction;
    Vector2 pos = new Vector2 (0.5f, 0.5f);
    Vector2 last_pos;
    Vector2 local_pos;
    Vector2 next_pos;
    bool is_moving = false;
    
    float size;
    float t;

    //int body_order = 0;
    //int tail_size = 0; 
    //Vector2[] last_locations = null;
    //GameObject[] tails = null;

    void Start()
    {
        Application.targetFrameRate = 60;
        size = 1.28f * 0.275f;
    }

    void Update()
    {

        Take_movment();
        Move(); 
    }

    void Move()
    {
        if (t >= 1)
        {
            pos = next_pos;
            is_moving = false;
            t = 0.05f;
            Debug.Log("i am here");
        }
        if (!is_moving)
        {
            moving_diraction = head_diraction;
            last_pos = pos;
            next_pos.x = pos.x+moving_diraction.x;
            next_pos.y = pos.y+moving_diraction.y;
            is_moving = true;    
        }


        pos.x = Mathf.Lerp(last_pos.x,next_pos.x, t);
        pos.y = Mathf.Lerp(last_pos.y,next_pos.y, t);
    

        local_pos.x = pos.x * size;
        local_pos.y = pos.y * size;
        transform.position = local_pos;
        
        t += 0.05f;
    }

    void Take_movment() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            head_diraction = new Vector2(0,1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            head_diraction = new Vector2(0,-1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            head_diraction = new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            head_diraction = new Vector2(1, 0);
        }
    }





}
