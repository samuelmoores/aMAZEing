using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowExit : MonoBehaviour
{
    public GameObject Flag;
    public GameObject FlagInstance;
    public List<GameObject> FlagInstances;
    public Vector3 ExitPosition;
    public Quaternion ExitRotation;
    int counter = 0;
    int numFlags = 0;
    public int flagHeight = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Couner (Start):" + counter);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.E))
        {


            if (counter <= flagHeight)
            {
                Debug.Log("(if)Counter: " + counter);


                GameObject NewFlag = Instantiate(Flag, new Vector3(48.0f, (counter*2) + 2, -22), Quaternion.identity);

                switch(counter)
                {
                    case 0:
                        NewFlag.GetComponent<Renderer>().material.color = Color.white;
                        break;
                    case 1:
                        NewFlag.GetComponent<Renderer>().material.color = Color.black;
                        break;
                    case 2:
                        NewFlag.GetComponent<Renderer>().material.color = Color.red;
                        break;
                    case 3:
                        NewFlag.GetComponent<Renderer>().material.color = Color.blue;
                        break;
                }


                FlagInstances.Add(NewFlag);
                counter++;

                numFlags = counter - 1;

            }
            else
            {
                Debug.Log("(else)numFlags: " + numFlags);

                if (numFlags >= 0)
                {
                    Destroy(FlagInstances[numFlags]);
                    numFlags--;
                }

            }
        }
    }
}
