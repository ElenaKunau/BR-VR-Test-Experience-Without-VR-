using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
  public float timer = 0f;
  public Transform boxPos;

  public GameObject box;

void Start()
  {

  }

  // Update is called once per frame
  void Update()

{
timer += Time.deltaTime;
if(timer > 5)
{
timer = 0;
Instantiate(box, startPos(), boxPos.rotation);
}

if (Input.GetMouseButton(0))
{
Debug.Log("BOX UNTERWEGS");
Instantiate(box, startPos(), boxPos.rotation);
}
}

Vector3 startPos()
{
int i = Random.Range(0, 8);
int y = 20;
Vector3 startPos = new Vector3(0, 0, 0);

switch (i)
{
case 0:
startPos.x = 9;
startPos.y = y;
startPos.z = 3;
return startPos;
break;
case 1:
startPos.x = 9;
startPos.y = y;
startPos.z = -3;
return startPos;
break;
case 2:
startPos.x = 3;
startPos.y = y;
startPos.z = 9;
return startPos;
break;
case 3:
startPos.x = -3;
startPos.y = y;
startPos.z = 9;
return startPos;
break;
case 4:
startPos.x = -3;
startPos.y = y;
startPos.z = -9;
return startPos;
break;
case 5:
startPos.x = -3;
startPos.y = y;
startPos.z = -9;
return startPos;
break;
case 6:
startPos.x = -9;
startPos.y = y;
startPos.z = 3;
return startPos;
break;
case 7:
startPos.x = -9;
startPos.y = y;
startPos.z = -3;
return startPos;
break;

default:
startPos.x = 9;
startPos.y = y;
startPos.z = 3;
return startPos;
break;
}

}
}
