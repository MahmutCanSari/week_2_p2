using UnityEngine;

public class Tl_script : MonoBehaviour
{
    public Vector2 tl_list_loc = Vector2.zero;
    Vector3 loc = Vector2.zero;
    float size = 0.38f;

    void Start()
    {
        tl_list_loc = transform.position;
        loc.x = (size/2)+tl_list_loc.x*size;
        loc.y = (size/2)+tl_list_loc.y*size;
        loc.z = 5f;

        transform.position = loc;
        transform.localScale = new Vector3(size, size, 1f);
    }

}
