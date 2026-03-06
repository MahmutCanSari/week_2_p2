using UnityEngine;

public class Tl_spawn_script : MonoBehaviour
{
    public int x_size;
    public int y_size;
    public GameObject Tl_prefab; 
    Vector2 pos;

    void Start()
    {
        --x_size;
        --y_size;
        for(int y=y_size+1; y>=-y_size; y--) 
        {
            for (int x=x_size+1; x>=-x_size; x--) 
            {
                pos = new Vector2(x-0.5f,y-0.5f);
                Instantiate(Tl_prefab, pos, Quaternion.identity);
            }
        }
    }
}
