using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    int CharacterPosition=0;// -1 : 왼쪽, 0 : 가운데 , 1 : 오른쪽
    Vector3 LeftPosition = new Vector3(-2f, 0f, 0f);
    Vector3 CenterPosition = new Vector3(0f, 0f, 0f);
    Vector3 RightPosition = new Vector3(2f, 0f, 0f);

    public GameObject MC;
    public GameObject CR;

    float CharacterVelocity;

    // Start is called before the first frame update
    void Start()
    {
        CharacterVelocity = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray(CR.transform.position, new Vector3(0f, 0f, 1f));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                transform.position = new Vector3(transform.position.x, transform.position.y, hit.point.z - 6f);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CharacterPosition == -1)
            {
                
            }
            else if(CharacterPosition == 0)
            {
                CharacterPosition = -1;
                CR.transform.position += LeftPosition;
            }
            else if(CharacterPosition ==1)
            {
                CharacterPosition = 0;
                CR.transform.position += LeftPosition;
            }
            else
            {
                Debug.Log("error getkey-left");
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CharacterPosition == -1)
            {
                CharacterPosition = 0;
                CR.transform.position += RightPosition;
            }
            else if (CharacterPosition == 0)
            {
                CharacterPosition = 1;
                CR.transform.position += RightPosition;
            }
            else if (CharacterPosition == 1)
            {

            }
            else
            {
                Debug.Log("error getkey-right");
            }
        }

        transform.Translate(new Vector3(0f, 0f, 1f) * CharacterVelocity * Time.deltaTime);
    }
}
