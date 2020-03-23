using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject Dove;
    public GameObject Hawk;
    public GameObject Food;
    private Vector3 minimum;
    private Vector3 maximum;
    private float x_axis;
    private float y_axis;
    private float z_axis;
    private Vector3 random_pos;
    public bool c_Instantiate;

    // Start is called before the first frame update
    void Start()
    {
        SetRange();
    }

    private void SetRange() 
    {
        minimum = new Vector3(3, 5, 0);
        maximum = new Vector3(15, 35, 0);
    }

    private void GenerateRandom()
    {
        x_axis = UnityEngine.Random.Range(minimum.x, maximum.x);
        y_axis = UnityEngine.Random.Range(minimum.y, maximum.y);
        z_axis = UnityEngine.Random.Range(minimum.z, maximum.z);
        random_pos = new Vector3(x_axis, y_axis, z_axis);
    }
    // Update is called once per frame
    void Update()
    {



        GenerateRandom();
        Instantiate(Dove, random_pos, Quaternion.identity);
        GenerateRandom();
        Instantiate(Hawk, random_pos, Quaternion.identity);
        GenerateRandom();
        Instantiate(Food, random_pos, Quaternion.identity);
       // if (c_Instantiate)
       // {
            //Instantiate(gameObject, random_pos, Quaternion.identity);
       // }
    }
}
