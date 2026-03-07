using UnityEngine;

public class Tl_script : MonoBehaviour
{
    Vector2 tl_loc = Vector2.zero;
    public float global_size;
    float loc_size = 1.28f;
    Vector3 loc = Vector2.zero;



    void Start()
    {
        loc_size *= global_size;
        tl_loc = transform.position;
        
        loc.x = tl_loc.x*loc_size;
        loc.y = tl_loc.y*loc_size;

        transform.position = new Vector3(loc.x,loc.y,5f);
        transform.localScale = new Vector3(global_size,global_size,1f);
    }

}
