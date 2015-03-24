using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    public float rotateSpeed = 5f;
    public float angelThreshold = 15f;

    public GameObject Player;
    public List<GameObject> targetList = new List<GameObject>();

    void debugLine()
        {
            Debug.DrawRay(Player.transform.position,Quaternion.Euler(0f,angelThreshold,0f)*Player.transform.forward*10,Color.red);
            Debug.DrawRay(Player.transform.position, Quaternion.Euler(0f, -angelThreshold, 0f) * Player.transform.forward * 10, Color.red);
        }

    //void rotatePlayer(float input)
        //{
            //Player.transform.Rotate(Vector3.up, input*rotateSpeed);
         //}
    void showInfo(TextMesh _textMesh ,float distance , float angle,bool inFront)
        {
            if (_textMesh != null){
                if(inFront)
                    {
                        _textMesh.color = Color.green;
                        _textMesh.text = "Distance: " + distance.ToString() + "\r\nAngle: " + angle.ToString();
                    }
                else
                    {
                        _textMesh.color = Color.red;
                        _textMesh.text = "nope";
                    }
            }
            else
                Debug.Log("Null textMesh");
        }

    void testAngle(GameObject fromObj , GameObject toObj)
         {
             Vector3 dif = toObj.transform.position-fromObj.transform.position;
             
             Vector3 fromFront = new Vector3(fromObj.transform.forward.x, 0f, fromObj.transform.forward.z);
             Vector3 dir = new Vector3 (dif.x,0f,dif.z);
             float _Angle = Vector3.Angle(fromFront,dir);
             bool _inFront = _Angle < angelThreshold;
             showInfo(toObj.GetComponentInChildren<TextMesh>(), Vector3.Distance(toObj.transform.position, fromObj.transform.position), _Angle, _inFront);
             //return (_inFront);
         }

    void checkAngleAll()
        {
            for(int i =0; i<targetList.Count;i++)
            {
                testAngle(Player, targetList[i]);
            }
            
        }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        debugLine();
        //rotatePlayer( Input.GetAxis("Vertical"));
        checkAngleAll();
        //rotatePlayer(1f);
	}
}
