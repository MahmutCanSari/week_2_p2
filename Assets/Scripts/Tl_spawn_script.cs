using UnityEngine;

public class Tl_spawn_script : MonoBehaviour
{
    public int x_size;
    public int y_size;
    public GameObject Tl_prefab; 
    Vector2 pos;

    void Start()
    {
        Debug.Log("i am ");
        for (int i = x_size/2; i>-x_size; i--) 
        {
            if(i!=0)
            {
                for (int j = y_size / 2; j > -y_size; j--)
                {
                    if (j != 0)
                    {
                        pos = new Vector2(i, j);
                        Debug.Log(pos);
                        GameObject new_Tl = Instantiate(Tl_prefab, pos, Quaternion.identity);
                    }
                }
            }
        }
    }
}
