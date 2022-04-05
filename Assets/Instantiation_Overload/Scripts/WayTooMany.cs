using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayTooMany : MonoBehaviour
{

    public int createX;
    public int createY;
    public int createZ;
    public Transform prefab;

    void Start()
    {
        CreateMany(createX, createY, createZ);
    }

    void Update()
    {

    }


    void CreateMany(int _x, int _y, int _z)
    {
        for (int i = 0; i < _x; i++)
        {
            for (int j = 0; j < _y; j++)
            {
                for (int k = 0; k < _z; k++)
                {
                    var obj = Instantiate(prefab, new Vector3(i * 2.0F, j * 2.0F, k * 2.0F) + transform.position, Quaternion.identity);
                    obj.transform.SetParent(this.transform);
                }
            }
        }
    }



}
