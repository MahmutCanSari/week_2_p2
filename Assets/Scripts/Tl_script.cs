using UnityEngine;

public class Tl_script : MonoBehaviour
{
    Vector2 tl_loc = Vector2.zero;
    public float global_size;
    float loc_size;
    Vector3 loc = Vector2.zero;



    void Start()
    {
        loc_size = 0.32f / global_size;
        tl_loc = transform.position;
        Debug.Log(tl_loc);
        if (tl_loc.x > 0)
        {
            loc.x = (tl_loc.x - 1) * loc_size + loc_size / 2;
        }
        else
        {
            loc.x = (tl_loc.x + 1) * loc_size + loc_size / 2;
        }


        if (tl_loc.y > 0) { loc.y = (tl_loc.y - 1) * loc_size + loc_size / 2; }
        else { loc.y = (tl_loc.y + 1) * loc_size + loc_size / 2; }
        loc.z = 5f;

        transform.position = loc;
        transform.localScale = new Vector3(global_size,global_size,1f);
    }

}
