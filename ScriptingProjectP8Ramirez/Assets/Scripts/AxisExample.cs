using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "value Returned:" + h.ToString("F2");
    }
}
