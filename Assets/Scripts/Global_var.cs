using System.Collections.Generic;
using UnityEngine;

public class Global_var : MonoBehaviour
{
    public static Global_var instance;

    public List<GameObject> tl_list;
    public float tl_scale = 0.38f;
    public Vector2 tl_size = new Vector2(8,12);

    
    private void Awake()
    {
        instance = this;
    }

}
