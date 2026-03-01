using UnityEngine;

public class Tl_spawn_script : MonoBehaviour
{
    Vector2 size =new Vector2(12,12);
    public GameObject Tl_prefab; 
    Vector2 pos;
    void Start()
    {
        for (float i = -size.x/2; i < size.x/2; i++) 
        {
            for(int j = 0; j < size.y; j++) 
            {
                pos = new Vector2(i, j);
                GameObject new_Tl = Instantiate(Tl_prefab, pos, Quaternion.identity);
                //Global_var.instance.tl_list.Add(new_Tl);
            }
        }
        
    }
}
